using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Trading_Company
{
    public partial class CurrentProduct : Form
    {
        int id, id_purchase, count, price;
        bool flag = false;
        byte[] photo, basePhoto;
        string name, category, vat, unit, summary;

        private void countBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            // Если пользователь ввёл не цифру,запятую и не нажал на Backspace, то не отображаем символ в textbox
            // 8 это Backspace
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            // Если пользователь ввёл не цифру,запятую и не нажал на Backspace, то не отображаем символ в textbox
            // 8 это Backspace
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void vatBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            // Если пользователь ввёл не цифру,запятую и не нажал на Backspace, то не отображаем символ в textbox
            // 8 это Backspace
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        public CurrentProduct(int id, int id_purchase, int count, int price, bool detail)
        {
            InitializeComponent();
            if (detail)
            {
                bDeleteProduct.Visible = false;
                bChange.Visible = false;
            }

            this.id = id;
            this.id_purchase = id_purchase;
            this.count = count;
            this.price = price;

            ConnectionToDB.openDB();

            SQLiteCommand param = new SQLiteCommand("SELECT name FROM products WHERE id = '" + id + "'", ConnectionToDB.DB);
            nameBox.Text = param.ExecuteScalar().ToString();
            name = nameBox.Text;

            param = new SQLiteCommand("SELECT category FROM products WHERE id = '" + id + "'", ConnectionToDB.DB);
            categoryBox.Text = param.ExecuteScalar().ToString();
            category = categoryBox.Text;

            param = new SQLiteCommand("SELECT vat FROM products WHERE id = '" + id + "'", ConnectionToDB.DB);
            vatBox.Text = param.ExecuteScalar().ToString();
            vat = vatBox.Text;

            param = new SQLiteCommand("SELECT unit_of_measurement FROM products WHERE id = '" + id + "'", ConnectionToDB.DB);
            unitBox.Text = param.ExecuteScalar().ToString();
            unit = unitBox.Text;

            

            countBox.Text = count.ToString();

            priceBox.Text = price.ToString();

            param = new SQLiteCommand("SELECT image FROM products WHERE id = '" + id + "'", ConnectionToDB.DB);

            byte[] image = (byte[])param.ExecuteScalar();
            
            photo = image;
            pictureBox1.Image = byteArrayToImage(photo);
            basePhoto = photo;

            param = new SQLiteCommand("SELECT characteristic FROM products WHERE id = '" + id + "'", ConnectionToDB.DB);
            richSummaryBox.Text = param.ExecuteScalar().ToString();

            summary = richSummaryBox.Text;

            ConnectionToDB.closeDB();
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            nameBox.ReadOnly = false;
            categoryBox.ReadOnly = false;
            countBox.ReadOnly = false;
            priceBox.ReadOnly = false;
            unitBox.ReadOnly = false;
            vatBox.ReadOnly = false;
            richSummaryBox.ReadOnly = false;
            flag = true;
            bDeleteProduct.Enabled = false;
            bOk.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                var filePath = string.Empty;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Изображение. Файл формата  *.png|*.jpg|*.jpeg|*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(filePath);

                    photo = GetPhoto(filePath);
                }

            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)       // Из байтов в изображение
        {
            if (byteArrayIn != null)
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                Image returnImage = Image.FromStream(ms, true);
                return returnImage;
            }
            return null;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            Boolean close = false;

            try
            {
                if (nameBox.Text != "" && categoryBox.Text != "" && unitBox.Text != "" && vatBox.Text != "" && countBox.Text != "" && priceBox.Text != "" && richSummaryBox.Text != "")
                {
                    if ((nameBox.Text.ToLower().Equals(name.ToLower()) && categoryBox.Text.ToLower().Equals(category.ToLower()) && unitBox.Text.ToLower().Equals(unit.ToLower()) && vatBox.Text.Equals(vat) && countBox.Text.Equals(count.ToString()) && priceBox.Text.Equals(price.ToString()) && richSummaryBox.Text.ToLower().Equals(summary.ToLower()) && Enumerable.SequenceEqual(photo, basePhoto)))
                    {
                        MessageBox.Show("Изменений не нашлось!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ConnectionToDB.openDB();

                        if ((count != Convert.ToInt32(countBox.Text) || price != Convert.ToInt32(priceBox.Text)) && (nameBox.Text.ToLower().Equals(name.ToLower()) && categoryBox.Text.ToLower().Equals(category.ToLower()) && unitBox.Text.ToLower().Equals(unit.ToLower()) && vatBox.Text.Equals(vat) && richSummaryBox.Text.ToLower().Equals(summary.ToLower()) && Enumerable.SequenceEqual(photo, basePhoto)))
                        {
                            SQLiteCommand update = new SQLiteCommand("UPDATE product_list_in_purchase SET count_product_in_purchase  = '" + countBox.Text + "', price_product_in_purchase  = '" + priceBox.Text + "' WHERE id_product = '" + id + "' AND id_purchase = '" + id_purchase + "' AND count_product_in_purchase = '" + count + "' AND price_product_in_purchase = '" + price + "'", ConnectionToDB.DB);
                            update.ExecuteNonQuery();

                            ConnectionToDB.closeDB();
                            close = true;
                        }

                        SQLiteCommand isnew = new SQLiteCommand("SELECT isnewproduct FROM product_list_in_purchase WHERE id_product = '" + id + "'", ConnectionToDB.DB);
                        if (!close && isnew.ExecuteScalar().ToString() == "False")
                        {
                            SQLiteCommand command = new SQLiteCommand("INSERT INTO products (name, category, characteristic, unit_of_measurement, vat, image, id_company) VALUES ('" + nameBox.Text + "', '" + categoryBox.Text + "', " +
                        "'" + richSummaryBox.Text + "', '" + unitBox.Text + "', '" + vatBox.Text + "', @photo, (SELECT id_company FROM purchase WHERE id = '" + id_purchase + "'))", ConnectionToDB.DB);
                            command.Parameters.AddWithValue("@photo", photo);
                            command.ExecuteNonQuery();

                            SQLiteCommand getID = new SQLiteCommand("SELECT MAX(id) FROM products", ConnectionToDB.DB);
                            int id_prod = Convert.ToInt32(getID.ExecuteScalar());

                            SQLiteCommand create = new SQLiteCommand("INSERT INTO warehouse (id_product, count_product, sector_on_warehouse) VALUES ('" + id_prod + "', '" + Convert.ToInt32(countBox.Text) + "', '" + getID.ExecuteScalar().ToString() + nameBox.Text[0] + "')", ConnectionToDB.DB);
                            create.ExecuteNonQuery();

                            SQLiteCommand update = new SQLiteCommand("UPDATE product_list_in_purchase SET id_product = '" + id_prod + "', price_product_in_purchase = '" + Convert.ToInt32(priceBox.Text) + "', count_product_in_purchase = '" + Convert.ToInt32(countBox.Text) + "' WHERE id_product = '" + id + "' AND id_purchase = '" + id_purchase + "' AND count_product_in_purchase = '" + count + "' AND price_product_in_purchase = '" + price + "'", ConnectionToDB.DB);
                            update.ExecuteNonQuery();

                            ConnectionToDB.closeDB();

                        }

                        // А если пользователь ничего не изменил?!?!?!?!

                        SQLiteCommand ifCMD = new SQLiteCommand("SELECT count_product FROM warehouse WHERE id_product = '" + id + "'", ConnectionToDB.DB);

                        if (!close && Convert.ToInt32(ifCMD.ExecuteScalar()) == count)
                        {
                            SQLiteCommand delete = new SQLiteCommand("DELETE FROM warehouse WHERE id_product = '" + id + "'", ConnectionToDB.DB);
                            delete.ExecuteNonQuery();
                            delete = new SQLiteCommand("DELETE FROM products WHERE id = '" + id + "'", ConnectionToDB.DB);
                            delete.ExecuteNonQuery();

                            SQLiteCommand command = new SQLiteCommand("INSERT INTO products (name, category, characteristic, unit_of_measurement, vat, image, id_company) VALUES ('" + nameBox.Text + "', '" + categoryBox.Text + "', " +
                        "'" + richSummaryBox.Text + "', '" + unitBox.Text + "', '" + vatBox.Text + "', @photo, (SELECT id_company FROM purchase WHERE id = '" + id_purchase + "'))", ConnectionToDB.DB);
                            command.Parameters.AddWithValue("@photo", photo);
                            command.ExecuteNonQuery();

                            SQLiteCommand getID = new SQLiteCommand("SELECT MAX(id) FROM products", ConnectionToDB.DB);
                            int id_prod = Convert.ToInt32(getID.ExecuteScalar());

                            SQLiteCommand create = new SQLiteCommand("INSERT INTO warehouse (id_product, count_product, sector_on_warehouse) VALUES ('" + id_prod + "', '" + Convert.ToInt32(countBox.Text) + "', '" + getID.ExecuteScalar().ToString() + nameBox.Text[0] + "')", ConnectionToDB.DB);
                            create.ExecuteNonQuery();

                            SQLiteCommand update = new SQLiteCommand("UPDATE product_list_in_purchase SET id_product = '" + id_prod + "', price_product_in_purchase = '" + Convert.ToInt32(priceBox.Text) + "', count_product_in_purchase = '" + Convert.ToInt32(countBox.Text) + "' WHERE id_product = '" + id + "' AND id_purchase = '" + id_purchase + "' AND count_product_in_purchase = '" + count + "' AND price_product_in_purchase = '" + price + "'", ConnectionToDB.DB);
                            update.ExecuteNonQuery();
                        }
                        else
                        {
                            if (!close)
                            {
                                SQLiteCommand delete = new SQLiteCommand("UPDATE warehouse SET count_product = count_product - '" + count + "'", ConnectionToDB.DB);
                                delete.ExecuteNonQuery();

                                SQLiteCommand command = new SQLiteCommand("INSERT INTO products (name, category, characteristic, unit_of_measurement, vat, image, id_company) VALUES ('" + nameBox.Text + "', '" + categoryBox.Text + "', " +
                            "'" + richSummaryBox.Text + "', '" + unitBox.Text + "', '" + vatBox.Text + "', @photo, (SELECT id_company FROM purchase WHERE id = '" + id_purchase + "'))", ConnectionToDB.DB);
                                command.Parameters.AddWithValue("@photo", photo);
                                command.ExecuteNonQuery();

                                SQLiteCommand getID = new SQLiteCommand("SELECT MAX(id) FROM products", ConnectionToDB.DB);
                                int id_prod = Convert.ToInt32(getID.ExecuteScalar());

                                SQLiteCommand create = new SQLiteCommand("INSERT INTO warehouse(id_product, count_product, sector_on_warehouse) VALUES ('" + id_prod + "', '" + Convert.ToInt32(countBox.Text) + "', '" + getID.ExecuteScalar().ToString() + nameBox.Text[0] + "')", ConnectionToDB.DB);
                                create.ExecuteNonQuery();

                                SQLiteCommand update = new SQLiteCommand("UPDATE product_list_in_purchase SET id_product = '" + id_prod + "', price_product_in_purchase = '" + Convert.ToInt32(priceBox.Text) + "', count_product_in_purchase = '" + Convert.ToInt32(countBox.Text) + "' WHERE id_product = '" + id + "' AND id_purchase = '" + id_purchase + "' AND count_product_in_purchase = '" + count + "' AND price_product_in_purchase = '" + price + "'", ConnectionToDB.DB);
                                update.ExecuteNonQuery();
                            }
                        }

                        ConnectionToDB.closeDB();
                    }
                }

                else
                {
                    MessageBox.Show("Все поля должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
            catch
            {
                MessageBox.Show("Ошибка изменения данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.Close();
        }

        private void CurrentProduct_Load(object sender, EventArgs e)
        {

        }

        private void bDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionToDB.openDB();

                SQLiteCommand ifCMD = new SQLiteCommand("SELECT isnewproduct FROM product_list_in_purchase WHERE id_product = '" + id + "' AND id_purchase = '" + id_purchase + "' AND price_product_in_purchase = '" + price + "' AND count_product_in_purchase = '" + count + "'", ConnectionToDB.DB);

                if (ifCMD.ExecuteScalar().ToString() == "True")
                {
                    SQLiteCommand delProd = new SQLiteCommand("DELETE FROM product_list_in_purchase WHERE id_product = '" + id + "' AND id_purchase = '" + id_purchase + "' AND price_product_in_purchase = '" + price + "' AND count_product_in_purchase = '" + count + "'", ConnectionToDB.DB);
                    delProd.ExecuteNonQuery();

                    delProd = new SQLiteCommand("DELETE FROM warehouse WHERE id_product = '" + id + "'", ConnectionToDB.DB);
                    delProd.ExecuteNonQuery();

                    delProd = new SQLiteCommand("DELETE FROM products WHERE id = '" + id + "'", ConnectionToDB.DB);
                    delProd.ExecuteNonQuery();
                }
                else
                {
                    SQLiteCommand delProd = new SQLiteCommand("DELETE FROM product_list_in_purchase WHERE id_product = '" + id + "' AND id_purchase = '" + id_purchase + "' AND price_product_in_purchase = '" + price + "' AND count_product_in_purchase = '" + count + "'", ConnectionToDB.DB);
                    delProd.ExecuteNonQuery();
                }



                ConnectionToDB.closeDB();
            }
            catch
            {
                MessageBox.Show("Ошибка удаления данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            this.Close();
        }

        public static byte[] GetPhoto(string filePath)      // Из изображения в байты
        {
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);

            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }
    }
}

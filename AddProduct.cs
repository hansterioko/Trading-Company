using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Trading_Company
{
    public partial class AddProduct : Form
    {
        int id_purchase;
        public AddProduct(int id_purchase)
        {
            InitializeComponent();
            this.id_purchase = id_purchase;
        }

        byte[] photo = GetPhoto(@"noPhoto.png");
        

        private void vatBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Получаем символ, который ввёл пользователь
            char number = e.KeyChar;

            // Если пользователь ввёл не цифру,запятую и не нажал на Backspace, то не отображаем символ в textbox
            if (!Char.IsDigit(number) && number != 44 && number != 8)
                e.Handled = true;
        }

        private void bAddPhoto_Click(object sender, EventArgs e)
        {
            string filePath;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображение. Файл формата  *.png|*.jpg|*.jpeg|*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                picturePhoto.Image = Image.FromFile(filePath);

                photo = GetPhoto(filePath);
            }
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

        private void bAddProductInList_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameBox1.Text != "" && categoryBox2.Text != "" && unitBox3.Text != "" && vatBox4.Text != "" && countBox1.Text != "" && priceBox.Text != "" && richSummaryBox.Text != "")
                {
                    ConnectionToDB.openDB();

                    SQLiteCommand command;
                    SQLiteCommand warehouseCMD;

                    // Поиск id, где имя, категория и описание сходятся с написанным в форме
                    SQLiteCommand ifCMD = new SQLiteCommand("SELECT id FROM products WHERE id = (SELECT id FROM products WHERE name = '" + nameBox1.Text + "' AND category = '" + categoryBox2.Text + "' AND characteristic = '" + richSummaryBox.Text + "' AND vat = '" + vatBox4.Text + "' AND unit_of_measurement = '" + unitBox3.Text + "' AND image = @photo AND id_company = (SELECT id_company FROM purchase WHERE id = '" + id_purchase + "'))", ConnectionToDB.DB);
                    ifCMD.Parameters.AddWithValue("@photo", photo);

                    ifCMD.CommandType = CommandType.Text;

                    // Если всё-таки нашло схожее, то false
                    if (ifCMD.ExecuteScalar() == null)
                    {
                        //  Т.к. не нашло, то создаётся новый товар
                        command = new SQLiteCommand("INSERT INTO products (name, category, characteristic, unit_of_measurement, vat, image, id_company) VALUES ('" + nameBox1.Text + "', '" + categoryBox2.Text + "', " +
                        "'" + richSummaryBox.Text + "', '" + unitBox3.Text + "', '" + vatBox4.Text + "', @photo, (SELECT id_company FROM purchase WHERE id = '" + id_purchase + "'))", ConnectionToDB.DB);
                        command.Parameters.AddWithValue("@photo", photo);
                        command.ExecuteNonQuery();

                        // Запись о товаре на склад
                        warehouseCMD = new SQLiteCommand("INSERT INTO warehouse (id_product, count_product, sector_on_warehouse) VALUES ('" + ifCMD.ExecuteScalar().ToString() + "', '" + Convert.ToInt32(countBox1.Text) + "', '" + ifCMD.ExecuteScalar().ToString() + nameBox1.Text[0] + "')", ConnectionToDB.DB);
                        warehouseCMD.ExecuteNonQuery();
                    }
                    else
                    {
                        // Т.к. такой товар уже создан, то его НДС обновляется и ...
                        //command = new SQLiteCommand("UPDATE products SET vat = '" + vatBox4.Text + "' WHERE id = '" + ifCMD.ExecuteScalar().ToString() + "'", ConnectionToDB.DB);
                        //command.ExecuteNonQuery();

                        // И добавляется количество на складе
                        warehouseCMD = new SQLiteCommand("UPDATE warehouse SET count_product = count_product + '" + Convert.ToInt32(countBox1.Text) + "' WHERE id_product = '" + ifCMD.ExecuteScalar().ToString() + "'", ConnectionToDB.DB);
                        warehouseCMD.ExecuteNonQuery();
                    }

                    int id_prod = Convert.ToInt32(ifCMD.ExecuteScalar());
                    ConnectionToDB.closeDB();
                    ProductListInPurchase productListInPurchase = new ProductListInPurchase(Convert.ToInt32(priceBox.Text), Convert.ToInt32(countBox1.Text), id_prod, id_purchase);

                    productListInPurchase.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Все поля должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка добавления данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void countBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            // Если пользователь ввёл не цифру,запятую и не нажал на Backspace, то не отображаем символ в textbox
            // 8 это Backspace
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            ProductListInPurchase productListInPurchase = new ProductListInPurchase();
            productListInPurchase.Show();
            this.Close();
        }

        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            // Если пользователь ввёл не цифру,запятую и не нажал на Backspace, то не отображаем символ в textbox
            // 8 это Backspace
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richSummaryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bAddHaveProduct_Click(object sender, EventArgs e)
        {
            SelectProductInPurchase selectProductInPurchase = new SelectProductInPurchase(id_purchase);
            selectProductInPurchase.Show();
            this.Close();
        }
    }
}

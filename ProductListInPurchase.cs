using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using System.Drawing;

namespace Trading_Company
{
    public partial class ProductListInPurchase : Form
    {
        int id_purchase;
        int price_purchase;

        public ProductListInPurchase()
        {
            InitializeComponent();
        }

        // от формы выбора времени создана закупка, значит передаётся её id
        public ProductListInPurchase(int id_purchase)
        { 
            InitializeComponent();
            this.id_purchase = id_purchase;
            
        }

        // При пересылке с формы товара с кол-вом и ценой товара и id
        public ProductListInPurchase(int price_product, int count_product, int id_product, int id_purchase)
        {
            InitializeComponent();

            this.id_purchase = id_purchase;

            ConnectionToDB.openDB();

            SQLiteCommand ifCMD = new SQLiteCommand("SELECT id_product FROM product_list_in_purchase WHERE id_product = '"+ id_product + "' AND id_purchase = '"+ id_purchase +"'", ConnectionToDB.DB);
            if (ifCMD.ExecuteScalar() != null)
            {
                SQLiteCommand upd = new SQLiteCommand("SELECT id_product, price_product_in_purchase FROM product_list_in_purchase WHERE id_product = '" + id_product + "' AND id_purchase = '" + id_purchase + "'", ConnectionToDB.DB);
                SQLiteDataReader reader = upd.ExecuteReader();
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["price_product_in_purchase"]) == price_product)
                    {
                        upd = new SQLiteCommand("UPDATE product_list_in_purchase SET count_product_in_purchase = count_product_in_purchase + '"+ count_product +"' WHERE id_product = '" + Convert.ToInt32(reader["id_product"]) + "' AND id_purchase = '"+ id_purchase + "' AND price_product_in_purchase = '"+ price_product + "' AND count_product_in_purchase = '"+ count_product +"'", ConnectionToDB.DB);
                        upd.ExecuteNonQuery();
                    }
                    else
                    {
                        SQLiteCommand addProdList = new SQLiteCommand("INSERT INTO product_list_in_purchase (id_product, id_purchase, price_product_in_purchase, count_product_in_purchase)" +
                " VALUES ('" + id_product + "', '" + id_purchase + "', '" + price_product + "', '" + count_product + "')", ConnectionToDB.DB);
                        addProdList.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                SQLiteCommand addProdList = new SQLiteCommand("INSERT INTO product_list_in_purchase (id_product, id_purchase, price_product_in_purchase, count_product_in_purchase)" +
                " VALUES ('" + id_product + "', '" + id_purchase + "', '" + price_product + "', '" + count_product + "')", ConnectionToDB.DB);
                addProdList.ExecuteNonQuery();
            }

            ConnectionToDB.closeDB();
        }
        // Сделать подсчёт суммы закупки
        private void bAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(id_purchase);
            addProduct.Show();
            this.Close();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            if (dataGridView1.RowCount != 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    
                    SQLiteCommand ifCMD = new SQLiteCommand("SELECT count_product FROM warehouse WHERE id_product = (SELECT product_list_in_purchase.id_product FROM product_list_in_purchase JOIN products ON " +
                    "product_list_in_purchase.id_product = products.id WHERE product_list_in_purchase.id_purchase = '" + id_purchase + "' AND products.name = '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "')", ConnectionToDB.DB);
                    //ifCMD = new SQLiteCommand("SELECT id FROM products WHERE name = '"+ dataGridView1.Rows[i].Cells[0].Value.ToString() + "'", ConnectionToDB.DB);
                    //richTextBox1.Text += ifCMD.ExecuteScalar().ToString();

                    if (ifCMD.ExecuteScalar().ToString().Equals(dataGridView1.Rows[i].Cells[3].Value.ToString()))
                    {
                        SQLiteCommand delFromWarehouse = new SQLiteCommand("DELETE FROM warehouse WHERE id_product = (SELECT product_list_in_purchase.id_product FROM product_list_in_purchase JOIN products ON " +
                        "product_list_in_purchase.id_product = products.id AND " +
                        "products.name = '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "' WHERE product_list_in_purchase.id_purchase = '" + id_purchase + "')", ConnectionToDB.DB);
                        delFromWarehouse.ExecuteNonQuery();

                        SQLiteCommand delProd = new SQLiteCommand("DELETE FROM products WHERE id = (SELECT product_list_in_purchase.id_product FROM product_list_in_purchase JOIN products ON " +
                        "product_list_in_purchase.id_product = products.id AND " +
                        "products.name = '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "' WHERE product_list_in_purchase.id_purchase = '" + id_purchase + "')", ConnectionToDB.DB);
                        delProd.ExecuteNonQuery();
                       
                    }
                    else
                    {
                        SQLiteCommand upd = new SQLiteCommand("UPDATE warehouse SET count_product = count_product - '" + dataGridView1.Rows[i].Cells[3].Value + "' WHERE id_product = (SELECT product_list_in_purchase.id_product FROM product_list_in_purchase JOIN products ON " +
                        "product_list_in_purchase.id_product = products.id AND " +
                        "products.name = '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "' WHERE product_list_in_purchase.id_purchase = '" + id_purchase + "')", ConnectionToDB.DB);
                        upd.ExecuteNonQuery();
                    }

                }
                

            }

            SQLiteCommand deletePurchase = new SQLiteCommand("DELETE FROM purchase WHERE id = '"+ id_purchase +"'", ConnectionToDB.DB);
            deletePurchase.ExecuteNonQuery();

            SQLiteCommand deleteProductList = new SQLiteCommand("DELETE FROM product_list_in_purchase WHERE id_purchase = '" + id_purchase + "'", ConnectionToDB.DB);
            deleteProductList.ExecuteNonQuery();

            // удалять созданный товар, если его кол-во равно созданому, либо вычитать кол-во


            // ВНИМАНИЕ


            // ВНИМАНИЕ  // ВНИМАНИЕ     // ВНИМАНИЕ     // ВНИМАНИЕ     // ВНИМАНИЕ

            // ВНИМАНИЕ

            // ВНИМАНИЕ




            ConnectionToDB.closeDB();
            Purchase purchase = new Purchase();
            purchase.Show();
            this.Close();
        }

        private void bTradingToPurchase_Click(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            SQLiteCommand ifCMD = new SQLiteCommand("SELECT id_product FROM product_list_in_purchase WHERE id_purchase = '"+ id_purchase +"'", ConnectionToDB.DB);
            if (ifCMD.ExecuteScalar() == null)
            {
                MessageBox.Show("Лист закупки пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConnectionToDB.closeDB();
            }
            else
            {
                //SQLiteCommand cost = new SQLiteCommand("SELECT price_product_in_purchase, count_product_in_purchase FROM product_list_in_purchase WHERE id_purchase = '" + id_purchase + "'", ConnectionToDB.DB);
                //SQLiteDataReader reader = cost.ExecuteReader();
                //while (reader.Read())
                //{
                //    price_purchase += Convert.ToInt32(reader["count_product_in_purchase"]) * Convert.ToInt32(reader["price_product_in_purchase"]);
                //}



                SQLiteCommand updatePurchase = new SQLiteCommand("UPDATE purchase SET purchase_price = '" + /*price_purchase*/100 + "' WHERE id = '" + id_purchase + "'", ConnectionToDB.DB);
                updatePurchase.ExecuteNonQuery();


                ConnectionToDB.closeDB();
                Purchase purchase = new Purchase();
                purchase.Show();
                this.Close();
            }
        }

        private void ProductListInPurchase_Load(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();


            SQLiteCommand updatePurchase = new SQLiteCommand("SELECT product_list_in_purchase.id_product AS 'Номер', products.name AS 'Название', product_list_in_purchase.price_product_in_purchase AS 'Цена за единицу товара', product_list_in_purchase.count_product_in_purchase AS 'Кол-во товара' FROM " +
                "product_list_in_purchase JOIN products ON product_list_in_purchase.id_product = products.id AND product_list_in_purchase.id_purchase = '" + id_purchase + "'", ConnectionToDB.DB);

            SQLiteDataReader reader = updatePurchase.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;

            ConnectionToDB.closeDB();
        }


        // При нажатии на ячейку выводит инфу
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.ColumnIndex == 1 && e.RowIndex != -1)
            {
                

                //SQLiteCommand updatePurchase = new SQLiteCommand("SELECT product_list_in_purchase.id_product FROM product_list_in_purchase JOIN products ON " +
                //    "product_list_in_purchase.id_product = products.id AND " +
                //    "products.name = '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "' WHERE product_list_in_purchase.id_purchase = '" + id_purchase + "' AND product_list_in_purchase.id_product = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", ConnectionToDB.DB);
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                //ConnectionToDB.closeDB();

                int count = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

                int price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);


                CurrentProduct currentProduct = new CurrentProduct(id, id_purchase, count, price, false);
                if (currentProduct.ShowDialog() == DialogResult.Cancel)
                {
                    ProductListInPurchase_Load(sender, e);
                }
            }
        }


        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.ColumnIndex == 1)
            //{
            //    this.dataGridView1.Cursor = Cursors.Hand;
            //}
            //this.dataGridView1.Cursor = Cursors.Default;
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex > -1)
            {
                this.dataGridView1.Cursor = Cursors.Hand;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.AliceBlue;
            }
            
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex > -1)
            {
                this.dataGridView1.Cursor = Cursors.Default;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
            }
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            //this.dataGridView1.Cursor = Cursors.Default;
        }
    }
}

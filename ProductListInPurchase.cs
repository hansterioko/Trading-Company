using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

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

            SQLiteCommand addProdList = new SQLiteCommand("INSERT INTO product_list_in_purchase (id_product, id_purchase, price_product_in_purchase, count_product_in_purchase)" +
                " VALUES ('" + id_product + "', '" + id_purchase + "', '" + price_product + "', '" + count_product + "')", ConnectionToDB.DB);
            addProdList.ExecuteNonQuery();

            price_purchase += (price_product * count_product);

            ConnectionToDB.closeDB();
        }

        private void bAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(id_purchase);
            addProduct.Show();
            this.Close();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            SQLiteCommand deletePurchase = new SQLiteCommand("DELETE FROM purchase WHERE id = '"+ id_purchase +"'", ConnectionToDB.DB);
            deletePurchase.ExecuteNonQuery();

            ConnectionToDB.closeDB();
            Purchase purchase = new Purchase();
            purchase.Show();
            this.Close();
        }

        private void bTradingToPurchase_Click(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            SQLiteCommand updatePurchase = new SQLiteCommand("UPDATE purchase SET purchase_price = '" + price_purchase + "' WHERE id = '" + id_purchase + "'", ConnectionToDB.DB);
            updatePurchase.ExecuteNonQuery();


            ConnectionToDB.closeDB();
            Purchase purchase = new Purchase();
            purchase.Show();
            this.Close();
        }

        private void ProductListInPurchase_Load(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            SQLiteCommand updatePurchase = new SQLiteCommand("SELECT products.name AS 'Название', product_list_in_purchase.price_product_in_purchase AS 'Цена за единицу товара', product_list_in_purchase.count_product_in_purchase AS 'Кол-во товара' FROM " +
                "product_list_in_purchase JOIN products ON product_list_in_purchase.id_product = products.id AND product_list_in_purchase.id_purchase = '"+ id_purchase +"'", ConnectionToDB.DB);
            
            SQLiteDataReader reader = updatePurchase.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

            ConnectionToDB.closeDB();
        }


        // При нажатии на ячейку выводит инфу
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.ColumnIndex == 0 && dataGridView1.CurrentCell.RowIndex != -1)
            {
                ConnectionToDB.openDB();

                SQLiteCommand updatePurchase = new SQLiteCommand("SELECT product_list_in_purchase.id_product FROM product_list_in_purchase JOIN products ON " +
                    "product_list_in_purchase.id_product = products.id AND " +
                    "products.name = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "' WHERE product_list_in_purchase.id_purchase = '" + id_purchase + "'", ConnectionToDB.DB);
                int id = Convert.ToInt32(updatePurchase.ExecuteScalar());
                ConnectionToDB.closeDB();


                CurrentProduct currentProduct = new CurrentProduct(id);
                currentProduct.ShowDialog();
            }
        }
    }
}

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

namespace Trading_Company
{
    public partial class ProductListInPurchase : Form
    {
        int id_purchase;

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
        public ProductListInPurchase(int price_product, int count_product, int id_product)
        {
            InitializeComponent();

            ConnectionToDB.openDB();

            SQLiteCommand addProdList = new SQLiteCommand("INSERT INTO product_list_in_purchase (id_product, id_purchase, price_product_in_purchase, count_product_in_purchase)" +
                " VALUES ('"+ id_product + "', '" + id_purchase + "', '" + price_product + "', '" + count_product + "')", ConnectionToDB.DB);
            addProdList.ExecuteNonQuery();

            ConnectionToDB.closeDB();
        }

        private void bAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            this.Close();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            SQLiteCommand deletePurchase = new SQLiteCommand("DELETE FROM purchase WHERE id = '"+ id_purchase +"'", ConnectionToDB.DB);
            deletePurchase.ExecuteNonQuery();

            Purchase purchase = new Purchase();
            purchase.Show();
            ConnectionToDB.closeDB();
            this.Close();
        }
    }
}

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
        public CurrentProduct(int id, int id_purchase, int count, int price)
        {
            InitializeComponent();
            this.id = id;
            this.id_purchase = id_purchase;
            this.count = count;
            this.price = price;

            ConnectionToDB.openDB();

            SQLiteCommand param = new SQLiteCommand("SELECT name FROM products WHERE id = '"+ id +"'", ConnectionToDB.DB);
            nameBox.Text = param.ExecuteScalar().ToString();

            param = new SQLiteCommand("SELECT category FROM products WHERE id = '" + id + "'", ConnectionToDB.DB);
            categoryBox.Text = param.ExecuteScalar().ToString();

            countBox.Text = count.ToString();

            priceBox.Text = price.ToString();

            param = new SQLiteCommand("SELECT image FROM products WHERE id = '" + id + "'", ConnectionToDB.DB);

            byte[] image = (byte[])param.ExecuteScalar();
            pictureBox1.Image = byteArrayToImage(image);

            param = new SQLiteCommand("SELECT characteristic FROM products WHERE id = '" + id + "'", ConnectionToDB.DB);
            richSummaryBox.Text = param.ExecuteScalar().ToString();

            ConnectionToDB.closeDB();
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

        private void CurrentProduct_Load(object sender, EventArgs e)
        {

        }

        private void bDeleteProduct_Click(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            SQLiteCommand delProd = new SQLiteCommand("DELETE FROM product_list_in_purchase WHERE id_product = '" + id + "' AND id_purchase = '"+ id_purchase +"' AND price_product_in_purchase = '"+ price +"' AND count_product_in_purchase = '"+ count +"'", ConnectionToDB.DB);
            delProd.ExecuteNonQuery();
            this.Close();

            ConnectionToDB.closeDB();
        }
    }
}

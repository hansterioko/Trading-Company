using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trading_Company
{
    public partial class DetailPurchase : Form
    {
        int id_purchase;
        public DetailPurchase(int id_purchase)
        {
            InitializeComponent();
            this.id_purchase = id_purchase;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();
            this.Close();
        }

        private void DetailPurchase_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.ColumnIndex == 1 && e.RowIndex != -1)
            {
                ConnectionToDB.openDB();

                SQLiteCommand updatePurchase = new SQLiteCommand("SELECT product_list_in_purchase.id_product FROM product_list_in_purchase JOIN products ON " +
                    "product_list_in_purchase.id_product = products.id AND " +
                    "products.name = '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "' WHERE product_list_in_purchase.id_purchase = '" + id_purchase + "' AND product_list_in_purchase.id_product = '"+ dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() +"'", ConnectionToDB.DB);
                int id = Convert.ToInt32(updatePurchase.ExecuteScalar());
                ConnectionToDB.closeDB();

                int count = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

                int price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);

                CurrentProduct currentProduct = new CurrentProduct(id, id_purchase, count, price, true);
                if (currentProduct.ShowDialog() == DialogResult.Cancel)
                {
                   DetailPurchase_Load(sender, e);
                }
            }
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
    }
}

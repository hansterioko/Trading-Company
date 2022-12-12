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
    public partial class DetailShipment : Form
    {
        int id_shipment;
        public DetailShipment(int id_shipment)
        {
            InitializeComponent();
            this.id_shipment = id_shipment;
        }

        private void prodListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (prodListGridView.CurrentCell != null && prodListGridView.CurrentCell.ColumnIndex == 1 && e.RowIndex != -1)
            {

                int id_product = Convert.ToInt32(prodListGridView.Rows[e.RowIndex].Cells[0].Value);

                CurrentProdOnWarehouse currentProdOnWarehouse = new CurrentProdOnWarehouse(id_product);
                currentProdOnWarehouse.ShowDialog();
            }
        }

        private void DetailShipment_Load(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            SQLiteCommand updatePurchase = new SQLiteCommand("SELECT product_list_in_shipment.id_product AS 'Номер', products.name AS 'Название', product_list_in_shipment.price_product_in_shipment AS 'Цена за единицу товара', product_list_in_shipment.count_product_in_shipment AS 'Кол-во товара в поставке' FROM " +
                "product_list_in_shipment JOIN products ON product_list_in_shipment.id_product = products.id AND product_list_in_shipment.id_shipment = '" + id_shipment + "'", ConnectionToDB.DB);

            SQLiteDataReader reader = updatePurchase.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            prodListGridView.DataSource = dt;
            prodListGridView.Columns[0].Visible = false;
            ConnectionToDB.closeDB();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Shipment shipment = new Shipment();
            shipment.Show();
            this.Close();
        }

        private void prodListGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 1)
            {
                this.prodListGridView.Cursor = Cursors.Hand;
                prodListGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
        }

        private void prodListGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 1)
            {
                this.prodListGridView.Cursor = Cursors.Default;
                prodListGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}

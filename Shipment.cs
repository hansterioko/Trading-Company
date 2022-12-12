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
    public partial class Shipment : Form
    {
        public Shipment()
        {
            InitializeComponent();
        }



        private void bExitToMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void bAddShipment_Click(object sender, EventArgs e)
        {
            SelectShop selectShop = new SelectShop();
            selectShop.Show();
            this.Close();
        }

        private void bShipmentReport_Click(object sender, EventArgs e)
        {
            SelectDateReportShipment selectDateReportShipment = new SelectDateReportShipment();
            selectDateReportShipment.Show();
            this.Close();
        }

        private void Shipment_Load(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            SQLiteCommand selectShipment = new SQLiteCommand("SELECT shipment.id AS 'Номер поставки', shops.name AS 'Название магазина', shipment.shipment_price AS 'Цена поставки', shipment.shipment_date AS 'Дата поставки', shipment.discount AS 'Скидка' FROM " +
                "shipment LEFT JOIN shops ON shipment.id_shop = shops.id", ConnectionToDB.DB);

            SQLiteDataReader reader = selectShipment.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            shipmentGridView.DataSource = dt;
            shipmentGridView.Columns[1].Width = 150;
            

            ConnectionToDB.closeDB();
        }

        private void shipmentGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (shipmentGridView.CurrentCell != null && e.RowIndex != -1)
            {
                DetailShipment detailShipment = new DetailShipment(Convert.ToInt32(shipmentGridView.Rows[e.RowIndex].Cells[0].Value));
                detailShipment.Show();
                this.Close();
            }
        }

        private void shipmentGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.shipmentGridView.Cursor = Cursors.Hand;
                shipmentGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
        }

        private void shipmentGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.shipmentGridView.Cursor = Cursors.Default;
                shipmentGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}

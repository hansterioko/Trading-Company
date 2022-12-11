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
    }
}

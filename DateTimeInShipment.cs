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
    public partial class DateTimeInShipment : Form
    {
        int id_shop;
        public DateTimeInShipment(int id_shop)
        {
            InitializeComponent();
            this.id_shop = id_shop;
        }

        private void DateTimeInShipment_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();
            dateTime = dateTimePicker1.Value.Date + dateTimePicker2.Value.TimeOfDay;

            ConnectionToDB.openDB();

           
            SQLiteCommand command = new SQLiteCommand("INSERT INTO shipment (id_shop, shipment_price, shipment_date) VALUES ('" + id_shop + "', 0, @dateTime)", ConnectionToDB.DB);
            command.Parameters.AddWithValue("@dateTime", dateTime);
            command.ExecuteNonQuery();

            command = new SQLiteCommand("SELECT MAX(id) FROM shipment", ConnectionToDB.DB);

            int id_shipment = Convert.ToInt32(command.ExecuteScalar());
            ConnectionToDB.closeDB();

            ProductListInShipment productListInShipment = new ProductListInShipment(id_shipment);
            productListInShipment.Show();
            this.Close();

        }
    }
}

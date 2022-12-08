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
    public partial class Report : Form
    {
        DateTime fromDate, byDate;
        public Report(DateTime fromDate, DateTime byDate)
        {
            InitializeComponent();
            this.fromDate = fromDate;
            this.byDate = byDate;

            label1.Text = "Закупки с " + fromDate.ToString() + " по " + byDate.ToString();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();


            SQLiteCommand updatePurchase = new SQLiteCommand("SELECT product_list_in_purchase.id_product AS 'Номер', products.name AS 'Название', product_list_in_purchase.price_product_in_purchase AS 'Цена за единицу товара', product_list_in_purchase.count_product_in_purchase AS 'Кол-во товара' FROM " +
                "product_list_in_purchase JOIN products ON product_list_in_purchase.id_product = products.id AND product_list_in_purchase.id_purchase = '" + id_purchase + "'", ConnectionToDB.DB);

            SQLiteDataReader reader = updatePurchase.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            

            ConnectionToDB.closeDB();
        }
    }
}

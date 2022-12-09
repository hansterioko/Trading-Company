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

            
        }

        private void Report_Load(object sender, EventArgs e)
        {
            label1.Text = "Закупки с " + fromDate.ToString() + " по " + byDate.ToString();

            ConnectionToDB.openDB();

            
            SQLiteCommand countPurchase = new SQLiteCommand("SELECT id, id_company, purchase_date, purchase_price FROM purchase WHERE purchase_date >= @fromDate AND purchase_date <= @byDate", ConnectionToDB.DB);
            countPurchase.Parameters.Add("@fromDate", DbType.DateTime).Value = fromDate;
            countPurchase.Parameters.Add("@byDate", DbType.DateTime).Value = byDate;

            SQLiteDataReader reader = countPurchase.ExecuteReader();
            while (reader.Read())
            {
                SQLiteCommand nameCompany = new SQLiteCommand("SELECT name FROM company WHERE id = '"+ reader["id_company"] +"'", ConnectionToDB.DB);
                richReport.Text += "Закупка под номером " + reader["id"].ToString() + " от компании \"" + nameCompany.ExecuteScalar().ToString() + "\"\n";
                richReport.Text += "Дата закупки: " + reader["purchase_date"] + "           Сумма закупки: " + reader["purchase_price"] + "\n";

                SQLiteCommand products = new SQLiteCommand("SELECT products.characteristic, products.name, product_list_in_purchase.price_product_in_purchase, product_list_in_purchase.count_product_in_purchase FROM " +
                "product_list_in_purchase JOIN products ON product_list_in_purchase.id_product = products.id AND product_list_in_purchase.id_purchase = '" + reader["id"] + "'", ConnectionToDB.DB);
                SQLiteDataReader readerProd = products.ExecuteReader();

                richReport.Text += "Продукты в закупке:\n";
                if (readerProd == null)
                {
                    richReport.Text += "    Продуктов нет\n";
                }
                while (readerProd.Read())
                {
                    richReport.Text += "Наименование: " + readerProd["name"].ToString() + "      Описание: " + readerProd["characteristic"].ToString() + "     Кол-во: " + readerProd["count_product_in_purchase"].ToString() + "     По цене: " + readerProd["price_product_in_purchase"].ToString() + "\n";
                }
                richReport.Text += "\n\n";
            }


            ConnectionToDB.closeDB();
        }
    }
}

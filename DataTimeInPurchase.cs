using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Trading_Company
{
    public partial class DataTimeInPurchase : Form
    {
        int id_company;
        public DataTimeInPurchase(int id_company)
        {
            InitializeComponent();
            this.id_company = id_company;
        }

        private void DataTimeInPurchase_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();
            dateTime = dateTimePicker1.Value.Date + dateTimePicker2.Value.TimeOfDay;

            ConnectionToDB.openDB();

            // Добавление закупки в таблицу, но со значением 0 для цены     Далее обновим значения
            SQLiteCommand command = new SQLiteCommand("INSERT INTO purchase (id_company, purchase_price, purchase_date) VALUES ('"+ id_company + "', 0, @dateTime)", ConnectionToDB.DB);
            command.Parameters.AddWithValue("@dateTime", dateTime);
            command.ExecuteNonQuery();

            command = new SQLiteCommand("SELECT MAX(id) FROM purchase", ConnectionToDB.DB);

            int id_purchase = Convert.ToInt32(command.ExecuteScalar());
            ConnectionToDB.closeDB();

            ProductListInPurchase productListInPurchase = new ProductListInPurchase(id_purchase);
            productListInPurchase.Show();
            this.Close();

        }
    }
}

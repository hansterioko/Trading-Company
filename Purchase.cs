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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        private void bExitToMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            SQLiteCommand selectPurchase = new SQLiteCommand("SELECT purchase.id AS 'Номер закупки', company.name AS 'Название компании', purchase.purchase_price AS 'Цена закупки', purchase.purchase_date AS 'Дата закупки' FROM " +
                "purchase LEFT JOIN company ON purchase.id_company = company.id", ConnectionToDB.DB);

            SQLiteDataReader reader = selectPurchase.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            purchaseGridView.DataSource = dt;
            purchaseGridView.Columns[1].Width = 150;

            ConnectionToDB.closeDB();
        }

        private void bAdding_Click(object sender, EventArgs e)
        {
            SelectCompany selectCompany = new SelectCompany();
            selectCompany.Show();
            //ProductListInPurchase productListInPurchase = new ProductListInPurchase();
            //productListInPurchase.Show();
            this.Close();
        }

        private void purchaseGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (purchaseGridView.CurrentCell != null && e.RowIndex != -1)
            {
                DetailPurchase detailPurchase = new DetailPurchase(Convert.ToInt32(purchaseGridView.Rows[e.RowIndex].Cells[0].Value));
                detailPurchase.Show();
                this.Close();
            }
        }

        private void bReport_Click(object sender, EventArgs e)
        {
            SelectDateReport selectDateReport = new SelectDateReport();
            selectDateReport.Show();
            this.Close();
        }

        private void purchaseGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.purchaseGridView.Cursor = Cursors.Hand;
                purchaseGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
        }

        private void purchaseGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.purchaseGridView.Cursor = Cursors.Default;
                purchaseGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}

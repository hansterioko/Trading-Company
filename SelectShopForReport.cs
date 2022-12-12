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
    public partial class SelectShopForReport : Form
    {
        public List<int> listShop = new List<int>();
        public SelectShopForReport()
        {
            InitializeComponent();
        }

        private void SelectShopForReport_Load(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            SQLiteCommand getCompany = new SQLiteCommand("SELECT * FROM shops", ConnectionToDB.DB);
            SQLiteDataReader reader = getCompany.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            shopGridView.DataSource = dt;
            shopGridView.Columns[1].Visible = false;
            shopGridView.Columns[2].Width = 150;
            setReadOnly();

            ConnectionToDB.closeDB();
        }

        private void setReadOnly()
        {
            for (int i = 1; i < shopGridView.ColumnCount; i++)
            {
                shopGridView.Columns[i].ReadOnly = true;
            }
            shopGridView.Columns[0].ReadOnly = false;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < shopGridView.Rows.Count; i++)
            {
                if (shopGridView.Rows[i].Cells[0].Value != null && shopGridView.Rows[i].Cells[0].Value.ToString().Equals("True"))
                {
                    listShop.Add(Convert.ToInt32(shopGridView.Rows[i].Cells[1].Value));
                }
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class SelectCompanyForReport : Form
    {
        public List<int> listCompany = new List<int>();
        public SelectCompanyForReport()
        {
            InitializeComponent();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < companyGridView.Rows.Count; i++)
            {
                if (companyGridView.Rows[i].Cells[0].Value != null && companyGridView.Rows[i].Cells[0].Value.ToString().Equals("True"))
                {
                    listCompany.Add(Convert.ToInt32(companyGridView.Rows[i].Cells[1].Value));
                }
            }
            
        }

        private void SelectCompanyForReport_Load(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            SQLiteCommand getCompany = new SQLiteCommand("SELECT * FROM company", ConnectionToDB.DB);
            SQLiteDataReader reader = getCompany.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            companyGridView.DataSource = dt;
            companyGridView.Columns[1].Visible = false;
            companyGridView.Columns[2].Width = 150;
            setReadOnly();

            ConnectionToDB.closeDB();
        }

        private void setReadOnly()
        {
            for (int i = 1; i < companyGridView.ColumnCount; i++)
            {
                companyGridView.Columns[i].ReadOnly = true;
            }
            companyGridView.Columns[0].ReadOnly = false;
        }
    }
}

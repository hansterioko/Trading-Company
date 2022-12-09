using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trading_Company
{
    public partial class SelectDateReport : Form
    {
        public SelectDateReport()
        {
            InitializeComponent();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            DateTime fromDateTime = fromDateTime = fromDate.Value.Date + fromTimePicker.Value.TimeOfDay;


            DateTime byDateTime = byDateTime = byDate.Value.Date + byTimePicker.Value.TimeOfDay;




            Report report = new Report(fromDateTime, byDateTime);
            report.ShowDialog();
            //this.Close();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();
            this.Close();
        }
    }
}

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

            DateTime fromDateTime = fromDate.Value.Date + fromTimePicker.Value.TimeOfDay;


            DateTime byDateTime =  byDate.Value.Date + byTimePicker.Value.TimeOfDay;

            if (fromDateTime >= byDateTime)
            {
                MessageBox.Show("Сделайте значение начального периода меньшим, чем значение конечного периода", "Некоректный период", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Report report = new Report(fromDateTime, byDateTime, false);
                report.ShowDialog();
            }
            
            //this.Close();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();
            this.Close();
        }

        private void SelectDateReport_Load(object sender, EventArgs e)
        {
            fromTimePicker.Value = DateTime.Now;
            byTimePicker.Value = DateTime.Now;
        }

        private void byTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void byDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fromDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fromTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class SelectDateReportShipment : Form
    {
        public SelectDateReportShipment()
        {
            InitializeComponent();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            DateTime fromDateTime = fromDate.Value.Date + fromTimePicker.Value.TimeOfDay;


            DateTime byDateTime = byDate.Value.Date + byTimePicker.Value.TimeOfDay;


            if (fromDateTime >= byDateTime)
            {
                MessageBox.Show("Сделайте значение начального периода меньшим, чем значение конечного периода", "Некоректный период", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Report report = new Report(fromDateTime, byDateTime, true);
                report.ShowDialog();
            }
        }

        private void SelectDateReportShipment_Load(object sender, EventArgs e)
        {
            byTimePicker.Value = DateTime.Now;
            fromTimePicker.Value = DateTime.Now;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Shipment shipment = new Shipment();
            shipment.Show();
            this.Close();
        }
    }
}

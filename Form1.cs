using System;
using System.Windows.Forms;

namespace Trading_Company
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bPurchase_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            
            purchase.Show();
            this.Hide();
        }

        private void bWarehouse_Click(object sender, EventArgs e)
        {
            Warehouse warehouse = new Warehouse();

            warehouse.Show();
            this.Hide();
        }

        private void bShipment_Click(object sender, EventArgs e)
        {
            Shipment shipment = new Shipment();

            shipment.Show();
            this.Hide();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill(); // Закрытие меню полностью
        }
    }
}

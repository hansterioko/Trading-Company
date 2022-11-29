using System;
using System.Drawing;
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

        private void bPurchase_MouseEnter(object sender, EventArgs e)
        {
            bPurchase.ForeColor = Color.BlueViolet;
        }

        private void bPurchase_MouseLeave(object sender, EventArgs e)
        {
            bPurchase.ForeColor = Color.Black;
        }

        private void bWarehouse_MouseEnter(object sender, EventArgs e)
        {
            bWarehouse.ForeColor = Color.BlueViolet;
        }

        private void bWarehouse_MouseLeave(object sender, EventArgs e)
        {
            bWarehouse.ForeColor = Color.Black;
        }

        private void bShipment_MouseEnter(object sender, EventArgs e)
        {
            bShipment.ForeColor = Color.BlueViolet;
        }

        private void bShipment_MouseLeave(object sender, EventArgs e)
        {
            bShipment.ForeColor = Color.Black;
        }
    }
}

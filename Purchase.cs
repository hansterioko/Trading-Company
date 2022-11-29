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

        }

        private void bAdding_Click(object sender, EventArgs e)
        {

        }
    }
}

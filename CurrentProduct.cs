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
    public partial class CurrentProduct : Form
    {
        public CurrentProduct(int id)
        {
            InitializeComponent();
            textBox1.Text = id.ToString();
        }

        private void CurrentProduct_Load(object sender, EventArgs e)
        {

        }
    }
}

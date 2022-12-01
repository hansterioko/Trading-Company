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
    public partial class ProductListInPurchase : Form
    {
        int id_company;
        public ProductListInPurchase()
        {
            InitializeComponent();
        }

        public ProductListInPurchase(int id_company)
        {
            InitializeComponent();
            this.id_company = id_company;
        }

        private void bAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            this.Close();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trading_Company
{
    public partial class CurrentProdOnWarehouse : Form
    {
        int id_product;
        public CurrentProdOnWarehouse(int id_product)
        {
            InitializeComponent();
            this.id_product = id_product;
        }

        public Image byteArrayToImage(byte[] byteArrayIn)       // Из байтов в изображение
        {
            if (byteArrayIn != null)
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                Image returnImage = Image.FromStream(ms, true);
                return returnImage;
            }
            return null;
        }

        private void CurrentProdOnWarehouse_Load(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();


            SQLiteCommand command = new SQLiteCommand("SELECT products.name, products.characteristic, warehouse.count_product, warehouse.sector_on_warehouse, products.vat, products.unit_of_measurement, products.category, products.image  FROM products JOIN warehouse ON products.id = warehouse.id_product WHERE products.id = '" + id_product +"'", ConnectionToDB.DB);
            SQLiteDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                nameBox.Text = reader["name"].ToString();
                categoryBox.Text = reader["category"].ToString();
                vatBox.Text = reader["vat"].ToString();
                unitMeasurementBox.Text = reader["unit_of_measurement"].ToString();
                richSummaryBox.Text = reader["characteristic"].ToString();

                countBox.Text = reader["count_product"].ToString();
                sectorBox.Text = reader["sector_on_warehouse"].ToString();

                byte[] image = (byte[])reader["image"];
                photoBox.Image = byteArrayToImage(image);
            }
            


            ConnectionToDB.closeDB();
        }
    }
}

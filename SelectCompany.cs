using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Trading_Company
{
    public partial class SelectCompany : Form
    {
        public SelectCompany()
        {
            InitializeComponent();
        }

        private void comboCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            SQLiteCommand command = new SQLiteCommand("SELECT id FROM company WHERE name = '" + comboCompany.SelectedItem.ToString() + "'", ConnectionToDB.DB);

            ProductListInPurchase productListInPurchase = new ProductListInPurchase(Convert.ToInt32(command.ExecuteScalar().ToString()));
            productListInPurchase.Show();
            this.Close();

            ConnectionToDB.closeDB();
        }

        private void SelectCompany_Load(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            SQLiteCommand command = new SQLiteCommand("SELECT name FROM company", ConnectionToDB.DB);
            SQLiteDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                comboCompany.Items.Add(read["name"].ToString());
            }

            ConnectionToDB.closeDB();        
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();
            this.Close();
        }

        private void bAddCompany_Click(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            // Поиск компании с именем таким-то
            SQLiteCommand ifCMD = new SQLiteCommand("SELECT id FROM company WHERE name = '"+ nameBox.Text +"'", ConnectionToDB.DB);

            // Если компания с таким-то именем найдена, то true
            if (ifCMD.ExecuteScalar() == null)
            {
                if (nameBox.Text != "" && telNumbBox.Text != "" && cityBox.Text != "" && streetBox.Text != "" && houseBox.Text != "")
                {
                    // Добавление компании
                    SQLiteCommand command = new SQLiteCommand("INSERT INTO company (name, telnumb, city, street, house) VALUES ('" + nameBox.Text + "', '" + telNumbBox.Text + "', '" + cityBox.Text + "', '" + streetBox.Text + "', '" + houseBox.Text + "')", ConnectionToDB.DB);
                    command.ExecuteNonQuery(); 

                    // Поиск id компании и передача в форму листа закупок
                    ProductListInPurchase productListInPurchase = new ProductListInPurchase(Convert.ToInt32(ifCMD.ExecuteScalar().ToString()));
                    productListInPurchase.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                if (MessageBox.Show("Компания с таким названием уже существует!\nХотите выбрать её?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    // Переход на форму листа закупок с передачей id компании
                    ProductListInPurchase productListInPurchase = new ProductListInPurchase(Convert.ToInt32(ifCMD.ExecuteScalar().ToString()));
                    productListInPurchase.Show();
                    this.Close();
                }
            }
            
            
            

            ConnectionToDB.closeDB();
        }
    }
}

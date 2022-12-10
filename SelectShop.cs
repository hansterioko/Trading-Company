using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trading_Company
{
    public partial class SelectShop : Form
    {
        public SelectShop()
        {
            InitializeComponent();
        }

        private void bAddShop_Click(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            SQLiteCommand ifCMD = new SQLiteCommand("SELECT id FROM shops WHERE name = '" + nameBox.Text + "'", ConnectionToDB.DB);
            if (ifCMD.ExecuteScalar() == null)
            {
                if (nameBox.Text != "" && cityBox.Text != "" && streetBox.Text != "" && houseBox.Text != "")
                {
                    // Добавление магазина
                    SQLiteCommand command = new SQLiteCommand("INSERT INTO shops (name, telnumb, city, street, house) VALUES ('" + nameBox.Text + "', '" + telNumbBox.Text + "', '" + cityBox.Text + "', '" + streetBox.Text + "', '" + houseBox.Text + "')", ConnectionToDB.DB);
                    command.ExecuteNonQuery();


                    DateTimeInShipment dateTimeInShipment = new DateTimeInShipment(Convert.ToInt32(command.ExecuteScalar().ToString()));
                    dateTimeInShipment.Show();
                    ConnectionToDB.closeDB();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                if (MessageBox.Show("Магазин с таким названием уже существует!\nХотите выбрать его?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    // Переход на форму листа закупок с передачей id компании
                    DateTimeInShipment dateTimeInShipment = new DateTimeInShipment(Convert.ToInt32(ifCMD.ExecuteScalar().ToString()));
                    dateTimeInShipment.Show();
                    ConnectionToDB.closeDB();
                    this.Close();
                }
            }

            ConnectionToDB.closeDB();
        }

        private void SelectShop_Load(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            SQLiteCommand command = new SQLiteCommand("SELECT name FROM shops", ConnectionToDB.DB);
            SQLiteDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                comboShop.Items.Add(read["name"].ToString());
            }

            ConnectionToDB.closeDB();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Shipment shipment = new Shipment();
            shipment.Show();

            this.Close();
        }

        private void comboShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            SQLiteCommand command = new SQLiteCommand("SELECT id FROM shops WHERE name = '" + comboShop.SelectedItem.ToString() + "'", ConnectionToDB.DB);

            DateTimeInShipment dateTimeInShipment = new DateTimeInShipment(Convert.ToInt32(command.ExecuteScalar().ToString()));
            dateTimeInShipment.Show();

            ConnectionToDB.closeDB();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trading_Company
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        byte[] photo;

        private void vatBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Получаем символ, который ввёл пользователь
            char number = e.KeyChar;

            // Если пользователь ввёл не цифру,запятую и не нажал на Backspace, то не отображаем символ в textbox
            if (!Char.IsDigit(number) && number != 44 && number != 8)
                e.Handled = true;
        }

        private void bAddPhoto_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

            }


           photo = GetPhoto(filePath);
        }

        public static byte[] GetPhoto(string filePath)      // Из изображения в байты
        {
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);

            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }

        private void bAddProductInList_Click(object sender, EventArgs e)
        {
            if (nameBox1.Text != "" && categoryBox2.Text != "" && unitBox3.Text != "" && vatBox4.Text != "" && countBox1.Text != "")
            {
                
            }
        }

        private void countBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            // Если пользователь ввёл не цифру,запятую и не нажал на Backspace, то не отображаем символ в textbox
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }
    }
}

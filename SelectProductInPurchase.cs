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
    public partial class SelectProductInPurchase : Form
    {
        int id_purchase;
        public SelectProductInPurchase(int id_purchase)
        {
            InitializeComponent();
            this.id_purchase = id_purchase;
        }

        private void SelectProductInPurchase_Load(object sender, EventArgs e)
        {
            try
            {
                ConnectionToDB.openDB();

                SQLiteCommand command = new SQLiteCommand("SELECT id, name AS 'Наименование', category AS 'Категория', characteristic AS 'Описание' FROM products WHERE id_company = (SELECT id_company FROM purchase WHERE id = '" + id_purchase + "')", ConnectionToDB.DB);
                SQLiteDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                productsGridView.DataSource = dt;
                productsGridView.Columns[1].Visible = false;
                productsGridView.Columns[4].Width = 200;
                productsGridView.Columns.Add("cost", "Цена закупки");
                productsGridView.Columns.Add("cost", "Колличество");

                productsGridView.Columns[5].DefaultCellStyle.BackColor = Color.DimGray;
                productsGridView.Columns[6].DefaultCellStyle.BackColor = Color.DimGray;

                setReadOnly();

                ConnectionToDB.closeDB();
            }
            catch
            {
                MessageBox.Show("Ошибка добавления данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setReadOnly()
        {
            for (int i = 1; i < productsGridView.Columns.Count; i++)
            {
                productsGridView.Columns[i].ReadOnly = true;
            }
        }

        private void productsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 0)
            {
                DataGridViewCheckBoxCell sel = (DataGridViewCheckBoxCell)productsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (sel.Value == null)
                    sel.Value = false;

                switch (sel.Value.ToString())
                {
                    case "True":
                        sel.Value = false;
                        break;
                    case "False":
                        sel.Value = true;
                        MessageBox.Show("Введите цену и количество товара в закупке", "Товар выбран", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }

                if (sel.Value.ToString().Equals("True"))
                {
                    productsGridView.Rows[e.RowIndex].Cells[5].ReadOnly = false;
                    productsGridView.Rows[e.RowIndex].Cells[6].ReadOnly = false;

                    productsGridView.Rows[e.RowIndex].Cells[5].Style.BackColor = Color.AntiqueWhite;
                    productsGridView.Rows[e.RowIndex].Cells[6].Style.BackColor = Color.AntiqueWhite;
                }
                else
                {
                    productsGridView.Rows[e.RowIndex].Cells[5].ReadOnly = true;
                    productsGridView.Rows[e.RowIndex].Cells[6].ReadOnly = true;

                    productsGridView.Rows[e.RowIndex].Cells[5].Style.BackColor = Color.DimGray;
                    productsGridView.Rows[e.RowIndex].Cells[6].Style.BackColor = Color.DimGray;
                }
            }


        }

        private void productsGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex > -1)
            {
                this.productsGridView.Cursor = Cursors.Hand;
                productsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.AliceBlue;
            }
        }

        private void productsGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex > -1)
            {
                this.productsGridView.Cursor = Cursors.Default;
                productsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
            }
        }

        private void bAdding_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean isNull = false;
                String namerOfRow = "";

                List<Product> products = new List<Product>();


                for (int i = 0; i < productsGridView.Rows.Count; i++)
                {
                    if (productsGridView.Rows[i].Cells[0].Value != null && productsGridView.Rows[i].Cells[0].Value.ToString().Equals("True"))
                    {
                        if (productsGridView.Rows[i].Cells[5].Value == null || productsGridView.Rows[i].Cells[6].Value == null)
                        {
                            isNull = true;
                            namerOfRow += " " + productsGridView.Rows[i].Cells[2].Value.ToString() + ",";
                        }
                        else
                        {
                            Product product = new Product(Convert.ToInt32(productsGridView.Rows[i].Cells[5].Value), Convert.ToInt32(productsGridView.Rows[i].Cells[6].Value), Convert.ToInt32(productsGridView.Rows[i].Cells[1].Value), id_purchase); // параметры товара
                            products.Add(product);
                        }
                    }
                }
                if (!isNull)
                {
                    for (int i = 0; i < productsGridView.Rows.Count; i++)
                    {
                        if (productsGridView.Rows[i].Cells[0].Value != null && productsGridView.Rows[i].Cells[0].Value.ToString().Equals("True"))
                        {
                            ConnectionToDB.openDB();

                            SQLiteCommand updWarehouse = new SQLiteCommand("UPDATE warehouse SET count_product = count_product + '" + Convert.ToInt32(productsGridView.Rows[i].Cells[6].Value) + "' WHERE id_product = '" + Convert.ToInt32(productsGridView.Rows[i].Cells[1].Value) + "'", ConnectionToDB.DB);
                            updWarehouse.ExecuteNonQuery();

                            ConnectionToDB.closeDB();
                        }
                    }

                    ProductListInPurchase productListInPurchase = new ProductListInPurchase(products);
                    productListInPurchase.Show();
                    this.Close();
                }
                else
                {

                    MessageBox.Show("Заполните поля цены и количества у товаров:" + namerOfRow.TrimEnd(','), "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка добавления данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productsGridView.CurrentCell != null && productsGridView.CurrentCell.ColumnIndex == 2 && e.RowIndex != -1)
            {

                int id_product = Convert.ToInt32(productsGridView.Rows[e.RowIndex].Cells[1].Value);

                CurrentProdOnWarehouse currentProdOnWarehouse = new CurrentProdOnWarehouse(id_product);
                currentProdOnWarehouse.ShowDialog();
            }
        }

        private void productsGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void productsGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataGridViewTextBoxEditingControl currentEditingControl;
        private void productsGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (currentEditingControl == null && e.Control is DataGridViewTextBoxEditingControl tb)
            {
                currentEditingControl = tb;
                currentEditingControl.KeyPress += EditingControl_KeyPress;
            }
        }

        private void EditingControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is DataGridViewTextBoxEditingControl tb)
            {
                char number = e.KeyChar;

                // Если пользователь ввёл не цифру,запятую и не нажал на Backspace, то не отображаем символ в textbox
                // 8 это Backspace
                if (!Char.IsDigit(number) && number != 8)
                    e.Handled = true;
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(id_purchase);
            addProduct.Show();
            this.Close();
        }
    }



    public class Product
    {
        private int price_product, count_product, id_product, id_purchase;

        public int Price_product { get => price_product; }
        public int Count_products { get => count_product; }
        public int Id_product { get => id_product; }
        public int Id_purchase { get => id_purchase; }

        public Product(int price_product, int count_product, int id_product, int id_purchase)
        {
            this.count_product = count_product;
            this.price_product = price_product;
            this.id_product = id_product;
            this.id_purchase = id_purchase;
        }


    }
}

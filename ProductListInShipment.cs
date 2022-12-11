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
    public partial class ProductListInShipment : Form
    {
        int id_shipment;
        public ProductListInShipment(int id_shipment)
        {
            InitializeComponent();
            this.id_shipment = id_shipment;
        }

        private void shipListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (shipListGridView.CurrentCell != null && shipListGridView.CurrentCell.ColumnIndex == 1 && e.RowIndex != -1)
            {

                int id_product = Convert.ToInt32(shipListGridView.Rows[e.RowIndex].Cells[5].Value);

                CurrentProdOnWarehouse currentProdOnWarehouse = new CurrentProdOnWarehouse(id_product);
                currentProdOnWarehouse.ShowDialog();
            }
        }

        private void ProductListInShipment_Load(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();


            SQLiteCommand command = new SQLiteCommand("SELECT products.name AS 'Наименование', products.characteristic AS 'Описание товара', warehouse.count_product AS 'Количество на складе', warehouse.sector_on_warehouse AS 'Сектор', products.id FROM products JOIN warehouse ON products.id = warehouse.id_product", ConnectionToDB.DB);
            SQLiteDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            shipListGridView.DataSource = dt;
            shipListGridView.Columns[5].Visible = false;

            shipListGridView.Columns.Add("cost", "Цена продажи");
            shipListGridView.Columns.Add("count", "кол-во для продажи");
            shipListGridView.Columns[6].DefaultCellStyle.BackColor = Color.DimGray;
            shipListGridView.Columns[7].DefaultCellStyle.BackColor = Color.DimGray;

            setReadOnly();


            ConnectionToDB.closeDB();
        }

        private void shipListGridView_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            
        }

        private void setReadOnly()
        {
            for (int i = 1; i < shipListGridView.Columns.Count; i++)
            {
                shipListGridView.Columns[i].ReadOnly = true;
            }
        }

        private void shipListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 0)
            {
                DataGridViewCheckBoxCell sel = new DataGridViewCheckBoxCell();
                sel = (DataGridViewCheckBoxCell)shipListGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (sel.Value == null)
                    sel.Value = false;

                switch (sel.Value.ToString())
                {
                    case "True":
                        sel.Value = false;
                        break;
                    case "False":
                        sel.Value = true;
                        MessageBox.Show("Введите цену и количество товара в поставке", "Товар выбран", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
               
                if (sel.Value.ToString().Equals("True"))
                {
                    shipListGridView.Rows[e.RowIndex].Cells[6].ReadOnly = false;
                    shipListGridView.Rows[e.RowIndex].Cells[7].ReadOnly = false;

                    shipListGridView.Rows[e.RowIndex].Cells[6].Style.BackColor = Color.AntiqueWhite;
                    shipListGridView.Rows[e.RowIndex].Cells[7].Style.BackColor = Color.AntiqueWhite;
                }
                else
                {
                    shipListGridView.Rows[e.RowIndex].Cells[6].ReadOnly = true;
                    shipListGridView.Rows[e.RowIndex].Cells[7].ReadOnly = true;

                    shipListGridView.Rows[e.RowIndex].Cells[6].Style.BackColor = Color.DimGray;
                    shipListGridView.Rows[e.RowIndex].Cells[7].Style.BackColor = Color.DimGray;
                }
            }
        }

        private void discountBar_Scroll(object sender, EventArgs e)
        {
            discountBox.Text = discountBar.Value.ToString();
        }

        private void bUpdShipment_Click(object sender, EventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < shipListGridView.Rows.Count; i++)
            {
                if (Convert.ToInt32(shipListGridView.Rows[i].Cells[3].Value) < Convert.ToInt32(shipListGridView.Rows[i].Cells[7].Value))
                {
                    MessageBox.Show("Количество товара на складе меньше, чем в поставке!\nУкажите меньшее количество у товара \"" + shipListGridView.Rows[i].Cells[1].Value.ToString() + "\"");
                    flag = false;
                }
            }

            if (flag)
            {
                ConnectionToDB.openDB();

                for (int i = 0; i < shipListGridView.Rows.Count; i++)
                {
                    if (shipListGridView.Rows[i].Cells[0].Value != null && shipListGridView.Rows[i].Cells[0].Value.ToString().Equals("True"))
                    {
                        SQLiteCommand addToList = new SQLiteCommand("INSERT INTO product_list_in_shipment (id_product, id_shipment, price_product_in_shipment, count_product_in_shipment) VALUES ('" + shipListGridView.Rows[i].Cells[5].Value.ToString() + "', '" + id_shipment + "', '" + shipListGridView.Rows[i].Cells[6].Value.ToString() + "', '" + shipListGridView.Rows[i].Cells[7].Value.ToString() + "')", ConnectionToDB.DB);
                        addToList.ExecuteNonQuery();

                        SQLiteCommand ifCMD = new SQLiteCommand("SELECT count_product FROM warehouse WHERE id_product = '"+ shipListGridView.Rows[i].Cells[5].Value.ToString() + "'", ConnectionToDB.DB);
                        if (Convert.ToInt32(ifCMD.ExecuteScalar()) == Convert.ToInt32(shipListGridView.Rows[i].Cells[7].Value))
                        {
                            SQLiteCommand deleteProd = new SQLiteCommand("DELETE FROM products WHERE id = '"+ shipListGridView.Rows[i].Cells[5].Value.ToString() + "'", ConnectionToDB.DB);
                            deleteProd.ExecuteNonQuery();
                            deleteProd = new SQLiteCommand("DELETE FROM warehouse WHERE id_product = '" + shipListGridView.Rows[i].Cells[5].Value.ToString() + "'", ConnectionToDB.DB);
                            deleteProd.ExecuteNonQuery();
                        }
                        else
                        {
                            SQLiteCommand changeWarehouse = new SQLiteCommand("UPDATE warehouse SET count_product = count_product - '"+ shipListGridView.Rows[i].Cells[7].Value.ToString() + "' WHERE id_product = '" + shipListGridView.Rows[i].Cells[5].Value.ToString() + "'", ConnectionToDB.DB);
                            changeWarehouse.ExecuteNonQuery();
                        }
                        SQLiteCommand addDiscount = new SQLiteCommand("UPDATE shipment SET discount = '"+ discountBox.Text +"' WHERE id = (SELECT MAX(id) FROM shipment)", ConnectionToDB.DB);
                        addDiscount.ExecuteNonQuery();
                    }
                }

                ConnectionToDB.closeDB();
                Shipment shipment = new Shipment();
                shipment.Show();
                this.Close();
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            SQLiteCommand command = new SQLiteCommand("DELETE FROM shipment WHERE id = (SELECT MAX(id) FROM shipment)", ConnectionToDB.DB);
            command.ExecuteNonQuery();

            ConnectionToDB.closeDB();

            Shipment shipment = new Shipment();
            shipment.Show();
            this.Close();
        }

        private void shipListGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex > -1)
            {
                this.shipListGridView.Cursor = Cursors.Hand;
                shipListGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.AliceBlue;
            }
        }

        private void shipListGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex > -1)
            {
                this.shipListGridView.Cursor = Cursors.Default;
                shipListGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
            }
        }
    }
}

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
    public partial class Warehouse : Form
    {
        int id_product;
        public Warehouse()
        {
            InitializeComponent();
        }

        private void bExitToMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            ConnectionToDB.openDB();

            
            SQLiteCommand command = new SQLiteCommand("SELECT products.name AS 'Наименование', products.characteristic AS 'Описание товара', warehouse.count_product AS 'Количество', warehouse.sector_on_warehouse AS 'Сектор', products.id FROM products JOIN warehouse ON products.id = warehouse.id_product", ConnectionToDB.DB);
            SQLiteDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            warehouseGridView.DataSource = dt;
            warehouseGridView.Columns[4].Visible = false;
            

            ConnectionToDB.closeDB();
        }

        private void warehouseGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (warehouseGridView.CurrentCell != null && warehouseGridView.CurrentCell.ColumnIndex == 0 && e.RowIndex != -1)
            {

                id_product = Convert.ToInt32(warehouseGridView.Rows[e.RowIndex].Cells[4].Value);
                
                CurrentProdOnWarehouse currentProdOnWarehouse = new CurrentProdOnWarehouse(id_product);
                if (currentProdOnWarehouse.ShowDialog() == DialogResult.Cancel)
                {
                    Warehouse_Load(sender, e);
                }
            }
        }

        private void warehouseGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                this.warehouseGridView.Cursor = Cursors.Hand;
                warehouseGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.AliceBlue;
            }
        }

        private void warehouseGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                this.warehouseGridView.Cursor = Cursors.Default;
                warehouseGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
            }
        }
    }
}

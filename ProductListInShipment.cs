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
        public ProductListInShipment()
        {
            InitializeComponent();
        }

        private void shipListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 0 && Convert.ToBoolean(shipListGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == true)
            {
                MessageBox.Show("Da");
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
            
        }
    }
}

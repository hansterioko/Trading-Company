
namespace Trading_Company
{
    partial class ProductListInShipment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shipListGridView = new System.Windows.Forms.DataGridView();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.shipListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shipListGridView
            // 
            this.shipListGridView.AllowUserToAddRows = false;
            this.shipListGridView.AllowUserToDeleteRows = false;
            this.shipListGridView.AllowUserToResizeColumns = false;
            this.shipListGridView.AllowUserToResizeRows = false;
            this.shipListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected});
            this.shipListGridView.Location = new System.Drawing.Point(13, 13);
            this.shipListGridView.Name = "shipListGridView";
            this.shipListGridView.RowHeadersVisible = false;
            this.shipListGridView.Size = new System.Drawing.Size(505, 280);
            this.shipListGridView.TabIndex = 0;
            this.shipListGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shipListGridView_CellClick);
            this.shipListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shipListGridView_CellContentClick);
            this.shipListGridView.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.shipListGridView_CellStateChanged);
            // 
            // selected
            // 
            this.selected.HeaderText = "Выбор";
            this.selected.Name = "selected";
            // 
            // ProductListInShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shipListGridView);
            this.Name = "ProductListInShipment";
            this.Text = "ProductListInShipment";
            this.Load += new System.EventHandler(this.ProductListInShipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shipListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView shipListGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected;
    }
}
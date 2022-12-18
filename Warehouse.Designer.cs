
namespace Trading_Company
{
    partial class Warehouse
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
            this.bExitToMenu = new System.Windows.Forms.Button();
            this.warehouseGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bExitToMenu
            // 
            this.bExitToMenu.Location = new System.Drawing.Point(359, 391);
            this.bExitToMenu.Name = "bExitToMenu";
            this.bExitToMenu.Size = new System.Drawing.Size(160, 30);
            this.bExitToMenu.TabIndex = 2;
            this.bExitToMenu.Text = "Выход в меню";
            this.bExitToMenu.UseVisualStyleBackColor = true;
            this.bExitToMenu.Click += new System.EventHandler(this.bExitToMenu_Click);
            // 
            // warehouseGridView
            // 
            this.warehouseGridView.AllowUserToAddRows = false;
            this.warehouseGridView.AllowUserToDeleteRows = false;
            this.warehouseGridView.AllowUserToResizeColumns = false;
            this.warehouseGridView.AllowUserToResizeRows = false;
            this.warehouseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.warehouseGridView.Location = new System.Drawing.Point(13, 13);
            this.warehouseGridView.Name = "warehouseGridView";
            this.warehouseGridView.ReadOnly = true;
            this.warehouseGridView.RowHeadersVisible = false;
            this.warehouseGridView.Size = new System.Drawing.Size(506, 359);
            this.warehouseGridView.TabIndex = 3;
            this.warehouseGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.warehouseGridView_CellClick);
            this.warehouseGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.warehouseGridView_CellMouseEnter);
            this.warehouseGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.warehouseGridView_CellMouseLeave);
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 433);
            this.ControlBox = false;
            this.Controls.Add(this.warehouseGridView);
            this.Controls.Add(this.bExitToMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Warehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.Warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bExitToMenu;
        private System.Windows.Forms.DataGridView warehouseGridView;
    }
}
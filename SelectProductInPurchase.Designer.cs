
namespace Trading_Company
{
    partial class SelectProductInPurchase
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
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.selectProd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bAdding = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToAddRows = false;
            this.productsGridView.AllowUserToDeleteRows = false;
            this.productsGridView.AllowUserToResizeColumns = false;
            this.productsGridView.AllowUserToResizeRows = false;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectProd});
            this.productsGridView.Location = new System.Drawing.Point(13, 13);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.RowHeadersVisible = false;
            this.productsGridView.Size = new System.Drawing.Size(775, 315);
            this.productsGridView.TabIndex = 0;
            this.productsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGridView_CellClick);
            this.productsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGridView_CellContentClick);
            this.productsGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGridView_CellMouseEnter);
            this.productsGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGridView_CellMouseLeave);
            this.productsGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGridView_CellValueChanged);
            this.productsGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.productsGridView_EditingControlShowing);
            this.productsGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productsGridView_KeyPress);
            // 
            // selectProd
            // 
            this.selectProd.HeaderText = "Выбор";
            this.selectProd.Name = "selectProd";
            // 
            // bAdding
            // 
            this.bAdding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAdding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bAdding.Location = new System.Drawing.Point(13, 349);
            this.bAdding.Name = "bAdding";
            this.bAdding.Size = new System.Drawing.Size(163, 37);
            this.bAdding.TabIndex = 1;
            this.bAdding.Text = "Добавить";
            this.bAdding.UseVisualStyleBackColor = true;
            this.bAdding.Click += new System.EventHandler(this.bAdding_Click);
            // 
            // bExit
            // 
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bExit.Location = new System.Drawing.Point(625, 349);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(163, 37);
            this.bExit.TabIndex = 2;
            this.bExit.Text = "Назад";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // SelectProductInPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.ControlBox = false;
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bAdding);
            this.Controls.Add(this.productsGridView);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectProductInPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectProductInPurchase";
            this.Load += new System.EventHandler(this.SelectProductInPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectProd;
        private System.Windows.Forms.Button bAdding;
        private System.Windows.Forms.Button bExit;
    }
}
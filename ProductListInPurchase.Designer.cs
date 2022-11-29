
namespace Trading_Company
{
    partial class ProductListInPurchase
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
            this.bAddProduct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bTradingToPurchase = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bAddProduct
            // 
            this.bAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.bAddProduct.Location = new System.Drawing.Point(442, 141);
            this.bAddProduct.Name = "bAddProduct";
            this.bAddProduct.Size = new System.Drawing.Size(154, 65);
            this.bAddProduct.TabIndex = 0;
            this.bAddProduct.Text = "Добавить товар";
            this.bAddProduct.UseVisualStyleBackColor = true;
            this.bAddProduct.Click += new System.EventHandler(this.bAddProduct_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 312);
            this.dataGridView1.TabIndex = 1;
            // 
            // bTradingToPurchase
            // 
            this.bTradingToPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.bTradingToPurchase.Location = new System.Drawing.Point(442, 31);
            this.bTradingToPurchase.Name = "bTradingToPurchase";
            this.bTradingToPurchase.Size = new System.Drawing.Size(154, 70);
            this.bTradingToPurchase.TabIndex = 2;
            this.bTradingToPurchase.Text = "Отправить в закупку";
            this.bTradingToPurchase.UseVisualStyleBackColor = true;
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bExit.Location = new System.Drawing.Point(494, 285);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(102, 40);
            this.bExit.TabIndex = 3;
            this.bExit.Text = "Назад";
            this.bExit.UseVisualStyleBackColor = true;
            // 
            // ProductListInPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 337);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bTradingToPurchase);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bAddProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "ProductListInPurchase";
            this.Text = "ProductListInPurchase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAddProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bTradingToPurchase;
        private System.Windows.Forms.Button bExit;
    }
}
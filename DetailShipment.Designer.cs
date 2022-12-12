
namespace Trading_Company
{
    partial class DetailShipment
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
            this.bExit = new System.Windows.Forms.Button();
            this.prodListGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.prodListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bExit.Location = new System.Drawing.Point(171, 334);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(102, 40);
            this.bExit.TabIndex = 6;
            this.bExit.Text = "Назад";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // prodListGridView
            // 
            this.prodListGridView.AllowUserToAddRows = false;
            this.prodListGridView.AllowUserToDeleteRows = false;
            this.prodListGridView.AllowUserToResizeColumns = false;
            this.prodListGridView.AllowUserToResizeRows = false;
            this.prodListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodListGridView.Location = new System.Drawing.Point(14, -1);
            this.prodListGridView.Name = "prodListGridView";
            this.prodListGridView.ReadOnly = true;
            this.prodListGridView.RowHeadersVisible = false;
            this.prodListGridView.Size = new System.Drawing.Size(419, 312);
            this.prodListGridView.TabIndex = 5;
            this.prodListGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodListGridView_CellClick);
            this.prodListGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodListGridView_CellMouseEnter);
            this.prodListGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodListGridView_CellMouseLeave);
            // 
            // DetailShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 384);
            this.ControlBox = false;
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.prodListGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DetailShipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары в поставке";
            this.Load += new System.EventHandler(this.DetailShipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.DataGridView prodListGridView;
    }
}
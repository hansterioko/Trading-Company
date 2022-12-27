
namespace Trading_Company
{
    partial class SelectShopForReport
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
            this.bOk = new System.Windows.Forms.Button();
            this.shopGridView = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.shopGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bExit.Location = new System.Drawing.Point(11, 400);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(87, 37);
            this.bExit.TabIndex = 5;
            this.bExit.Text = "Назад";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bOk
            // 
            this.bOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bOk.Location = new System.Drawing.Point(507, 400);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(84, 37);
            this.bOk.TabIndex = 4;
            this.bOk.Text = "Ок";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // shopGridView
            // 
            this.shopGridView.AllowUserToAddRows = false;
            this.shopGridView.AllowUserToDeleteRows = false;
            this.shopGridView.AllowUserToResizeColumns = false;
            this.shopGridView.AllowUserToResizeRows = false;
            this.shopGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select});
            this.shopGridView.Location = new System.Drawing.Point(12, 12);
            this.shopGridView.Name = "shopGridView";
            this.shopGridView.RowHeadersVisible = false;
            this.shopGridView.Size = new System.Drawing.Size(579, 382);
            this.shopGridView.TabIndex = 3;
            // 
            // select
            // 
            this.select.HeaderText = "Выбор";
            this.select.Name = "select";
            this.select.ReadOnly = true;
            // 
            // SelectShopForReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.ControlBox = false;
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.shopGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectShopForReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор магазинов";
            this.Load += new System.EventHandler(this.SelectShopForReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.DataGridView shopGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
    }
}
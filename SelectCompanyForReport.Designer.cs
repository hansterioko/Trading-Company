
namespace Trading_Company
{
    partial class SelectCompanyForReport
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
            this.companyGridView = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bOk = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // companyGridView
            // 
            this.companyGridView.AllowUserToAddRows = false;
            this.companyGridView.AllowUserToDeleteRows = false;
            this.companyGridView.AllowUserToResizeColumns = false;
            this.companyGridView.AllowUserToResizeRows = false;
            this.companyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select});
            this.companyGridView.Location = new System.Drawing.Point(13, 13);
            this.companyGridView.Name = "companyGridView";
            this.companyGridView.RowHeadersVisible = false;
            this.companyGridView.Size = new System.Drawing.Size(579, 382);
            this.companyGridView.TabIndex = 0;
            this.companyGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.companyGridView_CellContentClick);
            // 
            // select
            // 
            this.select.HeaderText = "Выбор";
            this.select.Name = "select";
            this.select.ReadOnly = true;
            // 
            // bOk
            // 
            this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bOk.Location = new System.Drawing.Point(508, 401);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(84, 37);
            this.bOk.TabIndex = 1;
            this.bOk.Text = "Ок";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bExit.Location = new System.Drawing.Point(12, 401);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(87, 37);
            this.bExit.TabIndex = 2;
            this.bExit.Text = "Назад";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // SelectCompanyForReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.ControlBox = false;
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.companyGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectCompanyForReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор фирм";
            this.Load += new System.EventHandler(this.SelectCompanyForReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView companyGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bExit;
    }
}
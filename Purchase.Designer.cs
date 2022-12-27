
namespace Trading_Company
{
    partial class Purchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bExitToMenu = new System.Windows.Forms.Button();
            this.purchaseGridView = new System.Windows.Forms.DataGridView();
            this.bAdding = new System.Windows.Forms.Button();
            this.bReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bExitToMenu
            // 
            this.bExitToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExitToMenu.Location = new System.Drawing.Point(486, 312);
            this.bExitToMenu.Name = "bExitToMenu";
            this.bExitToMenu.Size = new System.Drawing.Size(149, 30);
            this.bExitToMenu.TabIndex = 1;
            this.bExitToMenu.Text = "Выход в меню";
            this.bExitToMenu.UseVisualStyleBackColor = true;
            this.bExitToMenu.Click += new System.EventHandler(this.bExitToMenu_Click);
            // 
            // purchaseGridView
            // 
            this.purchaseGridView.AllowUserToAddRows = false;
            this.purchaseGridView.AllowUserToDeleteRows = false;
            this.purchaseGridView.AllowUserToResizeColumns = false;
            this.purchaseGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.purchaseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchaseGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.purchaseGridView.Location = new System.Drawing.Point(13, 12);
            this.purchaseGridView.Name = "purchaseGridView";
            this.purchaseGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchaseGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.purchaseGridView.RowHeadersVisible = false;
            this.purchaseGridView.Size = new System.Drawing.Size(453, 330);
            this.purchaseGridView.TabIndex = 2;
            this.purchaseGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseGridView_CellClick);
            this.purchaseGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseGridView_CellMouseEnter);
            this.purchaseGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseGridView_CellMouseLeave);
            // 
            // bAdding
            // 
            this.bAdding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAdding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAdding.Location = new System.Drawing.Point(496, 12);
            this.bAdding.Name = "bAdding";
            this.bAdding.Size = new System.Drawing.Size(139, 66);
            this.bAdding.TabIndex = 3;
            this.bAdding.Text = "Добавление";
            this.bAdding.UseVisualStyleBackColor = true;
            this.bAdding.Click += new System.EventHandler(this.bAdding_Click);
            // 
            // bReport
            // 
            this.bReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bReport.Location = new System.Drawing.Point(496, 107);
            this.bReport.Name = "bReport";
            this.bReport.Size = new System.Drawing.Size(139, 66);
            this.bReport.TabIndex = 4;
            this.bReport.Text = "Отчёт";
            this.bReport.UseVisualStyleBackColor = true;
            this.bReport.Click += new System.EventHandler(this.bReport_Click);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 354);
            this.ControlBox = false;
            this.Controls.Add(this.bReport);
            this.Controls.Add(this.bAdding);
            this.Controls.Add(this.purchaseGridView);
            this.Controls.Add(this.bExitToMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Закупки";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bExitToMenu;
        private System.Windows.Forms.DataGridView purchaseGridView;
        private System.Windows.Forms.Button bAdding;
        private System.Windows.Forms.Button bReport;
    }
}
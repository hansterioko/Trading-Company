
namespace Trading_Company
{
    partial class Report
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
            this.label1 = new System.Windows.Forms.Label();
            this.richReport = new System.Windows.Forms.RichTextBox();
            this.bSelectCompany = new System.Windows.Forms.Button();
            this.bSelectShop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Закупки";
            // 
            // richReport
            // 
            this.richReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.richReport.Location = new System.Drawing.Point(18, 52);
            this.richReport.Name = "richReport";
            this.richReport.ReadOnly = true;
            this.richReport.Size = new System.Drawing.Size(607, 386);
            this.richReport.TabIndex = 1;
            this.richReport.Text = "";
            // 
            // bSelectCompany
            // 
            this.bSelectCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bSelectCompany.Location = new System.Drawing.Point(54, 444);
            this.bSelectCompany.Name = "bSelectCompany";
            this.bSelectCompany.Size = new System.Drawing.Size(135, 33);
            this.bSelectCompany.TabIndex = 2;
            this.bSelectCompany.Text = "Выбор фирм";
            this.bSelectCompany.UseVisualStyleBackColor = true;
            this.bSelectCompany.Click += new System.EventHandler(this.bSelectCompany_Click);
            // 
            // bSelectShop
            // 
            this.bSelectShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bSelectShop.Location = new System.Drawing.Point(450, 444);
            this.bSelectShop.Name = "bSelectShop";
            this.bSelectShop.Size = new System.Drawing.Size(135, 33);
            this.bSelectShop.TabIndex = 3;
            this.bSelectShop.Text = "Выбор магазинов";
            this.bSelectShop.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 483);
            this.Controls.Add(this.bSelectShop);
            this.Controls.Add(this.bSelectCompany);
            this.Controls.Add(this.richReport);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richReport;
        private System.Windows.Forms.Button bSelectCompany;
        private System.Windows.Forms.Button bSelectShop;
    }
}
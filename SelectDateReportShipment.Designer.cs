
namespace Trading_Company
{
    partial class SelectDateReportShipment
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.byDate = new System.Windows.Forms.DateTimePicker();
            this.byTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.fromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bExit.Location = new System.Drawing.Point(17, 243);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(84, 27);
            this.bExit.TabIndex = 18;
            this.bExit.Text = "Назад";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bOk
            // 
            this.bOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bOk.Location = new System.Drawing.Point(121, 243);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(84, 27);
            this.bOk.TabIndex = 17;
            this.bOk.Text = "Ок";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Поставки по:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Поставки с:";
            // 
            // byDate
            // 
            this.byDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.byDate.Location = new System.Drawing.Point(12, 204);
            this.byDate.Name = "byDate";
            this.byDate.Size = new System.Drawing.Size(200, 20);
            this.byDate.TabIndex = 14;
            // 
            // byTimePicker
            // 
            this.byTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.byTimePicker.Location = new System.Drawing.Point(12, 169);
            this.byTimePicker.Name = "byTimePicker";
            this.byTimePicker.Size = new System.Drawing.Size(200, 20);
            this.byTimePicker.TabIndex = 13;
            this.byTimePicker.Value = new System.DateTime(2022, 12, 1, 16, 30, 45, 0);
            // 
            // fromDate
            // 
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDate.Location = new System.Drawing.Point(12, 94);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(200, 20);
            this.fromDate.TabIndex = 12;
            this.fromDate.Value = new System.DateTime(2022, 12, 9, 18, 49, 2, 0);
            // 
            // fromTimePicker
            // 
            this.fromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.fromTimePicker.Location = new System.Drawing.Point(12, 59);
            this.fromTimePicker.Name = "fromTimePicker";
            this.fromTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromTimePicker.TabIndex = 11;
            this.fromTimePicker.Value = new System.DateTime(2022, 12, 1, 16, 30, 45, 0);
            // 
            // SelectDateReportShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 291);
            this.ControlBox = false;
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.byDate);
            this.Controls.Add(this.byTimePicker);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.fromTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectDateReportShipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор периода поставок";
            this.Load += new System.EventHandler(this.SelectDateReportShipment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker byDate;
        internal System.Windows.Forms.DateTimePicker byTimePicker;
        private System.Windows.Forms.DateTimePicker fromDate;
        internal System.Windows.Forms.DateTimePicker fromTimePicker;
    }
}
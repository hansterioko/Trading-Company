
namespace Trading_Company
{
    partial class SelectDateReport
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
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.fromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.byDate = new System.Windows.Forms.DateTimePicker();
            this.byTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bOk = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fromDate
            // 
            this.fromDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDate.Location = new System.Drawing.Point(12, 89);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(200, 20);
            this.fromDate.TabIndex = 4;
            this.fromDate.Value = new System.DateTime(2022, 12, 9, 18, 49, 2, 0);
            this.fromDate.ValueChanged += new System.EventHandler(this.fromDate_ValueChanged);
            // 
            // fromTimePicker
            // 
            this.fromTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.fromTimePicker.Location = new System.Drawing.Point(12, 54);
            this.fromTimePicker.Name = "fromTimePicker";
            this.fromTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromTimePicker.TabIndex = 3;
            this.fromTimePicker.Value = new System.DateTime(2022, 12, 1, 16, 30, 45, 0);
            this.fromTimePicker.ValueChanged += new System.EventHandler(this.fromTimePicker_ValueChanged);
            // 
            // byDate
            // 
            this.byDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.byDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.byDate.Location = new System.Drawing.Point(12, 199);
            this.byDate.Name = "byDate";
            this.byDate.Size = new System.Drawing.Size(200, 20);
            this.byDate.TabIndex = 6;
            this.byDate.ValueChanged += new System.EventHandler(this.byDate_ValueChanged);
            // 
            // byTimePicker
            // 
            this.byTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.byTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.byTimePicker.Location = new System.Drawing.Point(12, 164);
            this.byTimePicker.Name = "byTimePicker";
            this.byTimePicker.Size = new System.Drawing.Size(200, 20);
            this.byTimePicker.TabIndex = 5;
            this.byTimePicker.Value = new System.DateTime(2022, 12, 1, 16, 30, 45, 0);
            this.byTimePicker.ValueChanged += new System.EventHandler(this.byTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Закупки с:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Закупки по:";
            // 
            // bOk
            // 
            this.bOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bOk.Location = new System.Drawing.Point(121, 238);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(84, 27);
            this.bOk.TabIndex = 9;
            this.bOk.Text = "Ок";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bExit
            // 
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bExit.Location = new System.Drawing.Point(17, 238);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(84, 27);
            this.bExit.TabIndex = 10;
            this.bExit.Text = "Назад";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // SelectDateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 272);
            this.ControlBox = false;
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.byDate);
            this.Controls.Add(this.byTimePicker);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.fromTimePicker);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectDateReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Период закупок";
            this.Load += new System.EventHandler(this.SelectDateReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fromDate;
        internal System.Windows.Forms.DateTimePicker fromTimePicker;
        private System.Windows.Forms.DateTimePicker byDate;
        internal System.Windows.Forms.DateTimePicker byTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bExit;
    }
}
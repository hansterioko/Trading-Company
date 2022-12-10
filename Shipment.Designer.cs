
namespace Trading_Company
{
    partial class Shipment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bAddShipment = new System.Windows.Forms.Button();
            this.bShipmentReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bExitToMenu
            // 
            this.bExitToMenu.Location = new System.Drawing.Point(626, 407);
            this.bExitToMenu.Name = "bExitToMenu";
            this.bExitToMenu.Size = new System.Drawing.Size(160, 30);
            this.bExitToMenu.TabIndex = 0;
            this.bExitToMenu.Text = "Выход в меню";
            this.bExitToMenu.UseVisualStyleBackColor = true;
            this.bExitToMenu.Click += new System.EventHandler(this.bExitToMenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 358);
            this.dataGridView1.TabIndex = 1;
            // 
            // bAddShipment
            // 
            this.bAddShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddShipment.Location = new System.Drawing.Point(564, 13);
            this.bAddShipment.Name = "bAddShipment";
            this.bAddShipment.Size = new System.Drawing.Size(132, 69);
            this.bAddShipment.TabIndex = 2;
            this.bAddShipment.Text = "Добавить";
            this.bAddShipment.UseVisualStyleBackColor = true;
            this.bAddShipment.Click += new System.EventHandler(this.bAddShipment_Click);
            // 
            // bShipmentReport
            // 
            this.bShipmentReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bShipmentReport.Location = new System.Drawing.Point(563, 98);
            this.bShipmentReport.Name = "bShipmentReport";
            this.bShipmentReport.Size = new System.Drawing.Size(132, 69);
            this.bShipmentReport.TabIndex = 3;
            this.bShipmentReport.Text = "Отчёт";
            this.bShipmentReport.UseVisualStyleBackColor = true;
            // 
            // Shipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.bShipmentReport);
            this.Controls.Add(this.bAddShipment);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bExitToMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Shipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bExitToMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bAddShipment;
        private System.Windows.Forms.Button bShipmentReport;
    }
}
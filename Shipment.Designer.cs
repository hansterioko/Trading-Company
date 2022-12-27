
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
            this.shipmentGridView = new System.Windows.Forms.DataGridView();
            this.bAddShipment = new System.Windows.Forms.Button();
            this.bShipmentReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bExitToMenu
            // 
            this.bExitToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExitToMenu.Location = new System.Drawing.Point(571, 386);
            this.bExitToMenu.Name = "bExitToMenu";
            this.bExitToMenu.Size = new System.Drawing.Size(160, 30);
            this.bExitToMenu.TabIndex = 0;
            this.bExitToMenu.Text = "Выход в меню";
            this.bExitToMenu.UseVisualStyleBackColor = true;
            this.bExitToMenu.Click += new System.EventHandler(this.bExitToMenu_Click);
            // 
            // shipmentGridView
            // 
            this.shipmentGridView.AllowUserToAddRows = false;
            this.shipmentGridView.AllowUserToDeleteRows = false;
            this.shipmentGridView.AllowUserToResizeColumns = false;
            this.shipmentGridView.AllowUserToResizeRows = false;
            this.shipmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipmentGridView.Location = new System.Drawing.Point(13, 13);
            this.shipmentGridView.Name = "shipmentGridView";
            this.shipmentGridView.ReadOnly = true;
            this.shipmentGridView.RowHeadersVisible = false;
            this.shipmentGridView.Size = new System.Drawing.Size(555, 358);
            this.shipmentGridView.TabIndex = 1;
            this.shipmentGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shipmentGridView_CellClick);
            this.shipmentGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.shipmentGridView_CellMouseEnter);
            this.shipmentGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.shipmentGridView_CellMouseLeave);
            // 
            // bAddShipment
            // 
            this.bAddShipment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddShipment.Location = new System.Drawing.Point(600, 9);
            this.bAddShipment.Name = "bAddShipment";
            this.bAddShipment.Size = new System.Drawing.Size(132, 69);
            this.bAddShipment.TabIndex = 2;
            this.bAddShipment.Text = "Добавить";
            this.bAddShipment.UseVisualStyleBackColor = true;
            this.bAddShipment.Click += new System.EventHandler(this.bAddShipment_Click);
            // 
            // bShipmentReport
            // 
            this.bShipmentReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bShipmentReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bShipmentReport.Location = new System.Drawing.Point(599, 94);
            this.bShipmentReport.Name = "bShipmentReport";
            this.bShipmentReport.Size = new System.Drawing.Size(132, 69);
            this.bShipmentReport.TabIndex = 3;
            this.bShipmentReport.Text = "Отчёт";
            this.bShipmentReport.UseVisualStyleBackColor = true;
            this.bShipmentReport.Click += new System.EventHandler(this.bShipmentReport_Click);
            // 
            // Shipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 428);
            this.ControlBox = false;
            this.Controls.Add(this.bShipmentReport);
            this.Controls.Add(this.bAddShipment);
            this.Controls.Add(this.shipmentGridView);
            this.Controls.Add(this.bExitToMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Shipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставки";
            this.Load += new System.EventHandler(this.Shipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shipmentGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bExitToMenu;
        private System.Windows.Forms.DataGridView shipmentGridView;
        private System.Windows.Forms.Button bAddShipment;
        private System.Windows.Forms.Button bShipmentReport;
    }
}
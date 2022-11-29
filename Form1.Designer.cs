
namespace Trading_Company
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bShipment = new System.Windows.Forms.Button();
            this.bWarehouse = new System.Windows.Forms.Button();
            this.bPurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bShipment
            // 
            this.bShipment.BackColor = System.Drawing.Color.White;
            this.bShipment.BackgroundImage = global::Trading_Company.Properties.Resources.shipment;
            this.bShipment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bShipment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bShipment.Location = new System.Drawing.Point(465, 0);
            this.bShipment.Name = "bShipment";
            this.bShipment.Size = new System.Drawing.Size(237, 445);
            this.bShipment.TabIndex = 2;
            this.bShipment.Text = "Поставки";
            this.bShipment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bShipment.UseVisualStyleBackColor = false;
            this.bShipment.Click += new System.EventHandler(this.bShipment_Click);
            // 
            // bWarehouse
            // 
            this.bWarehouse.BackColor = System.Drawing.Color.White;
            this.bWarehouse.BackgroundImage = global::Trading_Company.Properties.Resources.warehouse;
            this.bWarehouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bWarehouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bWarehouse.Location = new System.Drawing.Point(245, 0);
            this.bWarehouse.Name = "bWarehouse";
            this.bWarehouse.Size = new System.Drawing.Size(214, 445);
            this.bWarehouse.TabIndex = 1;
            this.bWarehouse.Text = "Склад";
            this.bWarehouse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bWarehouse.UseVisualStyleBackColor = false;
            this.bWarehouse.Click += new System.EventHandler(this.bWarehouse_Click);
            // 
            // bPurchase
            // 
            this.bPurchase.BackColor = System.Drawing.Color.White;
            this.bPurchase.BackgroundImage = global::Trading_Company.Properties.Resources.f503c85dd8fc14dcfafdf7ab4094b3bd;
            this.bPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPurchase.Location = new System.Drawing.Point(1, 0);
            this.bPurchase.Name = "bPurchase";
            this.bPurchase.Size = new System.Drawing.Size(238, 445);
            this.bPurchase.TabIndex = 0;
            this.bPurchase.Text = "Закупки";
            this.bPurchase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bPurchase.UseVisualStyleBackColor = false;
            this.bPurchase.Click += new System.EventHandler(this.bPurchase_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.bShipment);
            this.Controls.Add(this.bWarehouse);
            this.Controls.Add(this.bPurchase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bPurchase;
        private System.Windows.Forms.Button bWarehouse;
        private System.Windows.Forms.Button bShipment;
    }
}


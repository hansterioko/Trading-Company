﻿
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
            // Shipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bExitToMenu);
            this.Name = "Shipment";
            this.Text = "Shipment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Shipment_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bExitToMenu;
    }
}
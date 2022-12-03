
namespace Trading_Company
{
    partial class CurrentProduct
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.richSummaryBox = new System.Windows.Forms.RichTextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.countBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bDeleteProduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bChange = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.unitBox = new System.Windows.Forms.TextBox();
            this.vatBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(178, 25);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(148, 20);
            this.nameBox.TabIndex = 0;
            // 
            // categoryBox
            // 
            this.categoryBox.Location = new System.Drawing.Point(178, 62);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.ReadOnly = true;
            this.categoryBox.Size = new System.Drawing.Size(148, 20);
            this.categoryBox.TabIndex = 2;
            // 
            // richSummaryBox
            // 
            this.richSummaryBox.Location = new System.Drawing.Point(15, 324);
            this.richSummaryBox.Name = "richSummaryBox";
            this.richSummaryBox.ReadOnly = true;
            this.richSummaryBox.Size = new System.Drawing.Size(314, 69);
            this.richSummaryBox.TabIndex = 3;
            this.richSummaryBox.Text = "";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(178, 102);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(148, 20);
            this.priceBox.TabIndex = 4;
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(178, 140);
            this.countBox.Name = "countBox";
            this.countBox.ReadOnly = true;
            this.countBox.Size = new System.Drawing.Size(148, 20);
            this.countBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цена за единицу товара";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Кол-во в закупке";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Описание товара";
            // 
            // bDeleteProduct
            // 
            this.bDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bDeleteProduct.Location = new System.Drawing.Point(18, 399);
            this.bDeleteProduct.Name = "bDeleteProduct";
            this.bDeleteProduct.Size = new System.Drawing.Size(304, 23);
            this.bDeleteProduct.TabIndex = 11;
            this.bDeleteProduct.Text = "Удаление товара в закупке";
            this.bDeleteProduct.UseVisualStyleBackColor = true;
            this.bDeleteProduct.Click += new System.EventHandler(this.bDeleteProduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bChange
            // 
            this.bChange.Location = new System.Drawing.Point(18, 429);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(154, 23);
            this.bChange.TabIndex = 12;
            this.bChange.Text = "Изменить";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(181, 429);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(141, 23);
            this.bOk.TabIndex = 13;
            this.bOk.Text = "Сохранить";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Visible = false;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // unitBox
            // 
            this.unitBox.Location = new System.Drawing.Point(21, 178);
            this.unitBox.Name = "unitBox";
            this.unitBox.ReadOnly = true;
            this.unitBox.Size = new System.Drawing.Size(148, 20);
            this.unitBox.TabIndex = 14;
            // 
            // vatBox
            // 
            this.vatBox.Location = new System.Drawing.Point(178, 178);
            this.vatBox.Name = "vatBox";
            this.vatBox.ReadOnly = true;
            this.vatBox.Size = new System.Drawing.Size(148, 20);
            this.vatBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Единица измерения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "НДС";
            // 
            // CurrentProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vatBox);
            this.Controls.Add(this.unitBox);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.bChange);
            this.Controls.Add(this.bDeleteProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.richSummaryBox);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurrentProduct";
            this.Text = "Информация о товаре";
            this.Load += new System.EventHandler(this.CurrentProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox categoryBox;
        private System.Windows.Forms.RichTextBox richSummaryBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bDeleteProduct;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.TextBox unitBox;
        private System.Windows.Forms.TextBox vatBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
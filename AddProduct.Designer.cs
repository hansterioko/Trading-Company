
namespace Trading_Company
{
    partial class AddProduct
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
            this.nameBox1 = new System.Windows.Forms.TextBox();
            this.bAddPhoto = new System.Windows.Forms.Button();
            this.categoryBox2 = new System.Windows.Forms.TextBox();
            this.unitBox3 = new System.Windows.Forms.TextBox();
            this.vatBox4 = new System.Windows.Forms.TextBox();
            this.richSummaryBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bAddProductInList = new System.Windows.Forms.Button();
            this.countBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picturePhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox1
            // 
            this.nameBox1.Location = new System.Drawing.Point(12, 188);
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(276, 20);
            this.nameBox1.TabIndex = 1;
            // 
            // bAddPhoto
            // 
            this.bAddPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bAddPhoto.Location = new System.Drawing.Point(207, 13);
            this.bAddPhoto.Name = "bAddPhoto";
            this.bAddPhoto.Size = new System.Drawing.Size(82, 61);
            this.bAddPhoto.TabIndex = 2;
            this.bAddPhoto.Text = "Добавить фото";
            this.bAddPhoto.UseVisualStyleBackColor = true;
            this.bAddPhoto.Click += new System.EventHandler(this.bAddPhoto_Click);
            // 
            // categoryBox2
            // 
            this.categoryBox2.Location = new System.Drawing.Point(13, 231);
            this.categoryBox2.Name = "categoryBox2";
            this.categoryBox2.Size = new System.Drawing.Size(276, 20);
            this.categoryBox2.TabIndex = 3;
            // 
            // unitBox3
            // 
            this.unitBox3.Location = new System.Drawing.Point(12, 278);
            this.unitBox3.Name = "unitBox3";
            this.unitBox3.Size = new System.Drawing.Size(276, 20);
            this.unitBox3.TabIndex = 4;
            // 
            // vatBox4
            // 
            this.vatBox4.Location = new System.Drawing.Point(12, 321);
            this.vatBox4.Name = "vatBox4";
            this.vatBox4.Size = new System.Drawing.Size(277, 20);
            this.vatBox4.TabIndex = 5;
            this.vatBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vatBox4_KeyPress);
            // 
            // richSummaryBox
            // 
            this.richSummaryBox.Location = new System.Drawing.Point(13, 467);
            this.richSummaryBox.Name = "richSummaryBox";
            this.richSummaryBox.Size = new System.Drawing.Size(275, 105);
            this.richSummaryBox.TabIndex = 6;
            this.richSummaryBox.Text = "";
            this.richSummaryBox.TextChanged += new System.EventHandler(this.richSummaryBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Единица измерения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Описание";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "НДС";
            // 
            // bAddProductInList
            // 
            this.bAddProductInList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bAddProductInList.Location = new System.Drawing.Point(14, 578);
            this.bAddProductInList.Name = "bAddProductInList";
            this.bAddProductInList.Size = new System.Drawing.Size(276, 31);
            this.bAddProductInList.TabIndex = 12;
            this.bAddProductInList.Text = "Добавить товар в список";
            this.bAddProductInList.UseVisualStyleBackColor = true;
            this.bAddProductInList.Click += new System.EventHandler(this.bAddProductInList_Click);
            // 
            // countBox1
            // 
            this.countBox1.Location = new System.Drawing.Point(12, 360);
            this.countBox1.Name = "countBox1";
            this.countBox1.Size = new System.Drawing.Size(277, 20);
            this.countBox1.TabIndex = 13;
            this.countBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Количество";
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(117, 623);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 15;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(12, 397);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(277, 20);
            this.priceBox.TabIndex = 16;
            this.priceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Цена";
            // 
            // picturePhoto
            // 
            this.picturePhoto.Location = new System.Drawing.Point(13, 13);
            this.picturePhoto.Name = "picturePhoto";
            this.picturePhoto.Size = new System.Drawing.Size(187, 147);
            this.picturePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePhoto.TabIndex = 0;
            this.picturePhoto.TabStop = false;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 654);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.countBox1);
            this.Controls.Add(this.bAddProductInList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richSummaryBox);
            this.Controls.Add(this.vatBox4);
            this.Controls.Add(this.unitBox3);
            this.Controls.Add(this.categoryBox2);
            this.Controls.Add(this.bAddPhoto);
            this.Controls.Add(this.nameBox1);
            this.Controls.Add(this.picturePhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление товара в лист закупки";
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePhoto;
        private System.Windows.Forms.TextBox nameBox1;
        private System.Windows.Forms.Button bAddPhoto;
        private System.Windows.Forms.TextBox categoryBox2;
        private System.Windows.Forms.TextBox unitBox3;
        private System.Windows.Forms.TextBox vatBox4;
        private System.Windows.Forms.RichTextBox richSummaryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bAddProductInList;
        private System.Windows.Forms.TextBox countBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label7;
    }
}
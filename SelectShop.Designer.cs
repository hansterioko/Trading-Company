
namespace Trading_Company
{
    partial class SelectShop
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
            this.bAddShop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.houseBox = new System.Windows.Forms.TextBox();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.telNumbBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.comboShop = new System.Windows.Forms.ComboBox();
            this.bExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAddShop
            // 
            this.bAddShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddShop.Location = new System.Drawing.Point(12, 283);
            this.bAddShop.Name = "bAddShop";
            this.bAddShop.Size = new System.Drawing.Size(149, 62);
            this.bAddShop.TabIndex = 29;
            this.bAddShop.Text = "Добавить магазин";
            this.bAddShop.UseVisualStyleBackColor = true;
            this.bAddShop.Click += new System.EventHandler(this.bAddShop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Дом*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Улица*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Город*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Телефон";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Название*";
            // 
            // houseBox
            // 
            this.houseBox.Location = new System.Drawing.Point(12, 243);
            this.houseBox.MaxLength = 5;
            this.houseBox.Name = "houseBox";
            this.houseBox.Size = new System.Drawing.Size(149, 20);
            this.houseBox.TabIndex = 23;
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(12, 201);
            this.streetBox.MaxLength = 60;
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(149, 20);
            this.streetBox.TabIndex = 22;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(12, 158);
            this.cityBox.MaxLength = 60;
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(149, 20);
            this.cityBox.TabIndex = 21;
            // 
            // telNumbBox
            // 
            this.telNumbBox.Location = new System.Drawing.Point(11, 113);
            this.telNumbBox.MaxLength = 12;
            this.telNumbBox.Name = "telNumbBox";
            this.telNumbBox.Size = new System.Drawing.Size(149, 20);
            this.telNumbBox.TabIndex = 20;
            this.telNumbBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telNumbBox_KeyPress);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(11, 68);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(149, 20);
            this.nameBox.TabIndex = 19;
            // 
            // comboShop
            // 
            this.comboShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboShop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboShop.FormattingEnabled = true;
            this.comboShop.Location = new System.Drawing.Point(12, 12);
            this.comboShop.Name = "comboShop";
            this.comboShop.Size = new System.Drawing.Size(149, 21);
            this.comboShop.TabIndex = 18;
            this.comboShop.SelectedIndexChanged += new System.EventHandler(this.comboShop_SelectedIndexChanged);
            // 
            // bExit
            // 
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bExit.Location = new System.Drawing.Point(33, 351);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(102, 40);
            this.bExit.TabIndex = 17;
            this.bExit.Text = "Назад";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // SelectShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 402);
            this.ControlBox = false;
            this.Controls.Add(this.bAddShop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.houseBox);
            this.Controls.Add(this.streetBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.telNumbBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.comboShop);
            this.Controls.Add(this.bExit);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор магазина";
            this.Load += new System.EventHandler(this.SelectShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddShop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox houseBox;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox telNumbBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ComboBox comboShop;
        private System.Windows.Forms.Button bExit;
    }
}
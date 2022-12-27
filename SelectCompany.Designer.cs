
namespace Trading_Company
{
    partial class SelectCompany
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
            this.comboCompany = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.telNumbBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.houseBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bAddCompany = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bExit.Location = new System.Drawing.Point(34, 352);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(102, 40);
            this.bExit.TabIndex = 4;
            this.bExit.Text = "Назад";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // comboCompany
            // 
            this.comboCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCompany.FormattingEnabled = true;
            this.comboCompany.Location = new System.Drawing.Point(13, 13);
            this.comboCompany.Name = "comboCompany";
            this.comboCompany.Size = new System.Drawing.Size(149, 21);
            this.comboCompany.TabIndex = 5;
            this.comboCompany.SelectedIndexChanged += new System.EventHandler(this.comboCompany_SelectedIndexChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 69);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(149, 20);
            this.nameBox.TabIndex = 6;
            // 
            // telNumbBox
            // 
            this.telNumbBox.Location = new System.Drawing.Point(12, 114);
            this.telNumbBox.Name = "telNumbBox";
            this.telNumbBox.Size = new System.Drawing.Size(149, 20);
            this.telNumbBox.TabIndex = 7;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(13, 159);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(149, 20);
            this.cityBox.TabIndex = 8;
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(13, 202);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(149, 20);
            this.streetBox.TabIndex = 9;
            // 
            // houseBox
            // 
            this.houseBox.Location = new System.Drawing.Point(13, 244);
            this.houseBox.Name = "houseBox";
            this.houseBox.Size = new System.Drawing.Size(149, 20);
            this.houseBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Город*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Дом*";
            // 
            // bAddCompany
            // 
            this.bAddCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddCompany.Location = new System.Drawing.Point(13, 284);
            this.bAddCompany.Name = "bAddCompany";
            this.bAddCompany.Size = new System.Drawing.Size(149, 62);
            this.bAddCompany.TabIndex = 16;
            this.bAddCompany.Text = "Добавить компанию";
            this.bAddCompany.UseVisualStyleBackColor = true;
            this.bAddCompany.Click += new System.EventHandler(this.bAddCompany_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Улица*";
            // 
            // SelectCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 398);
            this.ControlBox = false;
            this.Controls.Add(this.bAddCompany);
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
            this.Controls.Add(this.comboCompany);
            this.Controls.Add(this.bExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор компании";
            this.Load += new System.EventHandler(this.SelectCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.ComboBox comboCompany;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox telNumbBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.TextBox houseBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bAddCompany;
        private System.Windows.Forms.Label label4;
    }
}
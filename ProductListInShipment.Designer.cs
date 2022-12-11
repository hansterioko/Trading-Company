
namespace Trading_Company
{
    partial class ProductListInShipment
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
            this.shipListGridView = new System.Windows.Forms.DataGridView();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.discountBar = new System.Windows.Forms.TrackBar();
            this.bUpdShipment = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.shipListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountBar)).BeginInit();
            this.SuspendLayout();
            // 
            // shipListGridView
            // 
            this.shipListGridView.AllowUserToAddRows = false;
            this.shipListGridView.AllowUserToDeleteRows = false;
            this.shipListGridView.AllowUserToResizeColumns = false;
            this.shipListGridView.AllowUserToResizeRows = false;
            this.shipListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected});
            this.shipListGridView.Location = new System.Drawing.Point(13, 13);
            this.shipListGridView.Name = "shipListGridView";
            this.shipListGridView.RowHeadersVisible = false;
            this.shipListGridView.Size = new System.Drawing.Size(775, 280);
            this.shipListGridView.TabIndex = 0;
            this.shipListGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shipListGridView_CellClick);
            this.shipListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shipListGridView_CellContentClick);
            this.shipListGridView.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.shipListGridView_CellStateChanged);
            // 
            // selected
            // 
            this.selected.HeaderText = "Выбор";
            this.selected.Name = "selected";
            // 
            // discountBar
            // 
            this.discountBar.Location = new System.Drawing.Point(333, 393);
            this.discountBar.Name = "discountBar";
            this.discountBar.Size = new System.Drawing.Size(257, 45);
            this.discountBar.TabIndex = 1;
            this.discountBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.discountBar.Scroll += new System.EventHandler(this.discountBar_Scroll);
            // 
            // bUpdShipment
            // 
            this.bUpdShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bUpdShipment.Location = new System.Drawing.Point(596, 310);
            this.bUpdShipment.Name = "bUpdShipment";
            this.bUpdShipment.Size = new System.Drawing.Size(192, 58);
            this.bUpdShipment.TabIndex = 2;
            this.bUpdShipment.Text = "Отправить в поставки";
            this.bUpdShipment.UseVisualStyleBackColor = true;
            this.bUpdShipment.Click += new System.EventHandler(this.bUpdShipment_Click);
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.Location = new System.Drawing.Point(664, 405);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(124, 33);
            this.bExit.TabIndex = 3;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(329, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Общая скидка для магазина";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(403, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 29);
            this.textBox1.TabIndex = 5;
            // 
            // ProductListInShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bUpdShipment);
            this.Controls.Add(this.discountBar);
            this.Controls.Add(this.shipListGridView);
            this.Name = "ProductListInShipment";
            this.Text = "ProductListInShipment";
            this.Load += new System.EventHandler(this.ProductListInShipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shipListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView shipListGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected;
        private System.Windows.Forms.TrackBar discountBar;
        private System.Windows.Forms.Button bUpdShipment;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
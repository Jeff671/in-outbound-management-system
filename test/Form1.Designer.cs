namespace test
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.inputdata = new System.Windows.Forms.Button();
            this.outputdata = new System.Windows.Forms.Button();
            this.mount = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.shipment = new System.Windows.Forms.Label();
            this.numshow = new System.Windows.Forms.Label();
            this.showlog = new System.Windows.Forms.RichTextBox();
            this.shipmentbar = new System.Windows.Forms.ComboBox();
            this.pricetext = new System.Windows.Forms.TextBox();
            this.mounttext = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outshipment = new System.Windows.Forms.RadioButton();
            this.inshipment = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputdata
            // 
            this.inputdata.Location = new System.Drawing.Point(23, 256);
            this.inputdata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputdata.Name = "inputdata";
            this.inputdata.Size = new System.Drawing.Size(80, 26);
            this.inputdata.TabIndex = 0;
            this.inputdata.Text = "輸入資料";
            this.inputdata.UseVisualStyleBackColor = true;
            this.inputdata.Click += new System.EventHandler(this.inputdata_Click);
            // 
            // outputdata
            // 
            this.outputdata.Location = new System.Drawing.Point(141, 256);
            this.outputdata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputdata.Name = "outputdata";
            this.outputdata.Size = new System.Drawing.Size(80, 26);
            this.outputdata.TabIndex = 1;
            this.outputdata.Text = "輸出資料";
            this.outputdata.UseVisualStyleBackColor = true;
            // 
            // mount
            // 
            this.mount.AutoSize = true;
            this.mount.Font = new System.Drawing.Font("新細明體", 14F);
            this.mount.Location = new System.Drawing.Point(44, 109);
            this.mount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mount.Name = "mount";
            this.mount.Size = new System.Drawing.Size(47, 19);
            this.mount.TabIndex = 5;
            this.mount.Text = "數量";
            this.mount.Click += new System.EventHandler(this.label4_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("新細明體", 14F);
            this.price.Location = new System.Drawing.Point(43, 84);
            this.price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(47, 19);
            this.price.TabIndex = 6;
            this.price.Text = "單價";
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Font = new System.Drawing.Font("新細明體", 14F);
            this.num.Location = new System.Drawing.Point(43, 29);
            this.num.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(47, 19);
            this.num.TabIndex = 7;
            this.num.Text = "編號";
            this.num.Click += new System.EventHandler(this.num_Click);
            // 
            // shipment
            // 
            this.shipment.AutoSize = true;
            this.shipment.Font = new System.Drawing.Font("新細明體", 14F);
            this.shipment.Location = new System.Drawing.Point(43, 57);
            this.shipment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shipment.Name = "shipment";
            this.shipment.Size = new System.Drawing.Size(47, 19);
            this.shipment.TabIndex = 8;
            this.shipment.Text = "貨品";
            this.shipment.Click += new System.EventHandler(this.shipment_Click);
            // 
            // numshow
            // 
            this.numshow.AutoSize = true;
            this.numshow.Font = new System.Drawing.Font("新細明體", 14F);
            this.numshow.Location = new System.Drawing.Point(131, 29);
            this.numshow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numshow.Name = "numshow";
            this.numshow.Size = new System.Drawing.Size(21, 19);
            this.numshow.TabIndex = 9;
            this.numshow.Text = "--";
            // 
            // showlog
            // 
            this.showlog.Location = new System.Drawing.Point(38, 190);
            this.showlog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showlog.Name = "showlog";
            this.showlog.Size = new System.Drawing.Size(172, 57);
            this.showlog.TabIndex = 10;
            this.showlog.Text = "";
            // 
            // shipmentbar
            // 
            this.shipmentbar.FormattingEnabled = true;
            this.shipmentbar.Items.AddRange(new object[] {
            "繃帶",
            "酒精",
            "口罩",
            "溫度計"});
            this.shipmentbar.Location = new System.Drawing.Point(109, 57);
            this.shipmentbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.shipmentbar.Name = "shipmentbar";
            this.shipmentbar.Size = new System.Drawing.Size(82, 20);
            this.shipmentbar.TabIndex = 11;
            this.shipmentbar.SelectedIndexChanged += new System.EventHandler(this.shipmentbar_SelectedIndexChanged);
            // 
            // pricetext
            // 
            this.pricetext.Location = new System.Drawing.Point(115, 84);
            this.pricetext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pricetext.Name = "pricetext";
            this.pricetext.Size = new System.Drawing.Size(68, 22);
            this.pricetext.TabIndex = 12;
            // 
            // mounttext
            // 
            this.mounttext.Location = new System.Drawing.Point(115, 109);
            this.mounttext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mounttext.Name = "mounttext";
            this.mounttext.Size = new System.Drawing.Size(68, 22);
            this.mounttext.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outshipment);
            this.groupBox1.Controls.Add(this.inshipment);
            this.groupBox1.Location = new System.Drawing.Point(38, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(171, 37);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "進出貨";
            // 
            // outshipment
            // 
            this.outshipment.AutoSize = true;
            this.outshipment.Location = new System.Drawing.Point(112, 19);
            this.outshipment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outshipment.Name = "outshipment";
            this.outshipment.Size = new System.Drawing.Size(47, 16);
            this.outshipment.TabIndex = 1;
            this.outshipment.TabStop = true;
            this.outshipment.Text = "出貨";
            this.outshipment.UseVisualStyleBackColor = true;
            // 
            // inshipment
            // 
            this.inshipment.AutoSize = true;
            this.inshipment.Location = new System.Drawing.Point(5, 19);
            this.inshipment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inshipment.Name = "inshipment";
            this.inshipment.Size = new System.Drawing.Size(47, 16);
            this.inshipment.TabIndex = 0;
            this.inshipment.TabStop = true;
            this.inshipment.Text = "進貨";
            this.inshipment.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readmeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(45, 22);
            this.toolStripMenuItem1.Text = "read";
            // 
            // readmeToolStripMenuItem
            // 
            this.readmeToolStripMenuItem.Name = "readmeToolStripMenuItem";
            this.readmeToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.readmeToolStripMenuItem.Text = "readme";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(238, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 209);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(450, 183);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "資料列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(447, 179);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "編號";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "日期";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "類別";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "名稱";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "單價";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "數量";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "總價";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(450, 183);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "出貨圖表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(450, 183);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "統計";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::test.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(392, 256);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 340);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mounttext);
            this.Controls.Add(this.pricetext);
            this.Controls.Add(this.shipmentbar);
            this.Controls.Add(this.showlog);
            this.Controls.Add(this.numshow);
            this.Controls.Add(this.shipment);
            this.Controls.Add(this.num);
            this.Controls.Add(this.price);
            this.Controls.Add(this.mount);
            this.Controls.Add(this.outputdata);
            this.Controls.Add(this.inputdata);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputdata;
        private System.Windows.Forms.Button outputdata;
        private System.Windows.Forms.Label mount;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label shipment;
        private System.Windows.Forms.Label numshow;
        private System.Windows.Forms.RichTextBox showlog;
        private System.Windows.Forms.ComboBox shipmentbar;
        private System.Windows.Forms.TextBox pricetext;
        private System.Windows.Forms.TextBox mounttext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton outshipment;
        private System.Windows.Forms.RadioButton inshipment;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


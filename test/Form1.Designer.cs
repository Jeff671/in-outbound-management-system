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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.ExportExcelBut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ExportGraphicBut1 = new System.Windows.Forms.Button();
            this.ExportReportBut1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reNewdata = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // inputdata
            // 
            this.inputdata.Location = new System.Drawing.Point(40, 415);
            this.inputdata.Name = "inputdata";
            this.inputdata.Size = new System.Drawing.Size(120, 39);
            this.inputdata.TabIndex = 0;
            this.inputdata.Text = "輸入資料";
            this.inputdata.UseVisualStyleBackColor = true;
            this.inputdata.Click += new System.EventHandler(this.inputdata_Click);
            // 
            // outputdata
            // 
            this.outputdata.Location = new System.Drawing.Point(361, 415);
            this.outputdata.Name = "outputdata";
            this.outputdata.Size = new System.Drawing.Size(120, 39);
            this.outputdata.TabIndex = 1;
            this.outputdata.Text = "輸出資料";
            this.outputdata.UseVisualStyleBackColor = true;
            this.outputdata.Click += new System.EventHandler(this.outputdata_Click);
            // 
            // mount
            // 
            this.mount.AutoSize = true;
            this.mount.Font = new System.Drawing.Font("新細明體", 14F);
            this.mount.Location = new System.Drawing.Point(66, 164);
            this.mount.Name = "mount";
            this.mount.Size = new System.Drawing.Size(68, 28);
            this.mount.TabIndex = 5;
            this.mount.Text = "數量";
            this.mount.Click += new System.EventHandler(this.label4_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("新細明體", 14F);
            this.price.Location = new System.Drawing.Point(64, 126);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(68, 28);
            this.price.TabIndex = 6;
            this.price.Text = "單價";
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Font = new System.Drawing.Font("新細明體", 14F);
            this.num.Location = new System.Drawing.Point(64, 44);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(68, 28);
            this.num.TabIndex = 7;
            this.num.Text = "編號";
            this.num.Click += new System.EventHandler(this.num_Click);
            // 
            // shipment
            // 
            this.shipment.AutoSize = true;
            this.shipment.Font = new System.Drawing.Font("新細明體", 14F);
            this.shipment.Location = new System.Drawing.Point(64, 86);
            this.shipment.Name = "shipment";
            this.shipment.Size = new System.Drawing.Size(68, 28);
            this.shipment.TabIndex = 8;
            this.shipment.Text = "貨品";
            this.shipment.Click += new System.EventHandler(this.shipment_Click);
            // 
            // numshow
            // 
            this.numshow.AutoSize = true;
            this.numshow.Font = new System.Drawing.Font("新細明體", 14F);
            this.numshow.Location = new System.Drawing.Point(196, 44);
            this.numshow.Name = "numshow";
            this.numshow.Size = new System.Drawing.Size(30, 28);
            this.numshow.TabIndex = 9;
            this.numshow.Text = "--";
            // 
            // showlog
            // 
            this.showlog.Location = new System.Drawing.Point(57, 285);
            this.showlog.Name = "showlog";
            this.showlog.Size = new System.Drawing.Size(256, 84);
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
            this.shipmentbar.Location = new System.Drawing.Point(164, 86);
            this.shipmentbar.Name = "shipmentbar";
            this.shipmentbar.Size = new System.Drawing.Size(121, 26);
            this.shipmentbar.TabIndex = 11;
            this.shipmentbar.SelectedIndexChanged += new System.EventHandler(this.shipmentbar_SelectedIndexChanged);
            // 
            // pricetext
            // 
            this.pricetext.Location = new System.Drawing.Point(172, 126);
            this.pricetext.Name = "pricetext";
            this.pricetext.Size = new System.Drawing.Size(100, 29);
            this.pricetext.TabIndex = 12;
            // 
            // mounttext
            // 
            this.mounttext.Location = new System.Drawing.Point(172, 164);
            this.mounttext.Name = "mounttext";
            this.mounttext.Size = new System.Drawing.Size(100, 29);
            this.mounttext.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outshipment);
            this.groupBox1.Controls.Add(this.inshipment);
            this.groupBox1.Location = new System.Drawing.Point(57, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 56);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "進出貨";
            // 
            // outshipment
            // 
            this.outshipment.AutoSize = true;
            this.outshipment.Location = new System.Drawing.Point(168, 28);
            this.outshipment.Name = "outshipment";
            this.outshipment.Size = new System.Drawing.Size(69, 22);
            this.outshipment.TabIndex = 1;
            this.outshipment.TabStop = true;
            this.outshipment.Text = "出貨";
            this.outshipment.UseVisualStyleBackColor = true;
            // 
            // inshipment
            // 
            this.inshipment.AutoSize = true;
            this.inshipment.Location = new System.Drawing.Point(8, 28);
            this.inshipment.Name = "inshipment";
            this.inshipment.Size = new System.Drawing.Size(69, 22);
            this.inshipment.TabIndex = 0;
            this.inshipment.TabStop = true;
            this.inshipment.Text = "進貨";
            this.inshipment.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1242, 31);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readmeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 27);
            this.toolStripMenuItem1.Text = "read";
            // 
            // readmeToolStripMenuItem
            // 
            this.readmeToolStripMenuItem.Name = "readmeToolStripMenuItem";
            this.readmeToolStripMenuItem.Size = new System.Drawing.Size(175, 34);
            this.readmeToolStripMenuItem.Text = "readme";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(175, 34);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(357, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(873, 350);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ExportExcelBut);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(865, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "資料列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ExportExcelBut
            // 
            this.ExportExcelBut.Location = new System.Drawing.Point(9, 232);
            this.ExportExcelBut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExportExcelBut.Name = "ExportExcelBut";
            this.ExportExcelBut.Size = new System.Drawing.Size(112, 34);
            this.ExportExcelBut.TabIndex = 1;
            this.ExportExcelBut.Text = "輸出Excel";
            this.ExportExcelBut.UseVisualStyleBackColor = true;
            this.ExportExcelBut.Click += new System.EventHandler(this.ExcelExportbut_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 65;
            this.dataGridView1.Size = new System.Drawing.Size(670, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.ExportGraphicBut1);
            this.tabPage2.Controls.Add(this.ExportReportBut1);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(865, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "出貨圖表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ExportGraphicBut1
            // 
            this.ExportGraphicBut1.Location = new System.Drawing.Point(236, 251);
            this.ExportGraphicBut1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExportGraphicBut1.Name = "ExportGraphicBut1";
            this.ExportGraphicBut1.Size = new System.Drawing.Size(112, 34);
            this.ExportGraphicBut1.TabIndex = 3;
            this.ExportGraphicBut1.Text = "匯出圖片";
            this.ExportGraphicBut1.UseVisualStyleBackColor = true;
            this.ExportGraphicBut1.Click += new System.EventHandler(this.ExportGraphicBut_Click);
            // 
            // ExportReportBut1
            // 
            this.ExportReportBut1.Location = new System.Drawing.Point(38, 252);
            this.ExportReportBut1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExportReportBut1.Name = "ExportReportBut1";
            this.ExportReportBut1.Size = new System.Drawing.Size(112, 34);
            this.ExportReportBut1.TabIndex = 2;
            this.ExportReportBut1.Text = "匯出報表";
            this.ExportReportBut1.UseVisualStyleBackColor = true;
            this.ExportReportBut1.Click += new System.EventHandler(this.ExportReportBut_Click);
            // 
            // chart1
            // 
            chartArea13.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chart1.Legends.Add(legend13);
            this.chart1.Location = new System.Drawing.Point(8, 30);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series13.ChartArea = "ChartArea1";
            series13.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            series13.Label = "#VAL";
            series13.Legend = "Legend1";
            series13.Name = "stocks";
            this.chart1.Series.Add(series13);
            this.chart1.Size = new System.Drawing.Size(410, 212);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "出貨各類別資料";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(865, 318);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "統計";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::test.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(922, 415);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // reNewdata
            // 
            this.reNewdata.Location = new System.Drawing.Point(201, 415);
            this.reNewdata.Name = "reNewdata";
            this.reNewdata.Size = new System.Drawing.Size(120, 39);
            this.reNewdata.TabIndex = 18;
            this.reNewdata.Text = "更新資料";
            this.reNewdata.UseMnemonic = false;
            this.reNewdata.UseVisualStyleBackColor = true;
            this.reNewdata.Click += new System.EventHandler(this.reNewdata_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "出貨各類別總量比例";
            // 
            // chart2
            // 
            chartArea14.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea14);
            legend14.Enabled = false;
            legend14.Name = "Legend1";
            this.chart2.Legends.Add(legend14);
            this.chart2.Location = new System.Drawing.Point(425, 29);
            this.chart2.Name = "chart2";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series14.CustomProperties = "PieLabelStyle=Outside, PieLineColor=Black";
            series14.Font = new System.Drawing.Font("微軟正黑體", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series14.Label = "#VALX \\n#PERCENT / #VAL";
            series14.Legend = "Legend1";
            series14.Name = "stocks";
            this.chart2.Series.Add(series14);
            this.chart2.Size = new System.Drawing.Size(420, 212);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "匯出報表";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 252);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "匯出圖片";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "基本統計數據";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "QR Code";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(62, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(308, 240);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(452, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 232);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 477);
            this.Controls.Add(this.reNewdata);
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
            this.Name = "Form1";
            this.Text = "進出貨紀錄系統";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button reNewdata;
        private System.Windows.Forms.Button ExportExcelBut;
        private System.Windows.Forms.Button ExportGraphicBut1;
        private System.Windows.Forms.Button ExportReportBut1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}


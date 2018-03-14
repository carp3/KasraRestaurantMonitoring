namespace KasraMonitoring
{
    partial class Monitoring
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.MonitroingUpdate = new System.Windows.Forms.Timer(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonName = new System.Windows.Forms.Label();
            this.PersonID = new System.Windows.Forms.Label();
            this.DeptName = new System.Windows.Forms.Label();
            this.FishNum = new System.Windows.Forms.Label();
            this.FoodName = new System.Windows.Forms.Label();
            this.FoodTerm = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.RestName = new System.Windows.Forms.Label();
            this.StrError = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SummeryUpdate = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.Served = new System.Windows.Forms.Label();
            this.ServedDetail = new System.Windows.Forms.Label();
            this.PictureUpdate = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateUpdate = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MonitroingUpdate
            // 
            this.MonitroingUpdate.Enabled = true;
            this.MonitroingUpdate.Interval = 500;
            this.MonitroingUpdate.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader9});
            this.listView1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 306);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(1000, 357);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "شماره فیش";
            this.columnHeader6.Width = 82;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "پرسنلی";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "نام";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "واحد";
            this.columnHeader8.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "غذا";
            this.columnHeader3.Width = 147;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ساعت";
            this.columnHeader4.Width = 63;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "وعده";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "رستوران";
            this.columnHeader7.Width = 89;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "مجاز";
            this.columnHeader9.Width = 117;
            // 
            // PersonName
            // 
            this.PersonName.Font = new System.Drawing.Font("B Titr", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PersonName.Location = new System.Drawing.Point(6, 25);
            this.PersonName.Name = "PersonName";
            this.PersonName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PersonName.Size = new System.Drawing.Size(345, 65);
            this.PersonName.TabIndex = 1;
            this.PersonName.Text = "نام نام خانوادگی";
            this.PersonName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PersonID
            // 
            this.PersonID.Font = new System.Drawing.Font("B Titr", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PersonID.Location = new System.Drawing.Point(357, 29);
            this.PersonID.Name = "PersonID";
            this.PersonID.Size = new System.Drawing.Size(167, 61);
            this.PersonID.TabIndex = 2;
            this.PersonID.Text = "000000";
            this.PersonID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeptName
            // 
            this.DeptName.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DeptName.Location = new System.Drawing.Point(118, 90);
            this.DeptName.Name = "DeptName";
            this.DeptName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DeptName.Size = new System.Drawing.Size(221, 38);
            this.DeptName.TabIndex = 3;
            this.DeptName.Text = "واحد کاری";
            this.DeptName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FishNum
            // 
            this.FishNum.AutoSize = true;
            this.FishNum.Font = new System.Drawing.Font("B Titr", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FishNum.Location = new System.Drawing.Point(353, 34);
            this.FishNum.Name = "FishNum";
            this.FishNum.Size = new System.Drawing.Size(96, 65);
            this.FishNum.TabIndex = 4;
            this.FishNum.Text = "0000";
            // 
            // FoodName
            // 
            this.FoodName.Font = new System.Drawing.Font("B Titr", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FoodName.Location = new System.Drawing.Point(17, 134);
            this.FoodName.Name = "FoodName";
            this.FoodName.Size = new System.Drawing.Size(401, 59);
            this.FoodName.TabIndex = 7;
            this.FoodName.Text = "نام غذا";
            this.FoodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FoodTerm
            // 
            this.FoodTerm.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FoodTerm.Location = new System.Drawing.Point(80, 26);
            this.FoodTerm.Name = "FoodTerm";
            this.FoodTerm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FoodTerm.Size = new System.Drawing.Size(267, 38);
            this.FoodTerm.TabIndex = 8;
            this.FoodTerm.Text = "وعده";
            this.FoodTerm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Time.Location = new System.Drawing.Point(17, 59);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(57, 31);
            this.Time.TabIndex = 9;
            this.Time.Text = "00:00";
            this.Time.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RestName
            // 
            this.RestName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RestName.Location = new System.Drawing.Point(86, 64);
            this.RestName.Name = "RestName";
            this.RestName.Size = new System.Drawing.Size(261, 31);
            this.RestName.TabIndex = 10;
            this.RestName.Text = "نام رستوران";
            this.RestName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StrError
            // 
            this.StrError.Font = new System.Drawing.Font("B Titr", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.StrError.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.StrError.Location = new System.Drawing.Point(14, 219);
            this.StrError.Name = "StrError";
            this.StrError.Size = new System.Drawing.Size(453, 81);
            this.StrError.TabIndex = 11;
            this.StrError.Text = "مجاز به استفاده";
            this.StrError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StrError.Click += new System.EventHandler(this.StrError_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(940, 712);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(853, 738);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "Written by Pedram Azimaie - Feb 2018";
            // 
            // SummeryUpdate
            // 
            this.SummeryUpdate.Enabled = true;
            this.SummeryUpdate.Interval = 1000;
            this.SummeryUpdate.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(204, 669);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "وعده سرو شده:";
            // 
            // Served
            // 
            this.Served.AutoSize = true;
            this.Served.Font = new System.Drawing.Font("B Nazanin", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Served.Location = new System.Drawing.Point(204, 688);
            this.Served.Name = "Served";
            this.Served.Size = new System.Drawing.Size(80, 47);
            this.Served.TabIndex = 15;
            this.Served.Text = "0000";
            this.Served.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ServedDetail
            // 
            this.ServedDetail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ServedDetail.Location = new System.Drawing.Point(26, 738);
            this.ServedDetail.Name = "ServedDetail";
            this.ServedDetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ServedDetail.Size = new System.Drawing.Size(205, 14);
            this.ServedDetail.TabIndex = 16;
            this.ServedDetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PictureUpdate
            // 
            this.PictureUpdate.Interval = 500;
            this.PictureUpdate.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeptName);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.FoodName);
            this.groupBox1.Controls.Add(this.PersonName);
            this.groupBox1.Controls.Add(this.PersonID);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(480, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(530, 209);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات پرسنلی";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(435, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FishNum);
            this.groupBox2.Controls.Add(this.FoodTerm);
            this.groupBox2.Controls.Add(this.Time);
            this.groupBox2.Controls.Add(this.RestName);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(14, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(460, 122);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فیش";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "صبحانه",
            "ناهار",
            "شام",
            "سحري",
            "افطاري",
            "ميان وعده",
            "خودکار"});
            this.comboBox1.Location = new System.Drawing.Point(425, 669);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "رستوران مركزي",
            "رستوران دانه بندي",
            "رستوران ذخيره سازي",
            "رستوران شهرك"});
            this.comboBox2.Location = new System.Drawing.Point(425, 696);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(552, 699);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = ":رستوران";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(552, 672);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = ":وعده";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 669);
            this.chart1.Name = "chart1";
            series2.BackSecondaryColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Color = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            dataPoint3.Label = "غذای 1";
            dataPoint4.LegendText = "غذای 2";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(178, 66);
            this.chart1.TabIndex = 26;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dateUpdate
            // 
            this.dateUpdate.Enabled = true;
            this.dateUpdate.Interval = 900;
            this.dateUpdate.Tick += new System.EventHandler(this.dateUpdate_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KasraMonitoring.Properties.Resources.logo1;
            this.pictureBox2.Location = new System.Drawing.Point(766, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(360, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 42);
            this.label2.TabIndex = 28;
            this.label2.Text = "مانیتورینگ غذای سرو شده";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateLabel.Location = new System.Drawing.Point(23, 33);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(145, 33);
            this.dateLabel.TabIndex = 29;
            this.dateLabel.Text = "____/__/__";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(817, 669);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(195, 21);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "جستجو...";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(819, 670);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 19);
            this.button2.TabIndex = 31;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(552, 725);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = ":تاریخ";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "امروز"});
            this.comboBox3.Location = new System.Drawing.Point(425, 722);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 33;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 756);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ServedDetail);
            this.Controls.Add(this.StrError);
            this.Controls.Add(this.Served);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Monitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasra Monitoring";
            this.Load += new System.EventHandler(this.Monitoring_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MonitroingUpdate;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label PersonName;
        private System.Windows.Forms.Label PersonID;
        private System.Windows.Forms.Label DeptName;
        private System.Windows.Forms.Label FishNum;
        private System.Windows.Forms.Label FoodName;
        private System.Windows.Forms.Label FoodTerm;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label RestName;
        private System.Windows.Forms.Label StrError;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer SummeryUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Served;
        private System.Windows.Forms.Label ServedDetail;
        private System.Windows.Forms.Timer PictureUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer dateUpdate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}
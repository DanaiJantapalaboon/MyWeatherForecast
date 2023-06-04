
namespace MyWeatherForecast
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.weatherTable = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.btnDeleteALL = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labDateTime = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labCity = new System.Windows.Forms.Label();
            this.labHumidity = new System.Windows.Forms.Label();
            this.labTemp = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labRealFeel = new System.Windows.Forms.Label();
            this.labWindspeed = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1532, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToExcelToolStripMenuItem,
            this.menuFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.exportToExcelToolStripMenuItem.Text = "Export to Excel";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(191, 26);
            this.menuFileExit.Text = "Exit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.deleteHistoryToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // deleteHistoryToolStripMenuItem
            // 
            this.deleteHistoryToolStripMenuItem.Name = "deleteHistoryToolStripMenuItem";
            this.deleteHistoryToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.deleteHistoryToolStripMenuItem.Text = "Delete History";
            this.deleteHistoryToolStripMenuItem.Click += new System.EventHandler(this.deleteHistoryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(633, 42);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(671, 27);
            this.tbCity.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(571, 493);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 32);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input City Name";
            // 
            // weatherTable
            // 
            this.weatherTable.AllowUserToAddRows = false;
            this.weatherTable.AllowUserToDeleteRows = false;
            this.weatherTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weatherTable.Location = new System.Drawing.Point(491, 139);
            this.weatherTable.Name = "weatherTable";
            this.weatherTable.ReadOnly = true;
            this.weatherTable.RowHeadersWidth = 51;
            this.weatherTable.RowTemplate.Height = 24;
            this.weatherTable.Size = new System.Drawing.Size(1022, 267);
            this.weatherTable.TabIndex = 6;
            this.weatherTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.weatherTable_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(487, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "History";
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Image = global::MyWeatherForecast.Properties.Resources.download_icon1;
            this.btnGetWeather.Location = new System.Drawing.Point(633, 75);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(311, 56);
            this.btnGetWeather.TabIndex = 10;
            this.btnGetWeather.Text = "Get Your Weather";
            this.btnGetWeather.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetWeather.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetWeather.UseCompatibleTextRendering = true;
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // btnDeleteALL
            // 
            this.btnDeleteALL.Image = global::MyWeatherForecast.Properties.Resources.trash_icon;
            this.btnDeleteALL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteALL.Location = new System.Drawing.Point(1151, 75);
            this.btnDeleteALL.Name = "btnDeleteALL";
            this.btnDeleteALL.Size = new System.Drawing.Size(153, 57);
            this.btnDeleteALL.TabIndex = 9;
            this.btnDeleteALL.Text = "Delete History";
            this.btnDeleteALL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteALL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteALL.UseCompatibleTextRendering = true;
            this.btnDeleteALL.UseVisualStyleBackColor = true;
            this.btnDeleteALL.Click += new System.EventHandler(this.btnDeleteALL_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::MyWeatherForecast.Properties.Resources.excel_icon_32;
            this.btnExcel.Location = new System.Drawing.Point(950, 75);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(195, 57);
            this.btnExcel.TabIndex = 8;
            this.btnExcel.Text = "Export to Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseCompatibleTextRendering = true;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MyWeatherForecast.Properties.Resources.openweather_logo;
            this.pictureBox1.Location = new System.Drawing.Point(1325, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::MyWeatherForecast.Properties.Resources.nature;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.labDateTime);
            this.panel1.Controls.Add(this.labSunset);
            this.panel1.Controls.Add(this.labSunrise);
            this.panel1.Controls.Add(this.labCity);
            this.panel1.Controls.Add(this.labHumidity);
            this.panel1.Controls.Add(this.labTemp);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labRealFeel);
            this.panel1.Controls.Add(this.labWindspeed);
            this.panel1.Controls.Add(this.labPressure);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 419);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MyWeatherForecast.Properties.Resources.sunrise_icon;
            this.pictureBox4.Location = new System.Drawing.Point(23, 318);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MyWeatherForecast.Properties.Resources.humidity_icon;
            this.pictureBox5.Location = new System.Drawing.Point(23, 277);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::MyWeatherForecast.Properties.Resources.sunset_icon;
            this.pictureBox3.Location = new System.Drawing.Point(23, 359);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::MyWeatherForecast.Properties.Resources.gauge_icon;
            this.pictureBox6.Location = new System.Drawing.Point(23, 236);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(37, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // labDateTime
            // 
            this.labDateTime.AutoSize = true;
            this.labDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labDateTime.ForeColor = System.Drawing.Color.Tomato;
            this.labDateTime.Location = new System.Drawing.Point(19, 18);
            this.labDateTime.Name = "labDateTime";
            this.labDateTime.Size = new System.Drawing.Size(37, 20);
            this.labDateTime.TabIndex = 8;
            this.labDateTime.Text = "N/A";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.Location = new System.Drawing.Point(66, 365);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(41, 23);
            this.labSunset.TabIndex = 3;
            this.labSunset.Text = "N/A";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.Location = new System.Drawing.Point(66, 325);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(41, 23);
            this.labSunrise.TabIndex = 3;
            this.labSunrise.Text = "N/A";
            // 
            // labCity
            // 
            this.labCity.AutoSize = true;
            this.labCity.BackColor = System.Drawing.Color.Transparent;
            this.labCity.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCity.Location = new System.Drawing.Point(12, 32);
            this.labCity.Name = "labCity";
            this.labCity.Size = new System.Drawing.Size(96, 51);
            this.labCity.TabIndex = 3;
            this.labCity.Text = "N/A";
            // 
            // labHumidity
            // 
            this.labHumidity.AutoSize = true;
            this.labHumidity.BackColor = System.Drawing.Color.Transparent;
            this.labHumidity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHumidity.Location = new System.Drawing.Point(67, 283);
            this.labHumidity.Name = "labHumidity";
            this.labHumidity.Size = new System.Drawing.Size(41, 23);
            this.labHumidity.TabIndex = 3;
            this.labHumidity.Text = "N/A";
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.BackColor = System.Drawing.Color.Transparent;
            this.labTemp.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTemp.Location = new System.Drawing.Point(14, 100);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(67, 54);
            this.labTemp.TabIndex = 3;
            this.labTemp.Text = "00";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MyWeatherForecast.Properties.Resources.windspeed_icon;
            this.pictureBox2.Location = new System.Drawing.Point(23, 195);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // labRealFeel
            // 
            this.labRealFeel.AutoSize = true;
            this.labRealFeel.BackColor = System.Drawing.Color.Transparent;
            this.labRealFeel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRealFeel.Location = new System.Drawing.Point(19, 154);
            this.labRealFeel.Name = "labRealFeel";
            this.labRealFeel.Size = new System.Drawing.Size(41, 23);
            this.labRealFeel.TabIndex = 3;
            this.labRealFeel.Text = "N/A";
            // 
            // labWindspeed
            // 
            this.labWindspeed.AutoSize = true;
            this.labWindspeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindspeed.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindspeed.Location = new System.Drawing.Point(67, 201);
            this.labWindspeed.Name = "labWindspeed";
            this.labWindspeed.Size = new System.Drawing.Size(41, 23);
            this.labWindspeed.TabIndex = 3;
            this.labWindspeed.Text = "N/A";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.Location = new System.Drawing.Point(67, 242);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(41, 23);
            this.labPressure.TabIndex = 3;
            this.labPressure.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search (case sensitive)";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(672, 414);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(364, 22);
            this.tbSearch.TabIndex = 12;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1259, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "MyWeather Forecast - version 1.00a";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1045, 408);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 35);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1532, 438);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetWeather);
            this.Controls.Add(this.btnDeleteALL);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.weatherTable);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1550, 485);
            this.MinimumSize = new System.Drawing.Size(1550, 485);
            this.Name = "Form1";
            this.Text = "MyWeather Forecast v1.00a (Free)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView weatherTable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label labWindspeed;
        private System.Windows.Forms.Label labRealFeel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labTemp;
        private System.Windows.Forms.Label labHumidity;
        private System.Windows.Forms.Label labCity;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label labDateTime;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnDeleteALL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteHistoryToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
    }
}


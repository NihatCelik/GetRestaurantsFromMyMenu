namespace GetRestaurantsFromMyMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenInBrowser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudFinish = new System.Windows.Forms.NumericUpDown();
            this.nudStart = new System.Windows.Forms.NumericUpDown();
            this.btnReadRestaurantLinks = new System.Windows.Forms.Button();
            this.btnSaveRestaurantLinks = new System.Windows.Forms.Button();
            this.btnReadCSV = new System.Windows.Forms.Button();
            this.btnScanPostalCodes = new System.Windows.Forms.Button();
            this.btnWriteCSV = new System.Windows.Forms.Button();
            this.btnReadPostalCodes = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnScanRestaurantsFromLinks = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOpenInBrowser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudFinish);
            this.panel1.Controls.Add(this.nudStart);
            this.panel1.Controls.Add(this.btnReadRestaurantLinks);
            this.panel1.Controls.Add(this.btnSaveRestaurantLinks);
            this.panel1.Controls.Add(this.btnReadCSV);
            this.panel1.Controls.Add(this.btnScanPostalCodes);
            this.panel1.Controls.Add(this.btnScanRestaurantsFromLinks);
            this.panel1.Controls.Add(this.btnWriteCSV);
            this.panel1.Controls.Add(this.btnReadPostalCodes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 74);
            this.panel1.TabIndex = 0;
            // 
            // btnOpenInBrowser
            // 
            this.btnOpenInBrowser.Location = new System.Drawing.Point(410, 40);
            this.btnOpenInBrowser.Name = "btnOpenInBrowser";
            this.btnOpenInBrowser.Size = new System.Drawing.Size(131, 23);
            this.btnOpenInBrowser.TabIndex = 10;
            this.btnOpenInBrowser.Text = "Open In Browser";
            this.btnOpenInBrowser.UseVisualStyleBackColor = true;
            this.btnOpenInBrowser.Click += new System.EventHandler(this.btnOpenInBrowser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "-";
            // 
            // nudFinish
            // 
            this.nudFinish.Location = new System.Drawing.Point(335, 41);
            this.nudFinish.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudFinish.Name = "nudFinish";
            this.nudFinish.Size = new System.Drawing.Size(69, 20);
            this.nudFinish.TabIndex = 9;
            // 
            // nudStart
            // 
            this.nudStart.Location = new System.Drawing.Point(256, 41);
            this.nudStart.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudStart.Name = "nudStart";
            this.nudStart.Size = new System.Drawing.Size(69, 20);
            this.nudStart.TabIndex = 7;
            // 
            // btnReadRestaurantLinks
            // 
            this.btnReadRestaurantLinks.Location = new System.Drawing.Point(410, 11);
            this.btnReadRestaurantLinks.Name = "btnReadRestaurantLinks";
            this.btnReadRestaurantLinks.Size = new System.Drawing.Size(131, 23);
            this.btnReadRestaurantLinks.TabIndex = 3;
            this.btnReadRestaurantLinks.Text = "Read Restaurant Links";
            this.btnReadRestaurantLinks.UseVisualStyleBackColor = true;
            this.btnReadRestaurantLinks.Click += new System.EventHandler(this.btnReadRestaurantLinks_Click);
            // 
            // btnSaveRestaurantLinks
            // 
            this.btnSaveRestaurantLinks.Location = new System.Drawing.Point(256, 11);
            this.btnSaveRestaurantLinks.Name = "btnSaveRestaurantLinks";
            this.btnSaveRestaurantLinks.Size = new System.Drawing.Size(148, 23);
            this.btnSaveRestaurantLinks.TabIndex = 2;
            this.btnSaveRestaurantLinks.Text = "Save Restaurant Links";
            this.btnSaveRestaurantLinks.UseVisualStyleBackColor = true;
            this.btnSaveRestaurantLinks.Click += new System.EventHandler(this.btnSaveRestaurantLinks_Click);
            // 
            // btnReadCSV
            // 
            this.btnReadCSV.Location = new System.Drawing.Point(134, 40);
            this.btnReadCSV.Name = "btnReadCSV";
            this.btnReadCSV.Size = new System.Drawing.Size(116, 23);
            this.btnReadCSV.TabIndex = 6;
            this.btnReadCSV.Text = "Read CSV";
            this.btnReadCSV.UseVisualStyleBackColor = true;
            this.btnReadCSV.Click += new System.EventHandler(this.btnReadCSV_Click);
            // 
            // btnScanPostalCodes
            // 
            this.btnScanPostalCodes.Location = new System.Drawing.Point(134, 11);
            this.btnScanPostalCodes.Name = "btnScanPostalCodes";
            this.btnScanPostalCodes.Size = new System.Drawing.Size(116, 23);
            this.btnScanPostalCodes.TabIndex = 1;
            this.btnScanPostalCodes.Text = "Scan Postal Codes";
            this.btnScanPostalCodes.UseVisualStyleBackColor = true;
            this.btnScanPostalCodes.Click += new System.EventHandler(this.btnScanPostalCodes_Click);
            // 
            // btnWriteCSV
            // 
            this.btnWriteCSV.Location = new System.Drawing.Point(12, 40);
            this.btnWriteCSV.Name = "btnWriteCSV";
            this.btnWriteCSV.Size = new System.Drawing.Size(116, 23);
            this.btnWriteCSV.TabIndex = 5;
            this.btnWriteCSV.Text = "Write CSV";
            this.btnWriteCSV.UseVisualStyleBackColor = true;
            this.btnWriteCSV.Click += new System.EventHandler(this.btnWriteCSV_Click);
            // 
            // btnReadPostalCodes
            // 
            this.btnReadPostalCodes.Location = new System.Drawing.Point(12, 11);
            this.btnReadPostalCodes.Name = "btnReadPostalCodes";
            this.btnReadPostalCodes.Size = new System.Drawing.Size(116, 23);
            this.btnReadPostalCodes.TabIndex = 0;
            this.btnReadPostalCodes.Text = "Read Postal Codes";
            this.btnReadPostalCodes.UseVisualStyleBackColor = true;
            this.btnReadPostalCodes.Click += new System.EventHandler(this.btnReadPostalCodes_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(246, 74);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(554, 376);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("https://www.mymenu.be", System.UriKind.Absolute);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 376);
            this.panel2.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 376);
            this.listBox1.TabIndex = 0;
            // 
            // btnScanRestaurantsFromLinks
            // 
            this.btnScanRestaurantsFromLinks.Location = new System.Drawing.Point(547, 11);
            this.btnScanRestaurantsFromLinks.Name = "btnScanRestaurantsFromLinks";
            this.btnScanRestaurantsFromLinks.Size = new System.Drawing.Size(164, 23);
            this.btnScanRestaurantsFromLinks.TabIndex = 4;
            this.btnScanRestaurantsFromLinks.Text = "Scan Restaurants From Links";
            this.btnScanRestaurantsFromLinks.UseVisualStyleBackColor = true;
            this.btnScanRestaurantsFromLinks.Click += new System.EventHandler(this.btnScanRestaurantsFromLinks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Get Restaurants From MyMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReadPostalCodes;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnScanPostalCodes;
        private System.Windows.Forms.Button btnSaveRestaurantLinks;
        private System.Windows.Forms.Button btnReadRestaurantLinks;
        private System.Windows.Forms.Button btnReadCSV;
        private System.Windows.Forms.Button btnWriteCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudFinish;
        private System.Windows.Forms.NumericUpDown nudStart;
        private System.Windows.Forms.Button btnOpenInBrowser;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnScanRestaurantsFromLinks;
    }
}


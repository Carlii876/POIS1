
namespace POIS1
{
    partial class Report
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
            this.toppanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Reportbtn = new FontAwesome.Sharp.IconButton();
            this.Calculationbtn = new FontAwesome.Sharp.IconButton();
            this.LogInvbtn = new FontAwesome.Sharp.IconButton();
            this.LogPObtn = new FontAwesome.Sharp.IconButton();
            this.Homebtn = new FontAwesome.Sharp.IconButton();
            this.poispB = new System.Windows.Forms.PictureBox();
            this.ViewsMenue = new System.Windows.Forms.MenuStrip();
            this.viewInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInvoicesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logPurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPurchaseOrderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Helplbl = new FontAwesome.Sharp.IconButton();
            this.Logoutlb = new FontAwesome.Sharp.IconButton();
            this.homeicon = new System.Windows.Forms.PictureBox();
            this.poislogo = new System.Windows.Forms.PictureBox();
            this.VenderNamelbl = new System.Windows.Forms.Label();
            this.GenerateReportcb = new System.Windows.Forms.ComboBox();
            this.ReportGridView = new System.Windows.Forms.DataGridView();
            this.Refreshbtn = new FontAwesome.Sharp.IconButton();
            this.searchbtn = new FontAwesome.Sharp.IconButton();
            this.searchicon = new FontAwesome.Sharp.IconButton();
            this.toppanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poispB)).BeginInit();
            this.ViewsMenue.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poislogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.toppanel.Controls.Add(this.panel3);
            this.toppanel.Controls.Add(this.poispB);
            this.toppanel.Controls.Add(this.ViewsMenue);
            this.toppanel.Controls.Add(this.panel1);
            this.toppanel.Controls.Add(this.homeicon);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1632, 102);
            this.toppanel.TabIndex = 105;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Reportbtn);
            this.panel3.Controls.Add(this.Calculationbtn);
            this.panel3.Controls.Add(this.LogInvbtn);
            this.panel3.Controls.Add(this.LogPObtn);
            this.panel3.Controls.Add(this.Homebtn);
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1044, 46);
            this.panel3.TabIndex = 21;
            // 
            // Reportbtn
            // 
            this.Reportbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportbtn.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.Reportbtn.IconColor = System.Drawing.Color.White;
            this.Reportbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Reportbtn.IconSize = 18;
            this.Reportbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportbtn.Location = new System.Drawing.Point(836, 2);
            this.Reportbtn.Name = "Reportbtn";
            this.Reportbtn.Size = new System.Drawing.Size(175, 46);
            this.Reportbtn.TabIndex = 4;
            this.Reportbtn.Text = "Report";
            this.Reportbtn.UseVisualStyleBackColor = true;
            this.Reportbtn.Click += new System.EventHandler(this.Reportbtn_Click);
            // 
            // Calculationbtn
            // 
            this.Calculationbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculationbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculationbtn.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.Calculationbtn.IconColor = System.Drawing.Color.White;
            this.Calculationbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Calculationbtn.IconSize = 18;
            this.Calculationbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Calculationbtn.Location = new System.Drawing.Point(627, 0);
            this.Calculationbtn.Name = "Calculationbtn";
            this.Calculationbtn.Size = new System.Drawing.Size(175, 46);
            this.Calculationbtn.TabIndex = 3;
            this.Calculationbtn.Text = "Calculation";
            this.Calculationbtn.UseVisualStyleBackColor = true;
            this.Calculationbtn.Click += new System.EventHandler(this.Calculationbtn_Click);
            // 
            // LogInvbtn
            // 
            this.LogInvbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInvbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInvbtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.LogInvbtn.IconColor = System.Drawing.Color.White;
            this.LogInvbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogInvbtn.IconSize = 18;
            this.LogInvbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogInvbtn.Location = new System.Drawing.Point(418, 0);
            this.LogInvbtn.Name = "LogInvbtn";
            this.LogInvbtn.Size = new System.Drawing.Size(175, 46);
            this.LogInvbtn.TabIndex = 2;
            this.LogInvbtn.Text = "Log Invoice";
            this.LogInvbtn.UseVisualStyleBackColor = true;
            this.LogInvbtn.Click += new System.EventHandler(this.LogInvbtn_Click);
            // 
            // LogPObtn
            // 
            this.LogPObtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogPObtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogPObtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.LogPObtn.IconColor = System.Drawing.Color.White;
            this.LogPObtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogPObtn.IconSize = 18;
            this.LogPObtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogPObtn.Location = new System.Drawing.Point(202, 0);
            this.LogPObtn.Name = "LogPObtn";
            this.LogPObtn.Size = new System.Drawing.Size(187, 46);
            this.LogPObtn.TabIndex = 1;
            this.LogPObtn.Text = "Purchase Order";
            this.LogPObtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogPObtn.UseVisualStyleBackColor = true;
            this.LogPObtn.Click += new System.EventHandler(this.LogPObtn_Click);
            // 
            // Homebtn
            // 
            this.Homebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Homebtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Homebtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Homebtn.IconColor = System.Drawing.Color.White;
            this.Homebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Homebtn.IconSize = 20;
            this.Homebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Homebtn.Location = new System.Drawing.Point(0, 0);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(175, 46);
            this.Homebtn.TabIndex = 0;
            this.Homebtn.Text = "Home";
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // poispB
            // 
            this.poispB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.poispB.Image = global::POIS1.Properties.Resources.POIS_white_;
            this.poispB.Location = new System.Drawing.Point(675, 0);
            this.poispB.Name = "poispB";
            this.poispB.Size = new System.Drawing.Size(138, 55);
            this.poispB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.poispB.TabIndex = 20;
            this.poispB.TabStop = false;
            // 
            // ViewsMenue
            // 
            this.ViewsMenue.BackColor = System.Drawing.Color.Transparent;
            this.ViewsMenue.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ViewsMenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInvoicesToolStripMenuItem,
            this.viewPurchaseOrderToolStripMenuItem,
            this.viewReportsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.ViewsMenue.Location = new System.Drawing.Point(0, 0);
            this.ViewsMenue.Name = "ViewsMenue";
            this.ViewsMenue.Size = new System.Drawing.Size(1368, 27);
            this.ViewsMenue.TabIndex = 19;
            this.ViewsMenue.Text = "menuStrip1";
            // 
            // viewInvoicesToolStripMenuItem
            // 
            this.viewInvoicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInvoicesToolStripMenuItem,
            this.viewInvoicesToolStripMenuItem1});
            this.viewInvoicesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.viewInvoicesToolStripMenuItem.Name = "viewInvoicesToolStripMenuItem";
            this.viewInvoicesToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.viewInvoicesToolStripMenuItem.Text = "Invoices";
            // 
            // logInvoicesToolStripMenuItem
            // 
            this.logInvoicesToolStripMenuItem.Name = "logInvoicesToolStripMenuItem";
            this.logInvoicesToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.logInvoicesToolStripMenuItem.Text = "Log Invoices";
            // 
            // viewInvoicesToolStripMenuItem1
            // 
            this.viewInvoicesToolStripMenuItem1.Name = "viewInvoicesToolStripMenuItem1";
            this.viewInvoicesToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.viewInvoicesToolStripMenuItem1.Text = "View Invoices";
            // 
            // viewPurchaseOrderToolStripMenuItem
            // 
            this.viewPurchaseOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logPurchaseOrderToolStripMenuItem,
            this.viewPurchaseOrderToolStripMenuItem1});
            this.viewPurchaseOrderToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.viewPurchaseOrderToolStripMenuItem.Name = "viewPurchaseOrderToolStripMenuItem";
            this.viewPurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(118, 23);
            this.viewPurchaseOrderToolStripMenuItem.Text = "Purchase Order";
            // 
            // logPurchaseOrderToolStripMenuItem
            // 
            this.logPurchaseOrderToolStripMenuItem.Name = "logPurchaseOrderToolStripMenuItem";
            this.logPurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.logPurchaseOrderToolStripMenuItem.Text = "Log Purchase Order";
            // 
            // viewPurchaseOrderToolStripMenuItem1
            // 
            this.viewPurchaseOrderToolStripMenuItem1.Name = "viewPurchaseOrderToolStripMenuItem1";
            this.viewPurchaseOrderToolStripMenuItem1.Size = new System.Drawing.Size(220, 26);
            this.viewPurchaseOrderToolStripMenuItem1.Text = "View Purchase Order";
            // 
            // viewReportsToolStripMenuItem
            // 
            this.viewReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReportsToolStripMenuItem1});
            this.viewReportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.viewReportsToolStripMenuItem.Name = "viewReportsToolStripMenuItem";
            this.viewReportsToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.viewReportsToolStripMenuItem.Text = "Reports";
            // 
            // viewReportsToolStripMenuItem1
            // 
            this.viewReportsToolStripMenuItem1.Name = "viewReportsToolStripMenuItem1";
            this.viewReportsToolStripMenuItem1.Size = new System.Drawing.Size(172, 26);
            this.viewReportsToolStripMenuItem1.Text = "View Reports";
            this.viewReportsToolStripMenuItem1.Click += new System.EventHandler(this.viewReportsToolStripMenuItem1_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeThemeToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeThemeToolStripMenuItem
            // 
            this.changeThemeToolStripMenuItem.Name = "changeThemeToolStripMenuItem";
            this.changeThemeToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.changeThemeToolStripMenuItem.Text = "Change Theme";
            this.changeThemeToolStripMenuItem.Click += new System.EventHandler(this.changeThemeToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Helplbl);
            this.panel1.Controls.Add(this.Logoutlb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1368, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 102);
            this.panel1.TabIndex = 17;
            // 
            // Helplbl
            // 
            this.Helplbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Helplbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Helplbl.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.Helplbl.IconColor = System.Drawing.Color.Black;
            this.Helplbl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Helplbl.IconSize = 20;
            this.Helplbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Helplbl.Location = new System.Drawing.Point(2, 66);
            this.Helplbl.Name = "Helplbl";
            this.Helplbl.Size = new System.Drawing.Size(113, 35);
            this.Helplbl.TabIndex = 22;
            this.Helplbl.Text = "Help";
            this.Helplbl.UseVisualStyleBackColor = true;
            // 
            // Logoutlb
            // 
            this.Logoutlb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logoutlb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logoutlb.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.Logoutlb.IconColor = System.Drawing.Color.Black;
            this.Logoutlb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Logoutlb.IconSize = 20;
            this.Logoutlb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Logoutlb.Location = new System.Drawing.Point(150, 67);
            this.Logoutlb.Name = "Logoutlb";
            this.Logoutlb.Size = new System.Drawing.Size(113, 35);
            this.Logoutlb.TabIndex = 23;
            this.Logoutlb.Text = "Log Out";
            this.Logoutlb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logoutlb.UseVisualStyleBackColor = true;
            this.Logoutlb.Click += new System.EventHandler(this.Logoutlb_Click);
            // 
            // homeicon
            // 
            this.homeicon.BackColor = System.Drawing.Color.Transparent;
            this.homeicon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeicon.Image = global::POIS1.Properties.Resources.home;
            this.homeicon.Location = new System.Drawing.Point(21, 112);
            this.homeicon.Name = "homeicon";
            this.homeicon.Size = new System.Drawing.Size(23, 23);
            this.homeicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeicon.TabIndex = 7;
            this.homeicon.TabStop = false;
            // 
            // poislogo
            // 
            this.poislogo.BackColor = System.Drawing.Color.DimGray;
            this.poislogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poislogo.Image = global::POIS1.Properties.Resources.POIS_Final_;
            this.poislogo.Location = new System.Drawing.Point(0, 102);
            this.poislogo.Name = "poislogo";
            this.poislogo.Size = new System.Drawing.Size(1632, 801);
            this.poislogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.poislogo.TabIndex = 106;
            this.poislogo.TabStop = false;
            // 
            // VenderNamelbl
            // 
            this.VenderNamelbl.AutoSize = true;
            this.VenderNamelbl.BackColor = System.Drawing.Color.DimGray;
            this.VenderNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenderNamelbl.Location = new System.Drawing.Point(49, 176);
            this.VenderNamelbl.Name = "VenderNamelbl";
            this.VenderNamelbl.Size = new System.Drawing.Size(163, 20);
            this.VenderNamelbl.TabIndex = 107;
            this.VenderNamelbl.Text = "Generate Report By:";
            // 
            // GenerateReportcb
            // 
            this.GenerateReportcb.FormattingEnabled = true;
            this.GenerateReportcb.Items.AddRange(new object[] {
            "View Purchases",
            "View Invoices"});
            this.GenerateReportcb.Location = new System.Drawing.Point(283, 176);
            this.GenerateReportcb.Name = "GenerateReportcb";
            this.GenerateReportcb.Size = new System.Drawing.Size(216, 24);
            this.GenerateReportcb.TabIndex = 109;
            this.GenerateReportcb.SelectedIndexChanged += new System.EventHandler(this.GenerateReportcb_SelectedIndexChanged);
            // 
            // ReportGridView
            // 
            this.ReportGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ReportGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ReportGridView.BackgroundColor = System.Drawing.Color.DimGray;
            this.ReportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportGridView.Location = new System.Drawing.Point(43, 271);
            this.ReportGridView.Name = "ReportGridView";
            this.ReportGridView.RowHeadersWidth = 51;
            this.ReportGridView.RowTemplate.Height = 24;
            this.ReportGridView.Size = new System.Drawing.Size(1518, 488);
            this.ReportGridView.TabIndex = 110;
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.Refreshbtn.FlatAppearance.BorderSize = 0;
            this.Refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refreshbtn.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.Refreshbtn.IconColor = System.Drawing.Color.White;
            this.Refreshbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Refreshbtn.IconSize = 18;
            this.Refreshbtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Refreshbtn.Location = new System.Drawing.Point(596, 171);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(111, 28);
            this.Refreshbtn.TabIndex = 111;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Refreshbtn.UseVisualStyleBackColor = false;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchbtn.IconColor = System.Drawing.Color.White;
            this.searchbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchbtn.IconSize = 14;
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbtn.Location = new System.Drawing.Point(789, 171);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(126, 28);
            this.searchbtn.TabIndex = 130;
            this.searchbtn.Text = "        Search ";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchicon
            // 
            this.searchicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.searchicon.FlatAppearance.BorderSize = 0;
            this.searchicon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchicon.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchicon.IconColor = System.Drawing.Color.White;
            this.searchicon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchicon.IconSize = 16;
            this.searchicon.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchicon.Location = new System.Drawing.Point(789, 171);
            this.searchicon.Name = "searchicon";
            this.searchicon.Size = new System.Drawing.Size(31, 28);
            this.searchicon.TabIndex = 131;
            this.searchicon.UseVisualStyleBackColor = false;
            this.searchicon.Click += new System.EventHandler(this.searchicon_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 903);
            this.Controls.Add(this.searchicon);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.Refreshbtn);
            this.Controls.Add(this.ReportGridView);
            this.Controls.Add(this.GenerateReportcb);
            this.Controls.Add(this.VenderNamelbl);
            this.Controls.Add(this.poislogo);
            this.Controls.Add(this.toppanel);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poispB)).EndInit();
            this.ViewsMenue.ResumeLayout(false);
            this.ViewsMenue.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poislogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.PictureBox poispB;
        private System.Windows.Forms.MenuStrip ViewsMenue;
        private System.Windows.Forms.ToolStripMenuItem viewInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInvoicesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewPurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logPurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPurchaseOrderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Logoutlb;
        private System.Windows.Forms.PictureBox homeicon;
        private System.Windows.Forms.PictureBox poislogo;
        private System.Windows.Forms.Label VenderNamelbl;
        private System.Windows.Forms.ComboBox GenerateReportcb;
        private System.Windows.Forms.DataGridView ReportGridView;
        private FontAwesome.Sharp.IconButton Refreshbtn;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton Reportbtn;
        private FontAwesome.Sharp.IconButton Calculationbtn;
        private FontAwesome.Sharp.IconButton LogInvbtn;
        private FontAwesome.Sharp.IconButton LogPObtn;
        private FontAwesome.Sharp.IconButton Homebtn;
        private FontAwesome.Sharp.IconButton Helplbl;
        private FontAwesome.Sharp.IconButton searchbtn;
        private FontAwesome.Sharp.IconButton searchicon;
    }
}
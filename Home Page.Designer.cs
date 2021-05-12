
namespace POIS1
{
    partial class Home_Page
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
            this.Viewinvoicesbt = new System.Windows.Forms.Button();
            this.ViewPurchaserOrderbtn = new System.Windows.Forms.Button();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.toppanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.settingsicon = new System.Windows.Forms.PictureBox();
            this.helplbl = new System.Windows.Forms.Label();
            this.helplogo = new System.Windows.Forms.PictureBox();
            this.Logouticon = new System.Windows.Forms.PictureBox();
            this.Logoutlb = new System.Windows.Forms.Label();
            this.poispB = new System.Windows.Forms.PictureBox();
            this.homeicon = new System.Windows.Forms.PictureBox();
            this.Homebtn = new System.Windows.Forms.Button();
            this.LogPObtn = new System.Windows.Forms.Button();
            this.LogInvbtn = new System.Windows.Forms.Button();
            this.Calculationbtn = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingspanel = new System.Windows.Forms.Panel();
            this.themebtn = new System.Windows.Forms.Button();
            this.middlepanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.poislogo = new System.Windows.Forms.PictureBox();
            this.toppanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helplogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logouticon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poispB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeicon)).BeginInit();
            this.ViewsMenue.SuspendLayout();
            this.panel1.SuspendLayout();
            this.settingspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poislogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Viewinvoicesbt
            // 
            this.Viewinvoicesbt.BackColor = System.Drawing.Color.White;
            this.Viewinvoicesbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Viewinvoicesbt.Location = new System.Drawing.Point(275, 346);
            this.Viewinvoicesbt.Name = "Viewinvoicesbt";
            this.Viewinvoicesbt.Size = new System.Drawing.Size(224, 91);
            this.Viewinvoicesbt.TabIndex = 9;
            this.Viewinvoicesbt.Text = "View Invoices";
            this.Viewinvoicesbt.UseVisualStyleBackColor = false;
            this.Viewinvoicesbt.Click += new System.EventHandler(this.Viewinvoicesbt_Click);
            // 
            // ViewPurchaserOrderbtn
            // 
            this.ViewPurchaserOrderbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewPurchaserOrderbtn.BackColor = System.Drawing.Color.White;
            this.ViewPurchaserOrderbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewPurchaserOrderbtn.Location = new System.Drawing.Point(1210, 346);
            this.ViewPurchaserOrderbtn.Name = "ViewPurchaserOrderbtn";
            this.ViewPurchaserOrderbtn.Size = new System.Drawing.Size(225, 91);
            this.ViewPurchaserOrderbtn.TabIndex = 10;
            this.ViewPurchaserOrderbtn.Text = "View Purchase Order";
            this.ViewPurchaserOrderbtn.UseVisualStyleBackColor = false;
            this.ViewPurchaserOrderbtn.Click += new System.EventHandler(this.ViewPurchaserOrderbtn_Click);
            // 
            // searchtb
            // 
            this.searchtb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchtb.AutoCompleteCustomSource.AddRange(new string[] {
            "Log Purchase Order",
            "Log Invoice",
            "Calculation",
            "View Invoices",
            "View Purchase Order",
            "Generate Report"});
            this.searchtb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchtb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtb.ForeColor = System.Drawing.Color.LightGray;
            this.searchtb.Location = new System.Drawing.Point(1100, 144);
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(210, 30);
            this.searchtb.TabIndex = 15;
            this.searchtb.Text = "Search...";
            this.searchtb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchtb_MouseClick);
            this.searchtb.MouseLeave += new System.EventHandler(this.searchtb_MouseLeave);
            this.searchtb.MouseHover += new System.EventHandler(this.searchtb_MouseHover);
            // 
            // Searchbtn
            // 
            this.Searchbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Searchbtn.Location = new System.Drawing.Point(1307, 144);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(139, 31);
            this.Searchbtn.TabIndex = 16;
            this.Searchbtn.Text = "SEARCH";
            this.Searchbtn.UseVisualStyleBackColor = false;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.toppanel.Controls.Add(this.panel2);
            this.toppanel.Controls.Add(this.poispB);
            this.toppanel.Controls.Add(this.homeicon);
            this.toppanel.Controls.Add(this.Homebtn);
            this.toppanel.Controls.Add(this.LogPObtn);
            this.toppanel.Controls.Add(this.LogInvbtn);
            this.toppanel.Controls.Add(this.Calculationbtn);
            this.toppanel.Controls.Add(this.ViewsMenue);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1632, 102);
            this.toppanel.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.settingsicon);
            this.panel2.Controls.Add(this.helplbl);
            this.panel2.Controls.Add(this.helplogo);
            this.panel2.Controls.Add(this.Logouticon);
            this.panel2.Controls.Add(this.Logoutlb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1368, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 74);
            this.panel2.TabIndex = 17;
            // 
            // settingsicon
            // 
            this.settingsicon.BackColor = System.Drawing.Color.Transparent;
            this.settingsicon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsicon.Image = global::POIS1.Properties.Resources.img_272299;
            this.settingsicon.Location = new System.Drawing.Point(214, 41);
            this.settingsicon.Name = "settingsicon";
            this.settingsicon.Size = new System.Drawing.Size(38, 22);
            this.settingsicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsicon.TabIndex = 12;
            this.settingsicon.TabStop = false;
            this.settingsicon.Click += new System.EventHandler(this.settingsicon_Click);
            // 
            // helplbl
            // 
            this.helplbl.AutoSize = true;
            this.helplbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helplbl.Location = new System.Drawing.Point(3, 41);
            this.helplbl.Name = "helplbl";
            this.helplbl.Size = new System.Drawing.Size(35, 18);
            this.helplbl.TabIndex = 8;
            this.helplbl.Text = "help";
            this.helplbl.Click += new System.EventHandler(this.helplbl_Click);
            // 
            // helplogo
            // 
            this.helplogo.BackColor = System.Drawing.Color.Transparent;
            this.helplogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helplogo.Image = global::POIS1.Properties.Resources.R5b442441defbdc85231d35d7a7f7619c;
            this.helplogo.Location = new System.Drawing.Point(48, 43);
            this.helplogo.Name = "helplogo";
            this.helplogo.Size = new System.Drawing.Size(19, 18);
            this.helplogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.helplogo.TabIndex = 9;
            this.helplogo.TabStop = false;
            this.helplogo.Click += new System.EventHandler(this.helplogo_Click);
            // 
            // Logouticon
            // 
            this.Logouticon.BackColor = System.Drawing.Color.Transparent;
            this.Logouticon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logouticon.Image = global::POIS1.Properties.Resources.logout_512;
            this.Logouticon.Location = new System.Drawing.Point(165, 41);
            this.Logouticon.Name = "Logouticon";
            this.Logouticon.Size = new System.Drawing.Size(38, 22);
            this.Logouticon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logouticon.TabIndex = 11;
            this.Logouticon.TabStop = false;
            this.Logouticon.Click += new System.EventHandler(this.Logouticon_Click);
            // 
            // Logoutlb
            // 
            this.Logoutlb.AutoSize = true;
            this.Logoutlb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logoutlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutlb.Location = new System.Drawing.Point(100, 41);
            this.Logoutlb.Name = "Logoutlb";
            this.Logoutlb.Size = new System.Drawing.Size(54, 18);
            this.Logoutlb.TabIndex = 10;
            this.Logoutlb.Text = "Logout";
            this.Logoutlb.Click += new System.EventHandler(this.Logoutlb_Click);
            // 
            // poispB
            // 
            this.poispB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.poispB.Image = global::POIS1.Properties.Resources.POIS_white_;
            this.poispB.Location = new System.Drawing.Point(708, 1);
            this.poispB.Name = "poispB";
            this.poispB.Size = new System.Drawing.Size(138, 55);
            this.poispB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.poispB.TabIndex = 16;
            this.poispB.TabStop = false;
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
            this.homeicon.Click += new System.EventHandler(this.homeicon_Click);
            // 
            // Homebtn
            // 
            this.Homebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.Homebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Homebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homebtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Homebtn.Location = new System.Drawing.Point(3, 62);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(139, 46);
            this.Homebtn.TabIndex = 6;
            this.Homebtn.Text = "Home";
            this.Homebtn.UseVisualStyleBackColor = false;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // LogPObtn
            // 
            this.LogPObtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.LogPObtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogPObtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogPObtn.Location = new System.Drawing.Point(209, 62);
            this.LogPObtn.Name = "LogPObtn";
            this.LogPObtn.Size = new System.Drawing.Size(150, 46);
            this.LogPObtn.TabIndex = 1;
            this.LogPObtn.Text = "Log Purchase Order";
            this.LogPObtn.UseVisualStyleBackColor = false;
            this.LogPObtn.Click += new System.EventHandler(this.LogPObtn_Click);
            // 
            // LogInvbtn
            // 
            this.LogInvbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.LogInvbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInvbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInvbtn.Location = new System.Drawing.Point(411, 62);
            this.LogInvbtn.Name = "LogInvbtn";
            this.LogInvbtn.Size = new System.Drawing.Size(140, 46);
            this.LogInvbtn.TabIndex = 2;
            this.LogInvbtn.Text = "Log Invoice";
            this.LogInvbtn.UseVisualStyleBackColor = false;
            this.LogInvbtn.Click += new System.EventHandler(this.LogInvbtn_Click);
            // 
            // Calculationbtn
            // 
            this.Calculationbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.Calculationbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculationbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculationbtn.Location = new System.Drawing.Point(613, 62);
            this.Calculationbtn.Name = "Calculationbtn";
            this.Calculationbtn.Size = new System.Drawing.Size(139, 46);
            this.Calculationbtn.TabIndex = 3;
            this.Calculationbtn.Text = "Calculation";
            this.Calculationbtn.UseVisualStyleBackColor = false;
            this.Calculationbtn.Click += new System.EventHandler(this.Calculationbtn_Click);
            // 
            // ViewsMenue
            // 
            this.ViewsMenue.BackColor = System.Drawing.Color.Transparent;
            this.ViewsMenue.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ViewsMenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInvoicesToolStripMenuItem,
            this.viewPurchaseOrderToolStripMenuItem,
            this.viewReportsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.ViewsMenue.Location = new System.Drawing.Point(0, 0);
            this.ViewsMenue.Name = "ViewsMenue";
            this.ViewsMenue.Size = new System.Drawing.Size(1632, 28);
            this.ViewsMenue.TabIndex = 18;
            this.ViewsMenue.Text = "menuStrip1";
            // 
            // viewInvoicesToolStripMenuItem
            // 
            this.viewInvoicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInvoicesToolStripMenuItem,
            this.viewInvoicesToolStripMenuItem1});
            this.viewInvoicesToolStripMenuItem.Name = "viewInvoicesToolStripMenuItem";
            this.viewInvoicesToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.viewInvoicesToolStripMenuItem.Text = "Invoices";
            // 
            // logInvoicesToolStripMenuItem
            // 
            this.logInvoicesToolStripMenuItem.Name = "logInvoicesToolStripMenuItem";
            this.logInvoicesToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.logInvoicesToolStripMenuItem.Text = "Log Invoices";
            this.logInvoicesToolStripMenuItem.Click += new System.EventHandler(this.logInvoicesToolStripMenuItem_Click);
            // 
            // viewInvoicesToolStripMenuItem1
            // 
            this.viewInvoicesToolStripMenuItem1.Name = "viewInvoicesToolStripMenuItem1";
            this.viewInvoicesToolStripMenuItem1.Size = new System.Drawing.Size(193, 26);
            this.viewInvoicesToolStripMenuItem1.Text = "View Invoices";
            this.viewInvoicesToolStripMenuItem1.Click += new System.EventHandler(this.viewInvoicesToolStripMenuItem1_Click);
            // 
            // viewPurchaseOrderToolStripMenuItem
            // 
            this.viewPurchaseOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logPurchaseOrderToolStripMenuItem,
            this.viewPurchaseOrderToolStripMenuItem1});
            this.viewPurchaseOrderToolStripMenuItem.Name = "viewPurchaseOrderToolStripMenuItem";
            this.viewPurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.viewPurchaseOrderToolStripMenuItem.Text = "Purchase Order";
            // 
            // logPurchaseOrderToolStripMenuItem
            // 
            this.logPurchaseOrderToolStripMenuItem.Name = "logPurchaseOrderToolStripMenuItem";
            this.logPurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.logPurchaseOrderToolStripMenuItem.Text = "Log Purchase Order";
            this.logPurchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.logPurchaseOrderToolStripMenuItem_Click);
            // 
            // viewPurchaseOrderToolStripMenuItem1
            // 
            this.viewPurchaseOrderToolStripMenuItem1.Name = "viewPurchaseOrderToolStripMenuItem1";
            this.viewPurchaseOrderToolStripMenuItem1.Size = new System.Drawing.Size(240, 26);
            this.viewPurchaseOrderToolStripMenuItem1.Text = "View Purchase Order";
            this.viewPurchaseOrderToolStripMenuItem1.Click += new System.EventHandler(this.viewPurchaseOrderToolStripMenuItem1_Click);
            // 
            // viewReportsToolStripMenuItem
            // 
            this.viewReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReportsToolStripMenuItem1});
            this.viewReportsToolStripMenuItem.Name = "viewReportsToolStripMenuItem";
            this.viewReportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.viewReportsToolStripMenuItem.Text = "Reports";
            // 
            // viewReportsToolStripMenuItem1
            // 
            this.viewReportsToolStripMenuItem1.Name = "viewReportsToolStripMenuItem1";
            this.viewReportsToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.viewReportsToolStripMenuItem1.Text = "View Reports";
            this.viewReportsToolStripMenuItem1.Click += new System.EventHandler(this.viewReportsToolStripMenuItem1_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeThemeToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeThemeToolStripMenuItem
            // 
            this.changeThemeToolStripMenuItem.Name = "changeThemeToolStripMenuItem";
            this.changeThemeToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.changeThemeToolStripMenuItem.Text = "Change Theme";
            this.changeThemeToolStripMenuItem.Click += new System.EventHandler(this.changeThemeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.settingspanel);
            this.panel1.Controls.Add(this.searchtb);
            this.panel1.Controls.Add(this.Searchbtn);
            this.panel1.Controls.Add(this.middlepanel);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.ViewPurchaserOrderbtn);
            this.panel1.Controls.Add(this.Viewinvoicesbt);
            this.panel1.Controls.Add(this.poislogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1632, 792);
            this.panel1.TabIndex = 0;
            // 
            // settingspanel
            // 
            this.settingspanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingspanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.settingspanel.Controls.Add(this.themebtn);
            this.settingspanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingspanel.Location = new System.Drawing.Point(1508, 101);
            this.settingspanel.Name = "settingspanel";
            this.settingspanel.Size = new System.Drawing.Size(124, 45);
            this.settingspanel.TabIndex = 23;
            // 
            // themebtn
            // 
            this.themebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.themebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.themebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.themebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themebtn.Location = new System.Drawing.Point(0, 0);
            this.themebtn.Name = "themebtn";
            this.themebtn.Size = new System.Drawing.Size(124, 45);
            this.themebtn.TabIndex = 19;
            this.themebtn.Text = "Change Theme";
            this.themebtn.UseVisualStyleBackColor = false;
            this.themebtn.Click += new System.EventHandler(this.themebtn_Click);
            // 
            // middlepanel
            // 
            this.middlepanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.middlepanel.Location = new System.Drawing.Point(901, 93);
            this.middlepanel.Name = "middlepanel";
            this.middlepanel.Size = new System.Drawing.Size(1, 680);
            this.middlepanel.TabIndex = 19;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::POIS1.Properties.Resources.Files;
            this.pictureBox4.Location = new System.Drawing.Point(1392, 383);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::POIS1.Properties.Resources.Files;
            this.pictureBox3.Location = new System.Drawing.Point(437, 383);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // poislogo
            // 
            this.poislogo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.poislogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poislogo.Image = global::POIS1.Properties.Resources.POIS_Final_;
            this.poislogo.Location = new System.Drawing.Point(0, 0);
            this.poislogo.Name = "poislogo";
            this.poislogo.Size = new System.Drawing.Size(1632, 792);
            this.poislogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.poislogo.TabIndex = 4;
            this.poislogo.TabStop = false;
            this.poislogo.Click += new System.EventHandler(this.poislogo_Click);
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1632, 792);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Home_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home_Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Page_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helplogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logouticon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poispB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeicon)).EndInit();
            this.ViewsMenue.ResumeLayout(false);
            this.ViewsMenue.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.settingspanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poislogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Viewinvoicesbt;
        private System.Windows.Forms.Button ViewPurchaserOrderbtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox searchtb;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label helplbl;
        private System.Windows.Forms.PictureBox helplogo;
        private System.Windows.Forms.PictureBox Logouticon;
        private System.Windows.Forms.Label Logoutlb;
        private System.Windows.Forms.PictureBox poispB;
        private System.Windows.Forms.PictureBox homeicon;
        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.Button LogInvbtn;
        private System.Windows.Forms.Button Calculationbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox settingsicon;
        private System.Windows.Forms.Panel middlepanel;
        private System.Windows.Forms.Panel settingspanel;
        private System.Windows.Forms.Button themebtn;
        private System.Windows.Forms.MenuStrip ViewsMenue;
        private System.Windows.Forms.ToolStripMenuItem viewInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInvoicesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewPurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logPurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPurchaseOrderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem1;
        private System.Windows.Forms.PictureBox poislogo;
        private System.Windows.Forms.Button LogPObtn;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeThemeToolStripMenuItem;
    }
}
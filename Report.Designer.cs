
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
            this.components = new System.ComponentModel.Container();
            this.poislogo = new System.Windows.Forms.PictureBox();
            this.settingspanel = new System.Windows.Forms.Panel();
            this.maximisebtn = new System.Windows.Forms.Button();
            this.minimisebtn = new System.Windows.Forms.Button();
            this.themebtn = new System.Windows.Forms.Button();
            this.generatereportlb = new System.Windows.Forms.Label();
            this.Reportlb = new System.Windows.Forms.Label();
            this.Yearlycb = new System.Windows.Forms.ComboBox();
            this.logPurchaseOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOISDataSet = new POIS1.POISDataSet();
            this.generatebutton = new System.Windows.Forms.Button();
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
            this.Reportbtn = new System.Windows.Forms.Button();
            this.ViewsMenue = new System.Windows.Forms.MenuStrip();
            this.viewInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInvoicesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logPurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPurchaseOrderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.logPurchaseOrderTableAdapter = new POIS1.POISDataSetTableAdapters.LogPurchaseOrderTableAdapter();
            this.LPOdataview = new System.Windows.Forms.DataGridView();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.poislogo)).BeginInit();
            this.settingspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logPurchaseOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOISDataSet)).BeginInit();
            this.toppanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helplogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logouticon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poispB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeicon)).BeginInit();
            this.ViewsMenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LPOdataview)).BeginInit();
            this.SuspendLayout();
            // 
            // poislogo
            // 
            this.poislogo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.poislogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poislogo.Image = global::POIS1.Properties.Resources.POIS_Final_;
            this.poislogo.Location = new System.Drawing.Point(0, 0);
            this.poislogo.Name = "poislogo";
            this.poislogo.Size = new System.Drawing.Size(1627, 792);
            this.poislogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.poislogo.TabIndex = 21;
            this.poislogo.TabStop = false;
            // 
            // settingspanel
            // 
            this.settingspanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingspanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.settingspanel.Controls.Add(this.maximisebtn);
            this.settingspanel.Controls.Add(this.minimisebtn);
            this.settingspanel.Controls.Add(this.themebtn);
            this.settingspanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingspanel.Location = new System.Drawing.Point(1503, 102);
            this.settingspanel.Name = "settingspanel";
            this.settingspanel.Size = new System.Drawing.Size(124, 109);
            this.settingspanel.TabIndex = 40;
            // 
            // maximisebtn
            // 
            this.maximisebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.maximisebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.maximisebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximisebtn.Location = new System.Drawing.Point(0, 72);
            this.maximisebtn.Name = "maximisebtn";
            this.maximisebtn.Size = new System.Drawing.Size(124, 37);
            this.maximisebtn.TabIndex = 23;
            this.maximisebtn.Text = "Maximise";
            this.maximisebtn.UseVisualStyleBackColor = false;
            // 
            // minimisebtn
            // 
            this.minimisebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.minimisebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.minimisebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimisebtn.Location = new System.Drawing.Point(0, 36);
            this.minimisebtn.Name = "minimisebtn";
            this.minimisebtn.Size = new System.Drawing.Size(124, 37);
            this.minimisebtn.TabIndex = 22;
            this.minimisebtn.Text = "Minimise";
            this.minimisebtn.UseVisualStyleBackColor = false;
            // 
            // themebtn
            // 
            this.themebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.themebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.themebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themebtn.Location = new System.Drawing.Point(0, -9);
            this.themebtn.Name = "themebtn";
            this.themebtn.Size = new System.Drawing.Size(124, 46);
            this.themebtn.TabIndex = 20;
            this.themebtn.Text = "Change Theme";
            this.themebtn.UseVisualStyleBackColor = false;
            this.themebtn.Click += new System.EventHandler(this.themebtn_Click);
            // 
            // generatereportlb
            // 
            this.generatereportlb.AutoSize = true;
            this.generatereportlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatereportlb.Location = new System.Drawing.Point(209, 193);
            this.generatereportlb.Name = "generatereportlb";
            this.generatereportlb.Size = new System.Drawing.Size(240, 32);
            this.generatereportlb.TabIndex = 41;
            this.generatereportlb.Text = "Generate Reports";
            // 
            // Reportlb
            // 
            this.Reportlb.AutoSize = true;
            this.Reportlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportlb.ForeColor = System.Drawing.Color.Black;
            this.Reportlb.Location = new System.Drawing.Point(252, 260);
            this.Reportlb.Name = "Reportlb";
            this.Reportlb.Size = new System.Drawing.Size(212, 25);
            this.Reportlb.TabIndex = 42;
            this.Reportlb.Text = "Purchase Order Report";
            // 
            // Yearlycb
            // 
            this.Yearlycb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.logPurchaseOrderBindingSource, "Approval_Date", true));
            this.Yearlycb.DataSource = this.logPurchaseOrderBindingSource;
            this.Yearlycb.DisplayMember = "PurchaseOrderNumber";
            this.Yearlycb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Yearlycb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yearlycb.FormattingEnabled = true;
            this.Yearlycb.Location = new System.Drawing.Point(512, 255);
            this.Yearlycb.Name = "Yearlycb";
            this.Yearlycb.Size = new System.Drawing.Size(227, 30);
            this.Yearlycb.TabIndex = 43;
            this.Yearlycb.ValueMember = "Approval_Date";
            this.Yearlycb.SelectedIndexChanged += new System.EventHandler(this.Yearlycb_SelectedIndexChanged);
            // 
            // logPurchaseOrderBindingSource
            // 
            this.logPurchaseOrderBindingSource.DataMember = "LogPurchaseOrder";
            this.logPurchaseOrderBindingSource.DataSource = this.pOISDataSet;
            // 
            // pOISDataSet
            // 
            this.pOISDataSet.DataSetName = "POISDataSet";
            this.pOISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generatebutton
            // 
            this.generatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.generatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatebutton.Location = new System.Drawing.Point(613, 646);
            this.generatebutton.Name = "generatebutton";
            this.generatebutton.Size = new System.Drawing.Size(90, 34);
            this.generatebutton.TabIndex = 82;
            this.generatebutton.Text = "Generate";
            this.generatebutton.UseVisualStyleBackColor = false;
            this.generatebutton.Click += new System.EventHandler(this.generatebutton_Click);
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
            this.toppanel.Controls.Add(this.Reportbtn);
            this.toppanel.Controls.Add(this.ViewsMenue);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1627, 102);
            this.toppanel.TabIndex = 83;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.settingsicon);
            this.panel2.Controls.Add(this.helplbl);
            this.panel2.Controls.Add(this.helplogo);
            this.panel2.Controls.Add(this.Logouticon);
            this.panel2.Controls.Add(this.Logoutlb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1363, 28);
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
            this.helplbl.Click += new System.EventHandler(this.hlplbl_Click);
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
            this.helplogo.Click += new System.EventHandler(this.help_Click);
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
            this.Logouticon.Click += new System.EventHandler(this.logOicon_Click);
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
            this.Logoutlb.Click += new System.EventHandler(this.logoutlbl_Click);
            // 
            // poispB
            // 
            this.poispB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.poispB.Image = global::POIS1.Properties.Resources.POIS_white_;
            this.poispB.Location = new System.Drawing.Point(705, 1);
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
            this.LogPObtn.Click += new System.EventHandler(this.LogPObtn_Click_1);
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
            // Reportbtn
            // 
            this.Reportbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.Reportbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Reportbtn.Location = new System.Drawing.Point(808, 62);
            this.Reportbtn.Name = "Reportbtn";
            this.Reportbtn.Size = new System.Drawing.Size(140, 46);
            this.Reportbtn.TabIndex = 5;
            this.Reportbtn.Text = "Report";
            this.Reportbtn.UseVisualStyleBackColor = false;
            this.Reportbtn.Click += new System.EventHandler(this.Reportbtn_Click);
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
            this.ViewsMenue.Size = new System.Drawing.Size(1627, 28);
            this.ViewsMenue.TabIndex = 18;
            this.ViewsMenue.Text = "menuStrip1";
            // 
            // viewInvoicesToolStripMenuItem
            // 
            this.viewInvoicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInvoicesToolStripMenuItem,
            this.viewInvoicesToolStripMenuItem1,
            this.deleteInvoicesToolStripMenuItem});
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
            // deleteInvoicesToolStripMenuItem
            // 
            this.deleteInvoicesToolStripMenuItem.Name = "deleteInvoicesToolStripMenuItem";
            this.deleteInvoicesToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.deleteInvoicesToolStripMenuItem.Text = "Delete Invoices";
            // 
            // viewPurchaseOrderToolStripMenuItem
            // 
            this.viewPurchaseOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logPurchaseOrderToolStripMenuItem,
            this.viewPurchaseOrderToolStripMenuItem1,
            this.deletePurchaseOrderToolStripMenuItem});
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
            // deletePurchaseOrderToolStripMenuItem
            // 
            this.deletePurchaseOrderToolStripMenuItem.Name = "deletePurchaseOrderToolStripMenuItem";
            this.deletePurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.deletePurchaseOrderToolStripMenuItem.Text = "Delete Purchase Order";
            // 
            // viewReportsToolStripMenuItem
            // 
            this.viewReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReportsToolStripMenuItem,
            this.viewReportsToolStripMenuItem1});
            this.viewReportsToolStripMenuItem.Name = "viewReportsToolStripMenuItem";
            this.viewReportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.viewReportsToolStripMenuItem.Text = "Reports";
            // 
            // addReportsToolStripMenuItem
            // 
            this.addReportsToolStripMenuItem.Name = "addReportsToolStripMenuItem";
            this.addReportsToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.addReportsToolStripMenuItem.Text = "Add Reports";
            // 
            // viewReportsToolStripMenuItem1
            // 
            this.viewReportsToolStripMenuItem1.Name = "viewReportsToolStripMenuItem1";
            this.viewReportsToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.viewReportsToolStripMenuItem1.Text = "View Reports";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(252, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 84;
            this.label1.Text = "Invoice Report";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Monthly",
            "Yearly"});
            this.comboBox1.Location = new System.Drawing.Point(512, 387);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 30);
            this.comboBox1.TabIndex = 85;
            // 
            // logPurchaseOrderTableAdapter
            // 
            this.logPurchaseOrderTableAdapter.ClearBeforeFill = true;
            // 
            // LPOdataview
            // 
            this.LPOdataview.AllowUserToAddRows = false;
            this.LPOdataview.AllowUserToDeleteRows = false;
            this.LPOdataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LPOdataview.Location = new System.Drawing.Point(761, 255);
            this.LPOdataview.Name = "LPOdataview";
            this.LPOdataview.ReadOnly = true;
            this.LPOdataview.RowHeadersWidth = 51;
            this.LPOdataview.RowTemplate.Height = 24;
            this.LPOdataview.Size = new System.Drawing.Size(1266, 514);
            this.LPOdataview.TabIndex = 86;
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1627, 792);
            this.Controls.Add(this.LPOdataview);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.generatebutton);
            this.Controls.Add(this.Yearlycb);
            this.Controls.Add(this.Reportlb);
            this.Controls.Add(this.generatereportlb);
            this.Controls.Add(this.settingspanel);
            this.Controls.Add(this.poislogo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Report";
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poislogo)).EndInit();
            this.settingspanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logPurchaseOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOISDataSet)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.LPOdataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox poislogo;
        private System.Windows.Forms.Panel settingspanel;
        private System.Windows.Forms.Button maximisebtn;
        private System.Windows.Forms.Button minimisebtn;
        private System.Windows.Forms.Button themebtn;
        private System.Windows.Forms.Label generatereportlb;
        private System.Windows.Forms.Label Reportlb;
        private System.Windows.Forms.ComboBox Yearlycb;
        private System.Windows.Forms.Button generatebutton;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox settingsicon;
        private System.Windows.Forms.Label helplbl;
        private System.Windows.Forms.PictureBox helplogo;
        private System.Windows.Forms.PictureBox Logouticon;
        private System.Windows.Forms.Label Logoutlb;
        private System.Windows.Forms.PictureBox poispB;
        private System.Windows.Forms.PictureBox homeicon;
        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.Button LogPObtn;
        private System.Windows.Forms.Button LogInvbtn;
        private System.Windows.Forms.Button Calculationbtn;
        private System.Windows.Forms.Button Reportbtn;
        private System.Windows.Forms.MenuStrip ViewsMenue;
        private System.Windows.Forms.ToolStripMenuItem viewInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInvoicesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logPurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPurchaseOrderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deletePurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeThemeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private POISDataSet pOISDataSet;
        private System.Windows.Forms.BindingSource logPurchaseOrderBindingSource;
        private POISDataSetTableAdapters.LogPurchaseOrderTableAdapter logPurchaseOrderTableAdapter;
        private System.Windows.Forms.DataGridView LPOdataview;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}
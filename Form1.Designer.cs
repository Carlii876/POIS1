
namespace POIS1
{
    partial class POIS
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
            this.usernametb = new System.Windows.Forms.TextBox();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PurchaseOrderLbl = new System.Windows.Forms.Label();
            this.Heartlogo = new System.Windows.Forms.PictureBox();
            this.passwordicon = new System.Windows.Forms.PictureBox();
            this.usericon = new System.Windows.Forms.PictureBox();
            this.forgetPbtn = new System.Windows.Forms.Label();
            this.usernameerror = new System.Windows.Forms.Label();
            this.Passworderror = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Loginbtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.eyeicon = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heartlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usericon)).BeginInit();
            this.SuspendLayout();
            // 
            // usernametb
            // 
            this.usernametb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametb.ForeColor = System.Drawing.Color.Black;
            this.usernametb.Location = new System.Drawing.Point(173, 273);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(214, 23);
            this.usernametb.TabIndex = 9;
            this.usernametb.Text = "Username";
            this.usernametb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usernametb_MouseClick);
            this.usernametb.TextChanged += new System.EventHandler(this.usernametb_TextChanged);
            this.usernametb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernametb_KeyPress);
            this.usernametb.MouseLeave += new System.EventHandler(this.usernametb_MouseLeave);
            // 
            // passwordtb
            // 
            this.passwordtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtb.ForeColor = System.Drawing.Color.Black;
            this.passwordtb.Location = new System.Drawing.Point(173, 393);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(198, 23);
            this.passwordtb.TabIndex = 10;
            this.passwordtb.Text = "Enter Password";
            this.passwordtb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordtb_MouseClick);
            this.passwordtb.TextChanged += new System.EventHandler(this.passwordtb_TextChanged);
            this.passwordtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordtb_KeyPress);
            this.passwordtb.MouseLeave += new System.EventHandler(this.passwordtb_MouseLeave);
            this.passwordtb.MouseHover += new System.EventHandler(this.passwordtb_MouseHover);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.PurchaseOrderLbl);
            this.panel6.Controls.Add(this.Heartlogo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(496, 224);
            this.panel6.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POIS1.Properties.Resources.POIS_white_;
            this.pictureBox1.Location = new System.Drawing.Point(178, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PurchaseOrderLbl
            // 
            this.PurchaseOrderLbl.AutoSize = true;
            this.PurchaseOrderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PurchaseOrderLbl.ForeColor = System.Drawing.Color.White;
            this.PurchaseOrderLbl.Location = new System.Drawing.Point(74, 199);
            this.PurchaseOrderLbl.Name = "PurchaseOrderLbl";
            this.PurchaseOrderLbl.Size = new System.Drawing.Size(278, 20);
            this.PurchaseOrderLbl.TabIndex = 1;
            this.PurchaseOrderLbl.Text = "Purchase Order and Invoice System";
            // 
            // Heartlogo
            // 
            this.Heartlogo.BackColor = System.Drawing.Color.White;
            this.Heartlogo.Image = global::POIS1.Properties.Resources.HEART_NSTA_Trust___Logo;
            this.Heartlogo.Location = new System.Drawing.Point(169, 50);
            this.Heartlogo.Name = "Heartlogo";
            this.Heartlogo.Size = new System.Drawing.Size(147, 136);
            this.Heartlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Heartlogo.TabIndex = 0;
            this.Heartlogo.TabStop = false;
            // 
            // passwordicon
            // 
            this.passwordicon.Image = global::POIS1.Properties.Resources.Rb8a3bd2e5a36aaf1d25a99b06a4a0f0b;
            this.passwordicon.Location = new System.Drawing.Point(129, 388);
            this.passwordicon.Name = "passwordicon";
            this.passwordicon.Size = new System.Drawing.Size(35, 27);
            this.passwordicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordicon.TabIndex = 7;
            this.passwordicon.TabStop = false;
            // 
            // usericon
            // 
            this.usericon.Image = global::POIS1.Properties.Resources.user_icon_png_pnglogocom;
            this.usericon.Location = new System.Drawing.Point(129, 269);
            this.usericon.Name = "usericon";
            this.usericon.Size = new System.Drawing.Size(35, 27);
            this.usericon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usericon.TabIndex = 4;
            this.usericon.TabStop = false;
            // 
            // forgetPbtn
            // 
            this.forgetPbtn.AutoSize = true;
            this.forgetPbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgetPbtn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.forgetPbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.forgetPbtn.Location = new System.Drawing.Point(284, 459);
            this.forgetPbtn.Name = "forgetPbtn";
            this.forgetPbtn.Size = new System.Drawing.Size(112, 19);
            this.forgetPbtn.TabIndex = 17;
            this.forgetPbtn.Text = "Forgot Password";
            this.forgetPbtn.Click += new System.EventHandler(this.forgetPbtn_Click);
            this.forgetPbtn.MouseLeave += new System.EventHandler(this.forgetPbtn_MouseLeave);
            this.forgetPbtn.MouseHover += new System.EventHandler(this.forgetPbtn_MouseHover);
            // 
            // usernameerror
            // 
            this.usernameerror.AutoSize = true;
            this.usernameerror.ForeColor = System.Drawing.Color.Red;
            this.usernameerror.Location = new System.Drawing.Point(234, 249);
            this.usernameerror.Name = "usernameerror";
            this.usernameerror.Size = new System.Drawing.Size(0, 17);
            this.usernameerror.TabIndex = 19;
            // 
            // Passworderror
            // 
            this.Passworderror.AutoSize = true;
            this.Passworderror.ForeColor = System.Drawing.Color.Red;
            this.Passworderror.Location = new System.Drawing.Point(237, 375);
            this.Passworderror.Name = "Passworderror";
            this.Passworderror.Size = new System.Drawing.Size(0, 17);
            this.Passworderror.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(129, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 1);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(129, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 1);
            this.panel2.TabIndex = 22;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.Loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Loginbtn.IconColor = System.Drawing.Color.Black;
            this.Loginbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Loginbtn.Location = new System.Drawing.Point(216, 493);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(85, 33);
            this.Loginbtn.TabIndex = 23;
            this.Loginbtn.Text = "Log In";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.LogInbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(239, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Exit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // eyeicon
            // 
            this.eyeicon.BackColor = System.Drawing.Color.Transparent;
            this.eyeicon.FlatAppearance.BorderSize = 0;
            this.eyeicon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eyeicon.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.eyeicon.IconColor = System.Drawing.Color.Black;
            this.eyeicon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eyeicon.IconSize = 20;
            this.eyeicon.Location = new System.Drawing.Point(337, 393);
            this.eyeicon.Name = "eyeicon";
            this.eyeicon.Size = new System.Drawing.Size(34, 23);
            this.eyeicon.TabIndex = 25;
            this.eyeicon.UseVisualStyleBackColor = false;
            this.eyeicon.Click += new System.EventHandler(this.eyeicon_Click);
            this.eyeicon.MouseHover += new System.EventHandler(this.eyeicon_MouseHover);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(337, 393);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(34, 23);
            this.iconButton1.TabIndex = 26;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.panel3.Location = new System.Drawing.Point(290, 481);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 1);
            this.panel3.TabIndex = 27;
            this.panel3.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            this.panel3.MouseHover += new System.EventHandler(this.panel3_MouseHover);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(190)))));
            this.panel4.Location = new System.Drawing.Point(245, 572);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 1);
            this.panel4.TabIndex = 28;
            // 
            // POIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 578);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.eyeicon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Passworderror);
            this.Controls.Add(this.usernameerror);
            this.Controls.Add(this.forgetPbtn);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.usernametb);
            this.Controls.Add(this.passwordicon);
            this.Controls.Add(this.usericon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POIS";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POIS";
            this.Load += new System.EventHandler(this.POIS_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heartlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usericon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox usericon;
        private System.Windows.Forms.PictureBox passwordicon;
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox Heartlogo;
        private System.Windows.Forms.Label PurchaseOrderLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label forgetPbtn;
        private System.Windows.Forms.Label usernameerror;
        private System.Windows.Forms.Label Passworderror;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton Loginbtn;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton eyeicon;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}


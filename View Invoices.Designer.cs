
namespace POIS1
{
    partial class View_Invoices
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
            this.poislogo = new System.Windows.Forms.PictureBox();
            this.LPOdataview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.poislogo)).BeginInit();
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
            this.poislogo.Size = new System.Drawing.Size(1014, 585);
            this.poislogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.poislogo.TabIndex = 5;
            this.poislogo.TabStop = false;
            // 
            // LPOdataview
            // 
            this.LPOdataview.AllowUserToAddRows = false;
            this.LPOdataview.AllowUserToDeleteRows = false;
            this.LPOdataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LPOdataview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LPOdataview.Location = new System.Drawing.Point(0, 0);
            this.LPOdataview.Name = "LPOdataview";
            this.LPOdataview.ReadOnly = true;
            this.LPOdataview.RowHeadersWidth = 51;
            this.LPOdataview.RowTemplate.Height = 24;
            this.LPOdataview.Size = new System.Drawing.Size(1014, 585);
            this.LPOdataview.TabIndex = 87;
            // 
            // View_Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 585);
            this.Controls.Add(this.LPOdataview);
            this.Controls.Add(this.poislogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "View_Invoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "View_Invoices";
            this.Load += new System.EventHandler(this.View_Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poislogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LPOdataview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox poislogo;
        private System.Windows.Forms.DataGridView LPOdataview;
    }
}
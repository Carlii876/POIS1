
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
            this.Invoicedataview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.poislogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Invoicedataview)).BeginInit();
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
            // Invoicedataview
            // 
            this.Invoicedataview.AllowUserToAddRows = false;
            this.Invoicedataview.AllowUserToDeleteRows = false;
            this.Invoicedataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Invoicedataview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Invoicedataview.Location = new System.Drawing.Point(0, 0);
            this.Invoicedataview.Name = "Invoicedataview";
            this.Invoicedataview.ReadOnly = true;
            this.Invoicedataview.RowHeadersWidth = 51;
            this.Invoicedataview.RowTemplate.Height = 24;
            this.Invoicedataview.Size = new System.Drawing.Size(1014, 585);
            this.Invoicedataview.TabIndex = 87;
            this.Invoicedataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Invoicedataview_CellContentClick);
            // 
            // View_Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 585);
            this.Controls.Add(this.Invoicedataview);
            this.Controls.Add(this.poislogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "View_Invoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "View_Invoices";
            this.Load += new System.EventHandler(this.View_Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poislogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Invoicedataview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox poislogo;
        private System.Windows.Forms.DataGridView Invoicedataview;
    }
}

namespace POIS1
{
    partial class View_Purchase_Order
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
            this.POrderdataview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.POrderdataview)).BeginInit();
            this.SuspendLayout();
            // 
            // POrderdataview
            // 
            this.POrderdataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.POrderdataview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.POrderdataview.Location = new System.Drawing.Point(0, 0);
            this.POrderdataview.Name = "POrderdataview";
            this.POrderdataview.RowHeadersWidth = 51;
            this.POrderdataview.RowTemplate.Height = 24;
            this.POrderdataview.Size = new System.Drawing.Size(1421, 589);
            this.POrderdataview.TabIndex = 0;
            // 
            // View_Purchase_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 589);
            this.Controls.Add(this.POrderdataview);
            this.Name = "View_Purchase_Order";
            this.Text = "View_Purchase_Order";
            this.Load += new System.EventHandler(this.View_Purchase_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.POrderdataview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView POrderdataview;
    }
}
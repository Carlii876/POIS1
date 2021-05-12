
namespace POIS1
{
    partial class ViewReport
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
            this.ReportdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ReportdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportdataGridView
            // 
            this.ReportdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportdataGridView.Location = new System.Drawing.Point(0, 0);
            this.ReportdataGridView.Name = "ReportdataGridView";
            this.ReportdataGridView.RowHeadersWidth = 51;
            this.ReportdataGridView.RowTemplate.Height = 24;
            this.ReportdataGridView.Size = new System.Drawing.Size(1924, 812);
            this.ReportdataGridView.TabIndex = 0;
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 812);
            this.Controls.Add(this.ReportdataGridView);
            this.Name = "ViewReport";
            this.Text = "ViewReport";
            this.Load += new System.EventHandler(this.ViewReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportdataGridView;
    }
}
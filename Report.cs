using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POIS1
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void themebtn_Click(object sender, EventArgs e)
        {
            settingspanel.Visible = false;
            if (poislogo.BackColor == Color.LightSkyBlue)
            {

                generatereportlb.BackColor = Color.White;
                Reportlb.BackColor = Color.White;

                poislogo.BackColor = Color.White;
                toppanel.BackColor = Color.FromArgb(0, 117, 214);
            }

            else if (poislogo.BackColor == Color.White)
            {

                Reportlb.BackColor = Color.LightSkyBlue;

                poislogo.BackColor = Color.LightSkyBlue;
                toppanel.BackColor = Color.FromArgb(0, 117, 190);
            }
        }

        private void Report_Load(object sender, EventArgs e)
        {
            LPOdataview.Visible = false;
            // TODO: This line of code loads data into the 'pOISDataSet.LogPurchaseOrder' table. You can move, or remove it, as needed.
            this.logPurchaseOrderTableAdapter.Fill(this.pOISDataSet.LogPurchaseOrder);
            // TODO: This line of code loads data into the 'pOISDataSet.LogPurchaseOrder' table. You can move, or remove it, as needed.

            settingspanel.Visible = false;
            LogPObtn.ForeColor = Color.White;
            LogInvbtn.ForeColor = Color.White;
            Calculationbtn.ForeColor = Color.White;
            Homebtn.ForeColor = Color.White;
            Reportbtn.ForeColor = Color.Black;

            LogPObtn.BackColor = Color.FromArgb(0, 117, 190);
            LogInvbtn.BackColor = Color.FromArgb(0, 117, 190);
            Calculationbtn.BackColor = Color.FromArgb(0, 117, 190);
            Homebtn.BackColor = Color.FromArgb(0, 117, 190);
            Reportbtn.BackColor = Color.White;
            homeicon.BackColor = Color.FromArgb(0, 117, 190);
            Reportbtn.FlatStyle = FlatStyle.Standard;
            Homebtn.FlatStyle = FlatStyle.Flat;
            LogPObtn.FlatStyle = FlatStyle.Flat;
            LogInvbtn.FlatStyle = FlatStyle.Flat;
            Calculationbtn.FlatStyle = FlatStyle.Flat;
        }

        private void Reportbtn_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Report page will be reloaded, are you sure?", "Reload", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                Report report = new Report();
                this.Hide();
                report.Show();
            }
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            Home_Page home = new Home_Page();
            this.Hide();
            home.Show();
        }

        private void LogPObtn_Click_1(object sender, EventArgs e)
        {
            Log_Purchase_Order log_Purchase = new Log_Purchase_Order();
            this.Hide();
            log_Purchase.Show();
        }

        private void LogInvbtn_Click(object sender, EventArgs e)
        {
            Log_Invoice log_Invoice = new Log_Invoice();
            this.Hide();
            log_Invoice.Show();
        }

        private void Calculationbtn_Click(object sender, EventArgs e)
        {
            Calculation calculation = new Calculation();
            this.Hide();
            calculation.Show();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact administrator for any inquiry");
        }

        private void hlplbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact administrator for any inquiry");
        }

        private void logOicon_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                this.Hide();

                POIS login = new POIS();

                login.Show();
            }
        }

        private void logoutlbl_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                this.Hide();

                POIS login = new POIS();

                login.Show();
            }
        }

        private void settingsicon_Click(object sender, EventArgs e)
        {
            if (settingspanel.Visible == true)
            {
                settingspanel.Visible = false;
            }
            else if (settingspanel.Visible == false)
            {
                settingspanel.Visible = true;
            }
        }

        private void changeThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poislogo.BackColor == Color.LightSkyBlue)
            {

                generatereportlb.BackColor = Color.White;
                Reportlb.BackColor = Color.White;

                poislogo.BackColor = Color.White;
                toppanel.BackColor = Color.FromArgb(0, 117, 214);
            }

            else if (poislogo.BackColor == Color.White)
            {

                Reportlb.BackColor = Color.LightSkyBlue;

                poislogo.BackColor = Color.LightSkyBlue;
                toppanel.BackColor = Color.FromArgb(0, 117, 190);
            }
        }

        private void logInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log_Invoice log_Invoice = new Log_Invoice();
            this.Hide();
            log_Invoice.Show();
        }

        private void logPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log_Purchase_Order log_Purchase = new Log_Purchase_Order();
            this.Hide();
            log_Purchase.Show();
        }

        private void viewInvoicesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var view_invoices = new View_Invoices();
            view_invoices.Show();

        }

        private void viewPurchaseOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ViewpurchaseOrder = new View_Purchase_Order();
            ViewpurchaseOrder.Show();
        }

        private void dateToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.logPurchaseOrderTableAdapter.Date(this.pOISDataSet.LogPurchaseOrder);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Yearlycb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
            
    }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.logPurchaseOrderTableAdapter.FillBy1(this.pOISDataSet.LogPurchaseOrder);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void generatebutton_Click(object sender, EventArgs e)
        {
            if(generatebutton.Text == "Generate")
            {
                generatebutton.Text = "Hide";
                LPOdataview.Visible = true;
            }
            else if (generatebutton.Text == "Hide")
            {
                generatebutton.Text = "Generate";
                LPOdataview.Visible = false;
            }


            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");
                connection.Open();


                SqlCommand command = connection.CreateCommand();

                
                


                command.CommandType = CommandType.Text;
                command.CommandText = "select * from LogPurchaseOrder where PurchaseOrderNumber = '" + Yearlycb.Text + "'";

                command.ExecuteNonQuery();

                DataTable data = new DataTable();
                SqlDataAdapter sqlData = new SqlDataAdapter(command);

                sqlData.Fill(data);
                
            
                LPOdataview.DataSource = data;

            connection.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                this.Hide();

                POIS login = new POIS();

                login.Show();
            }
        }
    }
}

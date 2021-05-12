using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POIS1
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }



        private void Homebtn_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Home page will be reloaded, are you sure?", "Reload", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                Home_Page home = new Home_Page();
                this.Hide();
                home.Show();
            }
            LogPObtn.ForeColor = Color.White;
            LogInvbtn.ForeColor = Color.White;
            Calculationbtn.ForeColor = Color.White;
            Reportbtn.ForeColor = Color.White;
            Homebtn.ForeColor = Color.Black;

            LogPObtn.BackColor = Color.FromArgb(0, 117, 190);
            LogInvbtn.BackColor = Color.FromArgb(0, 117, 190);
            Calculationbtn.BackColor = Color.FromArgb(0, 117, 190);
            Reportbtn.BackColor = Color.FromArgb(0, 117, 214);
            Homebtn.BackColor = Color.White;
            homeicon.BackColor = Color.White;
            Homebtn.FlatStyle = FlatStyle.Standard;
            LogPObtn.FlatStyle = FlatStyle.Flat;
            LogInvbtn.FlatStyle = FlatStyle.Flat;
            Calculationbtn.FlatStyle = FlatStyle.Flat;
            Reportbtn.FlatStyle = FlatStyle.Flat;


        }
        private void LogPObtn_Click(object sender, EventArgs e)
        {
            Log_Purchase_Order LOGPO = new Log_Purchase_Order();
            LOGPO.Show();
            this.Hide();

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

        private void Reportbtn_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            this.Hide();
            report.Show();

        }

        private void Home_Page_Load(object sender, EventArgs e)
        {
            //userlbl.Text = POIS.welcomeuser;
            //this.Text = "Home Page: " + POIS.welcomeuser;




            settingspanel.Visible = false;

            LogPObtn.ForeColor = Color.White;
            LogInvbtn.ForeColor = Color.White;
            Calculationbtn.ForeColor = Color.White;
            Reportbtn.ForeColor = Color.White;
            Homebtn.ForeColor = Color.Black;

            LogPObtn.BackColor = Color.FromArgb(0, 117, 190);
            LogInvbtn.BackColor = Color.FromArgb(0, 117, 190);
            Calculationbtn.BackColor = Color.FromArgb(0, 117, 190);
            Reportbtn.BackColor = Color.FromArgb(0, 117, 190);
            Homebtn.BackColor = Color.White;
            homeicon.BackColor = Color.White;
            Homebtn.FlatStyle = FlatStyle.Standard;
            LogPObtn.FlatStyle = FlatStyle.Flat;
            LogInvbtn.FlatStyle = FlatStyle.Flat;
            Calculationbtn.FlatStyle = FlatStyle.Flat;
            Reportbtn.FlatStyle = FlatStyle.Flat;
        }

        private void searchtb_MouseClick(object sender, MouseEventArgs e)
        {
            searchtb.ForeColor = Color.Black;
            if (searchtb.Text == "Search...")
            {
                searchtb.Text = "";
                if (searchtb.Text != "Search...")
                {
                    searchtb.ForeColor = Color.Black;
                }


            }
        }

        private void searchtb_MouseLeave(object sender, EventArgs e)
        {
            if (searchtb.Text == "")
            {
                searchtb.Text = "Search...";
                searchtb.ForeColor = Color.LightGray;
            }
            else if (searchtb.Text == "Search...")
            {
                searchtb.Text = "";
                //searchtb.ForeColor = Color.Black;
            }

        }

        private void searchtb_MouseHover(object sender, EventArgs e)
        {
            if (searchtb.Text == "Search...")
            {
                searchtb.Text = string.Empty;
            }

        }

        private void homeicon_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Home page will be reloaded, are you sure?", "Reload", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                Home_Page home = new Home_Page();
                this.Hide();
                home.Show();
            }
            LogPObtn.ForeColor = Color.White;
            LogInvbtn.ForeColor = Color.White;
            Calculationbtn.ForeColor = Color.White;
            Reportbtn.ForeColor = Color.White;
            Homebtn.ForeColor = Color.Black;

            LogPObtn.BackColor = Color.FromArgb(0, 117, 190);
            LogInvbtn.BackColor = Color.FromArgb(0, 117, 190);
            Calculationbtn.BackColor = Color.FromArgb(0, 117, 190);
            Reportbtn.BackColor = Color.FromArgb(0, 117, 190);
            Homebtn.BackColor = Color.White;
            homeicon.BackColor = Color.White;
            Homebtn.FlatStyle = FlatStyle.Standard;
            LogPObtn.FlatStyle = FlatStyle.Flat;
            LogInvbtn.FlatStyle = FlatStyle.Flat;
            Calculationbtn.FlatStyle = FlatStyle.Flat;
            Reportbtn.FlatStyle = FlatStyle.Flat;
        }

        private void Logoutlb_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                this.Hide();

                POIS login = new POIS();

                login.Show();
            }
        }

        private void Logouticon_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                this.Hide();

                POIS login = new POIS();

                login.Show();
            }
        }

        private void helplbl_Click(object sender, EventArgs e)
        {
            Saveinput saveinput = new Saveinput();
            MessageBox.Show(saveinput.help);
        }

        private void helplogo_Click(object sender, EventArgs e)
        {
            Saveinput saveinput = new Saveinput();
            MessageBox.Show(saveinput.help);
        }

        private void poislogo_Click(object sender, EventArgs e)
        {

        }

        private void settingsicon_Click(object sender, EventArgs e)
        {
            if (settingspanel.Visible == false)
                settingspanel.Visible = true;
            else if (settingspanel.Visible == true)
                settingspanel.Visible = false;
        }

        private void themebtn_Click(object sender, EventArgs e)
        {
            settingspanel.Visible = false;
            if (poislogo.BackColor == Color.LightSkyBlue)
            {
                poislogo.BackColor = Color.White;
                toppanel.BackColor = Color.FromArgb(0, 117, 214);
            }

            else if (poislogo.BackColor == Color.White)
            {
                poislogo.BackColor = Color.LightSkyBlue;
                toppanel.BackColor = Color.FromArgb(0, 117, 190);
            }
        }


        private void Viewinvoicesbt_Click(object sender, EventArgs e)
        {
            var view_invoices = new View_Invoices();
            view_invoices.Show();


            //view_invoices.MdiParent = this;

        }

        private void logInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log_Purchase_Order log_Purchase_Order = new Log_Purchase_Order();
            log_Purchase_Order.Show();
            this.Hide();
        }

        private void viewInvoicesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var view_invoices = new View_Invoices();


            // view_invoices.MdiParent = this;
            view_invoices.Show();


        }

        private void changeThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (poislogo.BackColor == Color.LightSkyBlue)
            {
                poislogo.BackColor = Color.White;
                toppanel.BackColor = Color.FromArgb(0, 117, 214);
            }

            else if (poislogo.BackColor == Color.White)
            {
                poislogo.BackColor = Color.LightSkyBlue;
                toppanel.BackColor = Color.FromArgb(0, 117, 190);
            }
        }

        private void searchtb_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            string q = "select * from Vendors";
            SqlCommand command = new SqlCommand(q, connection);
            //SqlDataReader datareader = command.ExecuteReader();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            try
            {
                connection.Open();
                SqlDataReader sqlData = command.ExecuteReader();

                while (sqlData.Read())
                {
                    collection.Add(sqlData.GetString(1));
                }
                searchtb.AutoCompleteCustomSource = collection;
            }

            catch (Exception ex)
            {

            }
            connection.Close();
        }

        private void ViewPurchaserOrderbtn_Click(object sender, EventArgs e)
        {
            var ViewpurchaseOrder = new View_Purchase_Order();
            ViewpurchaseOrder.Show();
        }

        private void logPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log_Purchase_Order log_Purchase = new Log_Purchase_Order();
            this.Hide();
            log_Purchase.Show();
        }

        private void viewPurchaseOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ViewpurchaseOrder = new View_Purchase_Order();
            ViewpurchaseOrder.Show();
        }
    }
}

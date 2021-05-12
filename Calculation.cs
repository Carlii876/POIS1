﻿using System;
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
    public partial class Calculation : Form
    {

        double disval;

        public Calculation()
        {
            InitializeComponent();
        }

        private void Calculationbtn_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Calculation page will be reloaded, are you sure?", "Reload", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                Calculation calculation = new Calculation();
                this.Hide();
                calculation.Show();
            }
        }

        private void Calculation_Load(object sender, EventArgs e)
        {

            Itemscombobox();
            addcurrency();
            settingpanel1.Visible = false;

            LogPObtn.ForeColor = Color.White;
            LogInvbtn.ForeColor = Color.White;
            
            Homebtn.ForeColor = Color.White;
            Calculationbtn.ForeColor = Color.Black;

            LogPObtn.BackColor = Color.FromArgb(0, 117, 190);
            LogInvbtn.BackColor = Color.FromArgb(0, 117, 190);
            
            Homebtn.BackColor = Color.FromArgb(0, 117, 190);
            Calculationbtn.BackColor = Color.White;
            homeicon.BackColor = Color.FromArgb(0, 117, 190);
            Calculationbtn.FlatStyle = FlatStyle.Standard;
            Homebtn.FlatStyle = FlatStyle.Flat;
            LogPObtn.FlatStyle = FlatStyle.Flat;
            LogInvbtn.FlatStyle = FlatStyle.Flat;
            
        }

        public void addcurrency()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            string q = "select * from Currency";
            SqlCommand command = new SqlCommand(q, connection);
            //SqlDataReader datareader = command.ExecuteReader();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            try
            {
                connection.Open();
                SqlDataReader sqlData = command.ExecuteReader();

                while (sqlData.Read())
                {
                    string Currency = sqlData.GetString(1);

                    collection.Add(sqlData.GetString(1));
                    Currencycb.Items.Add(Currency);

                }
            }
            catch
            {

            }
            connection.Close();


        }


        public void Itemscombobox()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            string q = "select * from Items";
            SqlCommand command = new SqlCommand(q, connection);
            //SqlDataReader datareader = command.ExecuteReader();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            try
            {
                connection.Open();
                SqlDataReader sqlData = command.ExecuteReader();

                while (sqlData.Read())
                {
                    string Items = sqlData.GetString(1);
                    collection.Add(sqlData.GetString(1));
                    ItemName1.Items.Add(Items);
                }
            }
            catch
            {

            }
            connection.Close();
        }
        private void Homebtn_Click(object sender, EventArgs e)
        {
            Home_Page home_Page = new Home_Page();
            this.Hide();
            home_Page.Show();
        }

        private void homeicon_Click(object sender, EventArgs e)
        {
            Home_Page home_Page = new Home_Page();
            this.Hide();
            home_Page.Show();
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

        private void logoutlbl_Click(object sender, EventArgs e)
        {
            WelcomeNExit welcomeNExit = new WelcomeNExit();
            if ((MessageBox.Show(Convert.ToString(welcomeNExit), "Log Out", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                this.Hide();

                POIS login = new POIS();

                login.Show();
            }
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

        private void hlplbl_Click(object sender, EventArgs e)
        {
            Saveinput saveinput = new Saveinput();
            MessageBox.Show(saveinput.help);
        }

        private void help_Click(object sender, EventArgs e)
        {
            Saveinput saveinput = new Saveinput();
            MessageBox.Show(saveinput.help);
        }

        private void settings_Click(object sender, EventArgs e)
        {
            if (settingpanel1.Visible == false)
                settingpanel1.Visible = true;
            else if (settingspanel.Visible == true)
                settingpanel1.Visible = false;
        }

        private void changethemebtn_Click(object sender, EventArgs e)
        {
            settingspanel.Visible = false;
            if (poislogo.BackColor == Color.LightSkyBlue)
            {

                Selectcurrencylbl.BackColor = Color.White;
                Currencylbl.BackColor = Color.White;
                Itemdetailslbl.BackColor = Color.White;
                ItemNamelbl.BackColor = Color.White;
                Quatitylbl.BackColor = Color.White;
                Costlbl.BackColor = Color.White;
                Taxlbl.BackColor = Color.White;
                Totallbl.BackColor = Color.White;
                Discountvaluelbl.BackColor = Color.White;
                Discountpercentlbl.BackColor = Color.White;
                poislogo.BackColor = Color.White;
                toppanel.BackColor = Color.FromArgb(0, 117, 214);
            }

            else if (poislogo.BackColor == Color.White)
            {

                Selectcurrencylbl.BackColor = Color.LightSkyBlue;
                Currencylbl.BackColor = Color.LightSkyBlue;
                Itemdetailslbl.BackColor = Color.LightSkyBlue;
                ItemNamelbl.BackColor = Color.LightSkyBlue;
                Quatitylbl.BackColor = Color.LightSkyBlue;
                Costlbl.BackColor = Color.LightSkyBlue;
                Taxlbl.BackColor = Color.LightSkyBlue;
                Totallbl.BackColor = Color.LightSkyBlue;
                Discountvaluelbl.BackColor = Color.LightSkyBlue;
                Discountpercentlbl.BackColor = Color.LightSkyBlue;
                poislogo.BackColor = Color.LightSkyBlue;
                toppanel.BackColor = Color.FromArgb(0, 117, 190);
            }
        }

        

        private void changeThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poislogo.BackColor == Color.LightSkyBlue)
            {

                Selectcurrencylbl.BackColor = Color.White;
                Currencylbl.BackColor = Color.White;
                Itemdetailslbl.BackColor = Color.White;
                ItemNamelbl.BackColor = Color.White;
                Quatitylbl.BackColor = Color.White;
                Costlbl.BackColor = Color.White;
                Taxlbl.BackColor = Color.White;
                Totallbl.BackColor = Color.White;
                Discountvaluelbl.BackColor = Color.White;
                Discountpercentlbl.BackColor = Color.White;
                poislogo.BackColor = Color.White;
                toppanel.BackColor = Color.FromArgb(0, 117, 214);
            }

            else if (poislogo.BackColor == Color.White)
            {

                Selectcurrencylbl.BackColor = Color.LightSkyBlue;
                Currencylbl.BackColor = Color.LightSkyBlue;
                Itemdetailslbl.BackColor = Color.LightSkyBlue;
                ItemNamelbl.BackColor = Color.LightSkyBlue;
                Quatitylbl.BackColor = Color.LightSkyBlue;
                Costlbl.BackColor = Color.LightSkyBlue;
                Taxlbl.BackColor = Color.LightSkyBlue;
                Totallbl.BackColor = Color.LightSkyBlue;
                Discountvaluelbl.BackColor = Color.LightSkyBlue;
                Discountpercentlbl.BackColor = Color.LightSkyBlue;
                poislogo.BackColor = Color.LightSkyBlue;
                toppanel.BackColor = Color.FromArgb(0, 117, 190);
            }
        }

        private void ItemName1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            string q = "select * from Items where Item_Name = '" + ItemName1.Text + "'";




            SqlCommand command = new SqlCommand(q, connection);




            connection.Open();
            SqlDataReader sqlData = command.ExecuteReader();

            while (sqlData.Read())
            {


                string currenc = sqlData.GetString(3);
                double Icost = sqlData.GetDouble(4);


                Currencycb.Text = currenc;
                costtb.Text = Convert.ToString(Icost);




            }
            connection.Close();
        }

        private void costtb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int cost;
                int quantity;



                quantity = Convert.ToInt32(quantitytb.Text);
                cost = Convert.ToInt32(costtb.Text);

                totaltb.Text = Math.Abs(quantity * cost).ToString();


            }





            catch (Exception)
            {


            }
        }

        private void quantitytb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int cost;
                int quantity;



                quantity = Convert.ToInt32(quantitytb.Text);
                cost = Convert.ToInt32(costtb.Text);

                totaltb.Text = Math.Abs(quantity * cost).ToString();


            }





            catch (Exception)
            {


            }
        }

        private void taxtb_TextChanged(object sender, EventArgs e)
        {
            Calculate calculate = new Calculate();
            try
            {
                taxtb.Text = calculate.Tax(Convert.ToDouble(taxtb.Text)).ToString();
            }
            catch (Exception)
            {


            }



        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            Calculate calculate = new Calculate();

            try
            {
                Subtotaltb.Text = calculate.CalculateTotal(Convert.ToDouble(totaltb.Text), Convert.ToDouble(taxtb.Text), Convert.ToDouble(disvaluetb.Text)).ToString();
            }
            catch (Exception)
            {


            }


        }

        private void dispercentagetb_TextChanged(object sender, EventArgs e)
        {

            try
            {


                double disc;
                double discountP;
                double discountV;
                double total;
                double discountp;
                total = Convert.ToDouble(totaltb.Text);


                discountP = Convert.ToDouble(dispercentagetb.Text);
                discountp = discountP / 100;
                //discountV = Convert.ToDouble(disvaluetb.Text);

                //disc = discountP * total;
                //discountV = disc;

                disvaluetb.Text = Math.Abs(discountp * total).ToString();
                disval = Convert.ToDouble(disvaluetb.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            bool isOpen = false;


            FormCollection fc = Application.OpenForms;
            View_Invoices view_Invoices = new View_Invoices();


            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "View_Invoices")
                {
                    isOpen = true;
                    form.Focus();

                    break;
                }
            }
            if (isOpen == false)
            {

                

                view_Invoices.Show();
                
            }




        }

        private void viewPurchaseOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool isOpen = false;


            FormCollection fc = Application.OpenForms;
            View_Purchase_Order view_Invoices = new View_Purchase_Order();


            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "View_Purchase_Order")
                {
                    isOpen = true;
                    form.Focus();

                    break;
                }
            }
            if (isOpen == false)
            {



                view_Invoices.Show();

            }
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

        private void Currencycb_SelectedIndexChanged(object sender, EventArgs e)
        {


            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");
            string q = "select * from Currency = '" + Currencycb.Text + "'";


            SqlCommand command = new SqlCommand(q, connection);


            //DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader sqlData = command.ExecuteReader();

                while (sqlData.Read())
                {
                    string currency = sqlData.GetString(1);




                }

            }
            catch (Exception ex)
            {

            }
        }

        private void viewReportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewReport viewreport = new ViewReport();
            viewreport.Show();
        }
    }
}



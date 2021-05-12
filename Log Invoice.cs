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
    public partial class Log_Invoice : Form
    {
        string VendorAddress;
        string VendorNumber;
        string VendorID;
        string status_id;
        public string ItemsId;
        string CurrencyId;
        public int VNumber;
        public double Cost1;
        public int Invoicenumber1;
        public string Currency1;
        public string VendorName1;
        public string VendorAddress1;
        public string ItemDescription1;
        public string Itemname;
        public DateTime Approvedate1;
        public string InvoiceStatus1;
        public double total1;
        public string totalcurrency1;
        public int PurchaseOrderNumber1;
        public int Quantity1;
        public Log_Invoice()
        {
            InitializeComponent();
        }

        private void Homebtn_Click(object sender, EventArgs e)
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
            if ((MessageBox.Show("Log Invoice page will be reloaded, are you sure?", "Reload", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                Log_Invoice log_Invoice = new Log_Invoice();
                this.Hide();
                log_Invoice.Show();
                LogPObtn.ForeColor = Color.White;
                Calculationbtn.ForeColor = Color.White;
                Reportbtn.ForeColor = Color.White;
                Homebtn.ForeColor = Color.White;
                LogInvbtn.ForeColor = Color.Black;

                LogPObtn.BackColor = Color.FromArgb(0, 117, 190);
                Calculationbtn.BackColor = Color.FromArgb(0, 117, 190);
                Reportbtn.BackColor = Color.FromArgb(0, 117, 190);
                Homebtn.BackColor = Color.FromArgb(0, 117, 190);
                LogInvbtn.BackColor = Color.White;
                homeicon.BackColor = Color.FromArgb(0, 117, 190);
                LogInvbtn.FlatStyle = FlatStyle.Standard;
                Homebtn.FlatStyle = FlatStyle.Flat;
                LogPObtn.FlatStyle = FlatStyle.Flat;
                Calculationbtn.FlatStyle = FlatStyle.Flat;
                Reportbtn.FlatStyle = FlatStyle.Flat;
            }

        }

        private void Calculationbtn_Click(object sender, EventArgs e)
        {
            Calculation calculation = new Calculation();
            this.Hide();
            calculation.Show();
            LogPObtn.ForeColor = Color.White;
            LogInvbtn.ForeColor = Color.White;
            Reportbtn.ForeColor = Color.White;
            Homebtn.ForeColor = Color.White;
            Calculationbtn.ForeColor = Color.Black;

            LogPObtn.BackColor = Color.FromArgb(0, 117, 190);
            LogInvbtn.BackColor = Color.FromArgb(0, 117, 190);
            Reportbtn.BackColor = Color.FromArgb(0, 117, 190);
            Homebtn.BackColor = Color.FromArgb(0, 117, 190);
            Calculationbtn.BackColor = Color.White;
            homeicon.BackColor = Color.FromArgb(0, 117, 190);
            Calculationbtn.FlatStyle = FlatStyle.Standard;
            Homebtn.FlatStyle = FlatStyle.Flat;
            LogPObtn.FlatStyle = FlatStyle.Flat;
            LogInvbtn.FlatStyle = FlatStyle.Flat;
            Reportbtn.FlatStyle = FlatStyle.Flat;
        }

        private void Reportbtn_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            this.Hide();
            report.Show();

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

        private void Log_Invoice_Load(object sender, EventArgs e)


        {
            

            
        

        // TODO: This line of code loads data into the 'pOISDataSet.LogPurchaseOrder' table. You can move, or remove it, as needed.

        settingspanel.Visible = false;
            // TODO: This line of code loads data into the 'pOISDataSet.Items' table. You can move, or remove it, as needed.

            //logPurchaseOrderdataview.Visible = false;

            Vendorcombobox();
            InvoiceStatus();
            autofillVendors();
            addcurrency();
            PurchaseOrderNumber();
            autofillItems();
            Itemscombobox();





            //try
            //{

            //    Adddetailsbtn.Visible = false;
            //    settingspanel.Visible = false;


            //    VndrNumbercb.Text = Convert.ToString(VNumber);
            //    Costtb.Text = Convert.ToString(Cost1);
            //    Invnumbertb.Text = Convert.ToString(Invoicenumber1);
            //    Currencycb.SelectedItem = Currency1;
            //    Vendorcb.SelectedText = VendorName1;
            //    VndrAddrescb.Text = VendorAddress1;
            //    Itemdesctb.Text = ItemDescription1;
            //    ItemName1.Text = Itemname;
            //    Approvaldate.Value = Approvedate1;
            //    Invstatuscb.SelectedItem = InvoiceStatus1;
            //    totaltb.Text = Convert.ToString(total1);
            //    totalcurrencycb.Text = totalcurrency1;
            //    POnumbercb.Text = Convert.ToString(PurchaseOrderNumber1);
            //    Quantitytb.Text = Convert.ToString(Quantity1);
            //}
            //catch (Exception)
            //{



            //}




            LogPObtn.ForeColor = Color.White;
            Calculationbtn.ForeColor = Color.White;
            Reportbtn.ForeColor = Color.White;
            Homebtn.ForeColor = Color.White;
            LogInvbtn.ForeColor = Color.Black;

            LogPObtn.BackColor = Color.FromArgb(0, 117, 190);
            Calculationbtn.BackColor = Color.FromArgb(0, 117, 190);
            Reportbtn.BackColor = Color.FromArgb(0, 117, 190);
            Homebtn.BackColor = Color.FromArgb(0, 117, 190);
            LogInvbtn.BackColor = Color.White;
            homeicon.BackColor = Color.FromArgb(0, 117, 190);
            LogInvbtn.FlatStyle = FlatStyle.Standard;
            Homebtn.FlatStyle = FlatStyle.Flat;
            LogPObtn.FlatStyle = FlatStyle.Flat;
            Calculationbtn.FlatStyle = FlatStyle.Flat;
            Reportbtn.FlatStyle = FlatStyle.Flat;
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
                    string totalcurrency = sqlData.GetString(1);
                    collection.Add(sqlData.GetString(1));
                    Currencycb.Items.Add(Currency);
                    totalcurrencycb.Items.Add(totalcurrency);
                }
            }
            catch
            {

            }
            connection.Close();


        }
        public void autofillItems()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");
            
            string q = "select * from Items";
            connection.Open();
            SqlCommand command = new SqlCommand(q, connection);
            SqlDataReader datareader = command.ExecuteReader();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            try
            {
                
                SqlDataReader sqlData = command.ExecuteReader();

                while (sqlData.Read())
                {
                    collection.Add(sqlData.GetString(1));
                }
                ItemName1.AutoCompleteCustomSource = collection;
            }

            catch (Exception ex)
            {

            }
            connection.Close();
        }
        public void autofillVendors()
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
                Vendorcb.AutoCompleteCustomSource = collection;
            }

            catch (Exception ex)
            {

            }
            connection.Close();
        }
        public void PurchaseOrderNumber()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            string q = "select * from LogPurchaseOrder";
            SqlCommand command = new SqlCommand(q, connection);
            //DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader sqlData = command.ExecuteReader();

                while (sqlData.Read())
                {
                    string LogPurchase = sqlData[5].ToString();
                    POnumbercb.Items.Add(LogPurchase);



                }
            }
            catch (Exception ex)
            {

            }
            connection.Close();
        }
        public void InvoiceStatus()
        {

            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            string q = "select * from InvoiceStatus";
            SqlCommand command = new SqlCommand(q, connection);
            //DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader sqlData = command.ExecuteReader();

                while (sqlData.Read())
                {
                    string Statustype = sqlData.GetString(1);
                    Invstatuscb.Items.Add(Statustype);
                }
            }
            catch
            {

            }
        }
        public void Vendorcombobox()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            string q = "select * from Vendors";
            SqlCommand command = new SqlCommand(q, connection);
            //DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader sqlData = command.ExecuteReader();

                while (sqlData.Read())
                {
                    string vname = sqlData.GetString(1);
                    Vendorcb.Items.Add(vname);



                }
            }
            catch (Exception ex)
            {

            }
            connection.Close();

        }
        private void settings_Click(object sender, EventArgs e)
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

        private void themebtn_Click(object sender, EventArgs e)
        {
            settingspanel.Visible = false;
            if (poislogo.BackColor == Color.LightSkyBlue)
            {
                Paymentlb.BackColor = Color.White;
                Clearbtn.BackColor = Color.FromArgb(0, 117, 214);
                VenderInformationlbl.BackColor = Color.White;
                VenderNamelbl.BackColor = Color.White;
                VendorAddresslbl.BackColor = Color.White;
                VendorNumberlbl.BackColor = Color.White;
                ItemInformationlbl.BackColor = Color.White;
                ItemNamelbl.BackColor = Color.White;
                ItemDescriptionlbl.BackColor = Color.White;
                Quatitylbl.BackColor = Color.White;
                Costlbl.BackColor = Color.White;
                Currencylbl.BackColor = Color.White;
                OtherInformationlbl.BackColor = Color.White;
                ApprovalDatelbl.BackColor = Color.White;
                Invnumberlbl.BackColor = Color.White;
                POstatuslbl.BackColor = Color.White;
                POnumberlbl.BackColor = Color.White;
                totalcurrencylb.BackColor = Color.White;
                saveicon.BackColor = Color.White;
                totallb.BackColor = Color.White;

                poislogo.BackColor = Color.White;
                toppanel.BackColor = Color.FromArgb(0, 117, 214);
            }

            else if (poislogo.BackColor == Color.White)
            {
                Paymentlb.BackColor = Color.LightSkyBlue;
                Clearbtn.BackColor = Color.FromArgb(0, 117, 214);
                VenderInformationlbl.BackColor = Color.LightSkyBlue;
                VenderNamelbl.BackColor = Color.LightSkyBlue;
                VendorAddresslbl.BackColor = Color.LightSkyBlue;
                VendorNumberlbl.BackColor = Color.LightSkyBlue;
                ItemInformationlbl.BackColor = Color.LightSkyBlue;
                ItemNamelbl.BackColor = Color.LightSkyBlue;
                ItemDescriptionlbl.BackColor = Color.LightSkyBlue;
                Quatitylbl.BackColor = Color.LightSkyBlue;
                Costlbl.BackColor = Color.LightSkyBlue;
                Currencylbl.BackColor = Color.LightSkyBlue;
                OtherInformationlbl.BackColor = Color.LightSkyBlue;
                ApprovalDatelbl.BackColor = Color.LightSkyBlue;
                Invnumberlbl.BackColor = Color.LightSkyBlue;
                POstatuslbl.BackColor = Color.LightSkyBlue;

                Invnumberlbl.BackColor = Color.LightSkyBlue;
                POnumberlbl.BackColor = Color.LightSkyBlue;
                totalcurrencylb.BackColor = Color.LightSkyBlue;
                saveicon.BackColor = Color.LightSkyBlue;
                totallb.BackColor = Color.LightSkyBlue;

                poislogo.BackColor = Color.LightSkyBlue;
                toppanel.BackColor = Color.FromArgb(0, 117, 190);

            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Invnumbertb.Text = string.Empty;
            Vendorcb.Text = string.Empty;
            VndrAddrescb.Text = "";
            VndrNumbercb.Text = "";
            ItemName1.Text = "";
            Itemdesctb.Text = "";
            Quantitytb.Text = "";
            Costtb.Text = "";
            Currencycb.SelectedItem = "";
            Approvaldate.Value = DateTime.Now;
            POnumbercb.Text = "";
            totaltb.Text = "";
            totalcurrencycb.SelectedItem = "";
            //POstatuscb.SelectedItem = "";
        }

        private void saveicon_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = true;
                int VendorNumber = Convert.ToInt32(VndrNumbercb.Text);
                double Cost = Convert.ToDouble(Costtb.Text);
                int Invoicenumber = Convert.ToInt32(Invnumbertb.Text);
                string Currency = Currencycb.SelectedItem.ToString();
                string VendorName = Vendorcb.SelectedText;
                string VendorAddress = VndrAddrescb.Text;
                string ItemDescription = Itemdesctb.Text;
                string ItemName = ItemName1.Text;
                DateTime Approvedate = Approvaldate.Value;
                string InvoiceStatus = Invstatuscb.SelectedItem.ToString();
                double total = Convert.ToInt32(totaltb.Text);
                string totalcurrency = totalcurrencycb.Text;
                int PurchaseOrderNumber = Convert.ToInt32(POnumbercb.Text);
                int Quantity = Convert.ToInt32(Quantitytb.Text);

                if (string.IsNullOrWhiteSpace(VendorName))
                {
                    isValid = false;
                    Vendornameerror.Text = "Please Enter Vender Name";
                }
                else
                {
                    Vendornameerror.Text = "";
                }

                if (string.IsNullOrWhiteSpace(VendorAddress))
                {
                    isValid = false;
                    Addresserror.Text = "Please Enter Vender Address";
                }
                else
                {
                    Addresserror.Text = "";
                }
                if (double.IsNaN(Cost) || Cost == 0)
                {
                    isValid = false;
                    costerror.Text = "Please Enter a Cost";
                }
                else
                {
                    costerror.Text = "";
                }
                if (VendorNumber == 0)
                {
                    isValid = false;
                    Numbererror.Text = "Please Enter Vendors Telephone Number";

                }
                else
                {
                    Numbererror.Text = "";
                }
                if (string.IsNullOrWhiteSpace(ItemName))
                {
                    isValid = false;
                    Itemnameerror.Text = "Please Enter the Item's Name";
                }
                else
                {
                    Itemnameerror.Text = "";
                }
                if (string.IsNullOrWhiteSpace(ItemDescription))
                {
                    isValid = false;
                    Descriptionerror.Text = "Enter Description. eg 'Stationaries', 'Office Chairs' etc";
                }
                else
                {
                    Descriptionerror.Text = "";
                }
                if (Quantity == 0)
                {
                    isValid = false;
                    quatityerror.Text = "Please Insert the Amount of Items";
                }
                else
                {
                    quatityerror.Text = "";
                }

                if (PurchaseOrderNumber == 0)
                {
                    isValid = false;
                    purchaseONerror.Text = "Please Enter the Purchase Order Number";
                }
                else
                {
                    purchaseONerror.Text = "";
                }

                if (total == 0)
                {
                    isValid = false;
                    label2.Text = "Please Enter the Purchase Order Total";
                }
                else
                {
                    label2.Text = "";
                }

                if (Approvedate > DateTime.Now)
                {
                    isValid = false;
                    approvaldatererror.Text = "Please Enter Correct Date";

                }
                else
                {
                    approvaldatererror.Text = "";
                }
                if (string.IsNullOrWhiteSpace(totalcurrency))
                {
                    isValid = false;
                    totalcurrencyerror.Text = "Please Select the Appropriate Currency";
                }
                else
                {
                    totalcurrencyerror.Text = "";
                }
                if (isValid)
                {

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Please Enter the Missing data");
            }

            try
            {
                if ((MessageBox.Show("Do you want to log the purchase order?", "Are You sure", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                {


                    SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

                    connection.Open();
                    //Insertqueries





                    string Q = "insert into Invoices(PurchaseOrderID, ApprovalDate, DateForPayment, Vendors_id, Items_id, Invoice_description, total, Status_Id, InvoiceNumber, PurchaseOrderNumber)values('" + PurchaseOrderNumber1 + "', '" + Approvedate1 + "','" + Paymentdate + "','" + VendorID + "','" + Itemdesctb.Text + "','" + totaltb.Text + "','" + CurrencyId + "','" + status_id + "','" + Invnumbertb.Text + "','" + POnumbercb.Text + "')";
                    //selectqueries 
                    string s = "select Status_Id from InvoiceStatus where Status_type = '" + Invstatuscb.SelectedItem + "'";
                    string q = "select PurchaseOrderId from LogPurchaseOrder where PurchaseOrderNumber = '" + POnumbercb.SelectedItem + "'";
                    SqlCommand command = new SqlCommand(Q, connection);

                    command.ExecuteNonQuery();


                    connection.Close();
                    
                }
            }

            catch
            {

            }
        
    }

        private void generatebutton_Click(object sender, EventArgs e)
        {
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact administrator for any inquiry");
        }

        private void hlplbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact administrator for any inquiry");
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

        private void logOicon_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                this.Hide();

                POIS login = new POIS();

                login.Show();
            }
        }

        private void poislogo_Click(object sender, EventArgs e)
        {

        }

        private void changeThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Vendorcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            string q = "select * from Vendors where VendorName='" + Vendorcb.Text + "'";
            
            string V = "select  Vendor_id from Vendors where VendorName '" + Vendorcb.SelectedItem + "')";

            SqlCommand command = new SqlCommand(q, connection);
            
            //DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader sqlData = command.ExecuteReader();
               
                while (sqlData.Read())
                { 
                     VendorAddress = sqlData.GetString(2);
                     VendorNumber = sqlData.GetString(3);
                     VendorID = sqlData[0].ToString();

                    //ItemName1.Text = VendorID;
                    VndrAddrescb.Text = VendorAddress;
                    VndrNumbercb.Text = VendorNumber;
                }
                

            }
            catch (Exception ex)
            {

            }
        }

        private void Invstatuscb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Itemdesctb_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            string Idesc = "insert into Items (Item_Description) values  ('" + Itemdesctb + "')";


            SqlCommand command = new SqlCommand(Idesc, connection);



            try
            {
                connection.Open();
                SqlDataReader sqlData = command.ExecuteReader();

                while (sqlData.Read())
                {
                    Idesc = sqlData.GetString(2);



                }
            }

            catch (Exception ex)
            {

            }
            connection.Close();
        }

        private void Costtb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int cost;
                int quantity;



                quantity = Convert.ToInt32(Quantitytb.Text);
                cost = Convert.ToInt32(Costtb.Text);

                totaltb.Text = Math.Abs(quantity * cost).ToString();


            }





            catch (Exception)
            {


            }
        }

        private void totalcurrencycb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Currencycb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Invnumbertb_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");
            connection.Open();


            string q = "select * from Invoices where InvoiceNumber ='" + Invnumbertb.Text + "'";
            string I = "select Item_id from Items where Item_Name  ('" + ItemName1.Text + "')";

            SqlCommand command = new SqlCommand(q, connection);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ItemsId = dataReader[0].ToString();
            }
            //DataTable dataTable = new DataTable();
            connection.Close();
        }

        private void POnumbertb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            string q = "select  Vendor_id from  LogPurchaseOrder where PurchaseOrderNumber = '" + POnumbercb.Text + "'";

            SqlCommand command = new SqlCommand(q, connection);
            //DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader sqlData = command.ExecuteReader();

                while (sqlData.Read())
                {
                    
                    string LogPurchase = sqlData.GetString(5);
                    POnumbercb.Items.Add(LogPurchase);

                    Vendorcb.Text = sqlData.GetString(1);
                    //string VendorNumber = sqlData.GetString(3);
                    VendorID = sqlData[0].ToString();

                    //ItemName1.Text = VendorID;
                    
                    //VndrAddrescb.Text = VendorAddress;
                    //VndrNumbercb.Text = VendorNumber;



                }
            }
            catch (Exception ex)
            {

            }
            connection.Close();
        }

        private void ItemName1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Viewdetailsbtn_Click(object sender, EventArgs e)
        {
            
            //if (logPurchaseOrderdataview.Visible == false)
            //{
            //    logPurchaseOrderdataview.Visible = true;
            //    Viewsdetailsbtn.Text = "Hide details"; 
            //}
            //else if (logPurchaseOrderdataview.Visible == true)
            //{
            //    Viewsdetailsbtn.Text = "View details";
            //    logPurchaseOrderdataview.Visible = false;
                
            //}
           
        }

        private void Quantitytb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int cost;
                int quantity;



                quantity = Convert.ToInt32(Quantitytb.Text);
                cost = Convert.ToInt32(Costtb.Text);

                totaltb.Text = Math.Abs(quantity * cost).ToString();


            }





            catch (Exception)
            {


            }
        }

        private void ItemName1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            string q = "select * from Items where Item_Name = '" + ItemName1.Text + "'";
            string i = "Select PurchaseOrderNumber, Item_amount,Approval_Date from LogPurchaseOrder p inner join Items i on p.Items_id = i.Item_id where Item_name = '" + ItemName1.Text+"'";
            string a = "select Vendorname, VendorAddress, VendorNumber from Vendors v inner join LogPurchaseOrder p on p.Vendor_id = v.Vendors_id inner join Items i on p.Items_id = i.Item_id where Item_name = '" + ItemName1.Text+"'";
          
            //"select Vendorname, VendorAddress, VendorNumber from Vendors v inner join LogPurchaseOrder p on p.Vendor_id = v.Vendors_id where Items_id = '" + ItemsId + "'";


            SqlCommand command = new SqlCommand(q, connection);
            SqlCommand command1 = new SqlCommand(i, connection);
            SqlCommand command2 = new SqlCommand(a, connection);
            //DataTable dataTable = new DataTable();


            connection.Open();
            SqlDataReader sqlData = command.ExecuteReader();

            while (sqlData.Read())
            {

                string description = sqlData.GetString(2);
                string currenc = sqlData.GetString(3);
                ItemsId = sqlData[0].ToString();
                double Icost = sqlData.GetDouble(4);


                Currencycb.Text = currenc;
                Costtb.Text = Convert.ToString(Icost);



                Itemdesctb.Text = description;
                //ItemName1.Text = VendorID;
                //VndrAddrescb.Text = VendorAddress;
                //VndrNumbercb.Text = VendorNumber;
            }
            connection.Close();

            connection.Open();
            SqlDataReader sqlData1 = command1.ExecuteReader();
            while (sqlData1.Read())
            {
                int PON = sqlData1.GetInt32(0);
                int amount = sqlData1.GetInt32(1);
                DateTime date = sqlData1.GetDateTime(2);

                POnumbercb.Text = Convert.ToString(PON);
                Quantitytb.Text = Convert.ToString(amount);
                Approvaldate.Value = date;


            }
            
            connection.Close();

            connection.Open();
            SqlDataReader sqlData2 = command2.ExecuteReader();

            while (sqlData2.Read())
            {

                string VendorName = sqlData2.GetString(0);
                string Address = sqlData2.GetString(1);
                
                //int number = sqlData2.GetInt32(2);


                Vendorcb.Text = VendorName;
                //VndrAddrescb.Text = Address;
                //VndrNumbercb.Text = Convert.ToString(number);
                int newIndex = ItemName1.SelectedIndex;



               

            }
            if (POnumbercb.Text == "")
            {
                MessageBox.Show("There's no purchase Order For this Item");
            }

            
            connection.Close();

            

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
            view_invoices.MdiParent = this;

        }

        private void viewPurchaseOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ViewpurchaseOrder = new View_Purchase_Order();
            ViewpurchaseOrder.Show();
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

    
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
    public partial class Log_Invoice : Form
    {
        string PurchaseorderId;
        string InvstatusID;
        string Itemname1;
        string InvoiceId;
        string ApproveDate;
        string VendorAddress;
        string VendorNumber;
        string VendorID;
        string status_id;
        string POnum;
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
                
                Homebtn.ForeColor = Color.White;
                LogInvbtn.ForeColor = Color.Black;

                LogPObtn.BackColor = Color.FromArgb(0, 117, 190);
                Calculationbtn.BackColor = Color.FromArgb(0, 117, 190);
                
                Homebtn.BackColor = Color.FromArgb(0, 117, 190);
                LogInvbtn.BackColor = Color.White;
                homeicon.BackColor = Color.FromArgb(0, 117, 190);
                LogInvbtn.FlatStyle = FlatStyle.Standard;
                Homebtn.FlatStyle = FlatStyle.Flat;
                LogPObtn.FlatStyle = FlatStyle.Flat;
                Calculationbtn.FlatStyle = FlatStyle.Flat;
                
            }

        }

        private void Calculationbtn_Click(object sender, EventArgs e)
        {
            Calculation calculation = new Calculation();
            this.Hide();
            calculation.Show();
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





           




            LogPObtn.ForeColor = Color.White;
            Calculationbtn.ForeColor = Color.White;
            
            Homebtn.ForeColor = Color.White;
            LogInvbtn.ForeColor = Color.Black;

            LogPObtn.BackColor = Color.FromArgb(0, 117, 190);
            Calculationbtn.BackColor = Color.FromArgb(0, 117, 190);
            
            Homebtn.BackColor = Color.FromArgb(0, 117, 190);
            LogInvbtn.BackColor = Color.White;
            homeicon.BackColor = Color.FromArgb(0, 117, 190);
            LogInvbtn.FlatStyle = FlatStyle.Standard;
            Homebtn.FlatStyle = FlatStyle.Flat;
            LogPObtn.FlatStyle = FlatStyle.Flat;
            Calculationbtn.FlatStyle = FlatStyle.Flat;
            
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
                    InvstatusID = sqlData[0].ToString();
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
            invoiceerror.Text = "";
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

            Vendornameerror.Text = "";
            Addresserror.Text = "";
            Numbererror.Text = "";
            Itemnameerror.Text = "";
            Descriptionerror.Text = "";
            costerror.Text = "";
            totalcurrencyerror.Text = "";
            quatityerror.Text = "";
            purchaseONerror.Text = "";



            POstatusError.Text = "";
            quatityerror.Text = "";
            purchaseONerror.Text = "";
            label2.Text = "";
            costerror.Text = "";
            Numbererror.Text = "";
            //POstatuscb.SelectedItem = "";
        }

        private void saveicon_Click(object sender, EventArgs e)
        {

            bool isValid = true;
            Saveinput saveinput = new Saveinput();


            saveinput.currency = Currencycb.Text;
            saveinput.vendorName = Vendorcb.Text;
            saveinput.vendorAddress = VndrAddrescb.Text;
            saveinput.itemDescription = Itemdesctb.Text;
            saveinput.itemName = ItemName1.Text;
            saveinput.approvedate = Approvaldate.Value;
            saveinput.dateforpayment = Paymentdate.Value; 


            saveinput.totalcurrency = totalcurrencycb.Text;


            if (saveinput.dateforpayment < saveinput.approvedate )
            {
                MessageBox.Show("Date for Paymnet can not be less than Date for Approval");
            }
            if (saveinput.vendorName == "")
            {
                isValid = false;
                Vendornameerror.Text = "Please Enter Vender Name";
            }
            else
            {
                Vendornameerror.Text = "";
            }

            if (string.IsNullOrEmpty(saveinput.vendorAddress))
            {
                isValid = false;
                Addresserror.Text = "Please Enter Vender Address";
            }
            else
            {
                Addresserror.Text = "";
            }


            if (string.IsNullOrWhiteSpace(saveinput.itemName))
            {
                isValid = false;
                Itemnameerror.Text = "Please Enter the Item's Name";
            }
            else
            {
                Itemnameerror.Text = "";
            }




            if (string.IsNullOrWhiteSpace(saveinput.totalcurrency))
            {
                isValid = false;
                totalcurrencyerror.Text = "Please Select the Appropriate Currency";
            }
            else
            {
                totalcurrencyerror.Text = "";
            }



            try
            {

                saveinput.invoiceStatus = Invstatuscb.SelectedText.ToString();
                saveinput.vendorNumber = Convert.ToInt64(VndrNumbercb.Text);
                saveinput.cost = Convert.ToDouble(Costtb.Text);
                saveinput.invoicenumber = Convert.ToInt32(Invnumbertb.Text);
                saveinput.total = Convert.ToInt32(totaltb.Text);
                saveinput.purchaseOrderNumber = Convert.ToInt32(POnumbercb.Text);
                saveinput.quantity = Convert.ToInt32(Quantitytb.Text);

                if(saveinput.invoicenumber ==0)
                {
                    isValid = false;
                    invoiceerror.Text = "Please Enter a Invoice Number";

                }
                else
                {
                    invoiceerror.Text = "";
                }
                if (saveinput.quantity == 0)
                {
                    isValid = false;
                    quatityerror.Text = "Please Insert the Amount of Items";
                    
                }
                else
                {
                    quatityerror.Text = "";
                }

                if (saveinput.purchaseOrderNumber == 0)
                {
                    isValid = false;
                    purchaseONerror.Text = "Please Enter the Purchase Order Number";
                   
                }
                else
                {
                    purchaseONerror.Text = "";
                }

                if (saveinput.total == 0)
                {
                    isValid = false;
                    label2.Text = "Please Enter the Purchase Order Total";
                }
                else
                {
                    label2.Text = "";
                }
                if (double.IsNaN(saveinput.cost) || saveinput.cost == 0)
                {
                    isValid = false;
                    costerror.Text = "Please Enter a Cost";
                }
                else
                {
                    costerror.Text = "";
                }
                if (saveinput.vendorNumber == 0)
                {
                    isValid = false;
                    Numbererror.Text = "Please Enter Vendors Telephone Number";

                }
                else
                {
                    Numbererror.Text = "";
                }


            }
            catch (Exception)
            {
                POstatusError.Text = "Please Select Status";
                quatityerror.Text = "Please Insert the Amount of Items";
                purchaseONerror.Text = "Please Enter the Purchase Order Number";
                label2.Text = "Please Enter the Purchase Order Total";
                costerror.Text = "Please Enter a Cost";
                Numbererror.Text = "Please Enter Vendors Telephone Number";
                invoiceerror.Text = "Please Enter a Invoice Number";
                MessageBox.Show("Please Enter the Missing data");
            }

            if (isValid)
            {
                Vendornameerror.Text = "";
                Addresserror.Text = "";
                Numbererror.Text = "";
                Itemnameerror.Text = "";
                Descriptionerror.Text = "";
                costerror.Text = "";
                totalcurrencyerror.Text = "";
                quatityerror.Text = "";
                purchaseONerror.Text = "";
                POstatusError.Text = "";
                quatityerror.Text = "";
                purchaseONerror.Text = "";
                label2.Text = "";
                costerror.Text = "";
                Numbererror.Text = "";

                    


                

               
               
               
             

                    

                    if ((MessageBox.Show("Do you want to log the Invoice?", "Are You sure", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                    {
                        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

                        connection.Open();

                        string s = "select * from LogPurchaseOrder where PurchaseOrderNumber = '" + POnumbercb.Text + "'";

                        SqlCommand command2 = new SqlCommand(s, connection);



                        SqlDataReader sqlData1 = command2.ExecuteReader();
                        while (sqlData1.Read())
                        {
                             PurchaseorderId = sqlData1[0].ToString();
                            PurchaseOrderNumber1 = sqlData1.GetInt32(5);

                            //Cost1 = sqlData.GetDouble(4);
                            //Itemdesctb.Text = ItemsId;
                            //ItemName1.Text = status_id;
                        }
                    if (PurchaseOrderNumber1 != Convert.ToInt32(POnumbercb.Text))
                    {
                        MessageBox.Show("purchase order does not exist");
                    }

                    connection.Close();


                        SqlConnection connection1 = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

                        connection1.Open();

                        string Q = "insert into Invoices(PurchaseOrderID, ApprovalDate, DateForPayment, Vendors_id,  Invoice_description, total, Status_Id, InvoiceNumber, PurchaseOrderNumber)values('" + PurchaseorderId + "', '" + ApproveDate + "','" + Paymentdate.Value + "','" + VendorID + "','" + Itemdesctb.Text + "','" + totaltb.Text + "','" + InvstatusID + "','" + Invnumbertb.Text + "','" + POnumbercb.Text + "')";
                       
                        SqlCommand command1 = new SqlCommand(Q, connection1);

                       
                        SqlDataReader sqlData = command1.ExecuteReader();


                        while (sqlData.Read())
                        {
                            InvoiceId = sqlData[0].ToString();
                        }

                        try
                        {
                            string q = "insert into InvoiceItem(Invoice_id, Item_id, Item_Provided)values('" + InvoiceId + "', '" + ItemsId + "','" + Itemname1 + "')";

                            SqlCommand command3 = new SqlCommand(q, connection);

                            command3.ExecuteNonQuery();


                            connection.Close();
                        }
                        catch (Exception)
                        {


                        }

                        MessageBox.Show("Invoice Logged");
                    }
                   
                
            }
        }


        private void help_Click(object sender, EventArgs e)
        {
            Saveinput saveinput = new Saveinput();
            MessageBox.Show(saveinput.help1);
        }

        private void hlplbl_Click(object sender, EventArgs e)
        {
            Saveinput saveinput = new Saveinput();
            MessageBox.Show(saveinput.help1);
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
            Calculate calculate = new Calculate();
            try
            {
                totaltb.Text = calculate.CalculateTotal(Convert.ToDouble(Quantitytb.Text), Convert.ToDouble(Costtb.Text)).ToString();
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
            //SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");
            //connection.Open();


            //string q = "select * from Invoices where InvoiceNumber ='" + Invnumbertb.Text + "'";
            //string I = "select Item_id from Items where Item_Name  ('" + ItemName1.Text + "')";

            //SqlCommand command = new SqlCommand(q, connection);
            //SqlDataReader dataReader = command.ExecuteReader();

            //while (dataReader.Read())
            //{
            //    ItemsId = dataReader[0].ToString();
            //}
            ////DataTable dataTable = new DataTable();
            //connection.Close();
        }

        private void POnumbertb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            //string q = "select  PurchaseOrderId from  LogPurchaseOrder where PurchaseOrderNumber = '" + POnumbercb.Text + "'";

            //SqlCommand command = new SqlCommand(q, connection);
            ////DataTable dataTable = new DataTable();

            //try
            //{
            //    connection.Open();
            //    SqlDataReader sqlData = command.ExecuteReader();

            //    while (sqlData.Read())
            //    {

            //        POnum = sqlData[0].ToString();

            //        //string LogPurchase = sqlData.GetString(5);
            //        //POnumbercb.Items.Add(LogPurchase);

            //        //Vendorcb.Text = sqlData.GetString(1);
            //        ////string VendorNumber = sqlData.GetString(3);
            //        //VendorID = sqlData[0].ToString();

            //        //ItemName1.Text = VendorID;

            //        //VndrAddrescb.Text = VendorAddress;
            //        //VndrNumbercb.Text = VendorNumber;



            //    }
            //}
            //catch (Exception ex)
            //{
                
            //}
            //connection.Close();
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
            Calculate calculate = new Calculate();
            try
            {
                totaltb.Text = calculate.CalculateTotal(Convert.ToDouble(Quantitytb.Text), Convert.ToDouble(Costtb.Text)).ToString();
            }
            catch (Exception)
            {

                
            }








        }

        private void ItemName1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            string q = "select * from Items where Item_Name = '" + ItemName1.Text + "'";
            string i = "Select PurchaseOrderNumber, Item_amount,Approval_Date from LogPurchaseOrder p inner join Items i on p.Items_id = i.Item_id where Item_name = '" + ItemName1.Text + "'";
            string a = "select Vendorname, VendorAddress, VendorNumber from Vendors v inner join LogPurchaseOrder p on p.Vendor_id = v.Vendors_id inner join Items i on p.Items_id = i.Item_id where Item_name = '" + ItemName1.Text + "'";

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
                Itemname1 = sqlData[1].ToString();
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
                bool gotData = true;
                string VendorName = sqlData2.GetString(0);
                string Address = sqlData2.GetString(1);

                //int number = sqlData2.GetInt32(2);


                Vendorcb.Text = VendorName;
                //VndrAddrescb.Text = Address;
                //VndrNumbercb.Text = Convert.ToString(number);
                int newIndex = ItemName1.SelectedIndex;

                if (gotData == false)
                {
                    MessageBox.Show("Vendor Doesn't Exist");
                }



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

        private void Approvaldate_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");
            connection.Open();
            string q = "select Approval_Date from LogPurchaseOrder";

            SqlCommand command = new SqlCommand(q, connection);

            SqlDataReader sqlData = command.ExecuteReader();


            while (sqlData.Read())
            {
                ApproveDate = sqlData[0].ToString();
            }


        }

        private void viewReportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewReport viewreport = new ViewReport();
            viewreport.Show();
        }
    }
}


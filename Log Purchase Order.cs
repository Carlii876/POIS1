using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace POIS1
{
    public partial class Log_Purchase_Order : Form
    {

        string VendorID;
        string VendorName;
        string status_id;
        string ItemsId;
        string CurrencyId;
        public string LogPOrderId;
        public long VNumber;
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
        public string PurchaseOrderNumber1;
        public int Quantity2;


        private readonly POISEntities PoisEntities;


        public Log_Purchase_Order()
        {
            InitializeComponent();
            PoisEntities = new POISEntities();
        }



        private void Log_Purchase_Order_Load(object sender, EventArgs e)

        {
            Vendorcombobox();
            PurchaseOrderStatus();
            autofillVendors();
            addcurrency();
            autofillItems();
            Itemscombobox();






            
            settingspanel.Visible = false;

            LogInvbtn.ForeColor = Color.White;
            Calculationbtn.ForeColor = Color.White;
            
            Homebtn.ForeColor = Color.White;

            LogPObtn.ForeColor = Color.Black;

            LogInvbtn.BackColor = Color.FromArgb(0, 117, 190);
            Calculationbtn.BackColor = Color.FromArgb(0, 117, 190);
           
            Homebtn.BackColor = Color.FromArgb(0, 117, 190);

            LogPObtn.BackColor = Color.White;
            homeicon.BackColor = Color.FromArgb(0, 117, 190);
            LogPObtn.FlatStyle = FlatStyle.Standard;
            Homebtn.FlatStyle = FlatStyle.Flat;
            LogInvbtn.FlatStyle = FlatStyle.Flat;
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
        public void autofillItems()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            string q = "select * from Items";

            SqlCommand command1 = new SqlCommand(q, connection);
            //SqlDataReader datareader = command.ExecuteReader();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            try
            {
                connection.Open();
                SqlDataReader sqlData = command1.ExecuteReader();

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
        public void PurchaseOrderStatus()
        {

            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            string q = "select * from PurchaseOrderStatus";
            SqlCommand command = new SqlCommand(q, connection);
            //DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader sqlData = command.ExecuteReader();

                while (sqlData.Read())
                {
                    string Statustype = sqlData.GetString(1);
                    POstatuscb.Items.Add(Statustype);
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
        private void helplogo_Click(object sender, EventArgs e)
        {
            Saveinput saveinput = new Saveinput();
            MessageBox.Show(saveinput.help);
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            Home_Page home_Page = new Home_Page();
            this.Hide();
            home_Page.Show();


        }
        private void LogPObtn_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Log Purchase Order window will be reloaded, are you sure?", "Reload", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                Log_Purchase_Order log_Purchase = new Log_Purchase_Order();
                this.Hide();
                log_Purchase.Show();
            }
            LogInvbtn.ForeColor = Color.White;
            Calculationbtn.ForeColor = Color.White;
           
            Homebtn.ForeColor = Color.White;

            LogPObtn.ForeColor = Color.Black;

            LogInvbtn.BackColor = Color.FromArgb(0, 117, 190);
            Calculationbtn.BackColor = Color.FromArgb(0, 117, 190);
           
            Homebtn.BackColor = Color.FromArgb(0, 117, 190);

            LogPObtn.BackColor = Color.White;
            homeicon.BackColor = Color.FromArgb(0, 117, 190);
            LogPObtn.FlatStyle = FlatStyle.Standard;
            Homebtn.FlatStyle = FlatStyle.Flat;
            LogInvbtn.FlatStyle = FlatStyle.Flat;
            Calculationbtn.FlatStyle = FlatStyle.Flat;
           
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

       

        private void homeicon_Click(object sender, EventArgs e)
        {
            Home_Page home_Page = new Home_Page();
            this.Hide();
            home_Page.Show();

        }

        private void themebtn_Click(object sender, EventArgs e)
        {
            settingspanel.Visible = false;
            if (poislogo.BackColor == Color.LightSkyBlue)
            {
                Clearbtn.BackColor = Color.White;
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
                POnumberlbl.BackColor = Color.White;
                POstatuslbl.BackColor = Color.White;
                Totallbl.BackColor = Color.White;
                totalcurrencylb.BackColor = Color.White;
                saveicon.BackColor = Color.White;
                totalcurrencylb.BackColor = Color.White;

                poislogo.BackColor = Color.White;
                toppanel.BackColor = Color.FromArgb(0, 117, 214);
            }

            else if (poislogo.BackColor == Color.White)
            {
                Clearbtn.BackColor = Color.LightSkyBlue;
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
                POnumberlbl.BackColor = Color.LightSkyBlue;
                POstatuslbl.BackColor = Color.LightSkyBlue;
                Totallbl.BackColor = Color.LightSkyBlue;
                totalcurrencylb.BackColor = Color.LightSkyBlue;
                saveicon.BackColor = Color.LightSkyBlue;
                totalcurrencylb.BackColor = Color.LightSkyBlue;

                poislogo.BackColor = Color.LightSkyBlue;
                toppanel.BackColor = Color.FromArgb(0, 117, 190);
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



        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Vendorcb.Text = string.Empty;
            VndrAddrescb.Text = "";
            VndrNumbercb.Text = "";
            ItemName1.Text = "";
            Costtb.Text = "";
            Currencycb.SelectedItem = "";
            Approvaldate.Value = DateTime.Now;
            POnumbertb.Text = "";
            Totaltb.Text = "";
            totalcurrencycb.SelectedItem = "";
            POstatuscb.SelectedItem = "";
            Itemdesctb.Text = "";
            Quantity1.Text = "";
            totalerror.Text = "";
            approvaldatererror.Text = "";
            POstatuserror.Text = "";
            currencyerr.Text = "";
            totalcurrencyerror.Text = "";
            Approvaldateerror.Text = "";
            Currencyerrorlbl.Text = "";
            Totalerrorlb.Text = "";
            costerror.Text = "";
            quatityerror.Text = "";
            purchaseONerror.Text = "";
            quatityerror.Text = "";
            Numbererror.Text = "";
            Vendornameerror.Text = "";
            Addresserror.Text = "";
            Numbererror.Text = "";
            Itemnameerror.Text = "";
            Descriptionerror.Text = "";
            


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
            saveinput.purchaseOrderStatus = POstatuscb.Text;



            saveinput.totalcurrency = totalcurrencycb.Text;

            if (string.IsNullOrEmpty(saveinput.vendorName))
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
            if (string.IsNullOrWhiteSpace(saveinput.itemDescription))
            {
                isValid = false;
                Descriptionerror.Text = "Enter Description. eg 'Stationaries', 'Office Chairs' etc";
            }
            else
            {
                Descriptionerror.Text = "";
            }

            if (string.IsNullOrWhiteSpace(saveinput.currency))
            {
                currencyerr.Text = "Please Select a Currency";
            }

            else
            {
                currencyerr.Text = "";
            }

            if (saveinput.approvedate > DateTime.Now)
            {
                isValid = false;
                Approvaldateerror.Text = "Please Enter Correct Date";

            }
            else
            {
                Approvaldateerror.Text = "";
            }
            if (string.IsNullOrWhiteSpace(saveinput.purchaseOrderStatus))
            {
                POstatuserror.Text = "Please Select a Status";
            }
            else
            {
                POstatuserror.Text = "";
            }
            try
            {
                long vendorNumber = Convert.ToInt64(VndrNumbercb.Text );
                saveinput.cost = Convert.ToDouble(Costtb.Text);

                saveinput.total = Convert.ToInt32(Totaltb.Text);
                saveinput.purchaseOrderNumber = Convert.ToInt32(POnumbertb.Text);
                saveinput.quantity = Convert.ToInt32(Quantity1.Text);

                if (double.IsNaN(saveinput.cost) || saveinput.cost == 0)
                {
                    isValid = false;
                    costerror.Text = "Please Enter a Cost";
                }
                else
                {
                    costerror.Text = "";
                }
                //if (string.IsNullOrEmpty(Convert.ToString(vendorNumber)))
                //{
                //    isValid = false;
                //    Numbererror.Text = "Please Enter Vendors Telephone Number";

                //}
                //else
                //{
                //    Numbererror.Text = "";
                //}
                //if (saveinput.vendorNumber <10 || saveinput.vendorNumber > 11)
                //{
                //    isValid = false;
                //    Numbererror.Text = "Invalid Phone Number";

                //}
                //else
                //{
                //    Numbererror.Text = "";
                //}
                if (saveinput.quantity == 0)
                {
                    isValid = false;
                    quatityerror.Text = "Please Insert the Amount of Items";
                }
                else
                {
                    quatityerror.Text = "";
                }



                if (saveinput.total == 0)
                {
                    isValid = false;
                    //label2.Text = "Please Enter the Purchase Order Total";
                }
                else
                {
                    Totalerrorlb.Text = "";
                }
                if (saveinput.purchaseOrderNumber == 0)
                {

                    purchaseONerror.Text = "Please Enter the Purchase Order Number";
                }
                else
                {
                    purchaseONerror.Text = "";
                }






               
            }
            catch (Exception)
            {
                costerror.Text = "Please Enter a Cost";
                quatityerror.Text = "Please Insert the Amount of Items";
                purchaseONerror.Text = "Please Enter the Purchase Order Number";
                quatityerror.Text = "Please Insert the Amount of Items";
                Numbererror.Text = "Please Enter Vendors Telephone Number";

                MessageBox.Show("Please Enter Correct data");

            }

            if (isValid)
            {



                if ((MessageBox.Show("Do you want to log the purchase order?", "Are You sure", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                {


                    SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");



                    connection.Open();
                    string Q = "insert into LogPurchaseOrder(Vendor_id,Items_id,Item_amount,Status_Id,PurchaseOrderNumber,Approval_Date,CurrencyId,Total)values('" + VendorID + "', '" + ItemsId + "','" + Quantity1.Text + "','" + status_id + "','" + POnumbertb.Text + "','" + saveinput.approvedate + "','" + CurrencyId + "','" + Totaltb.Text + "')";
                    //selectqueries 
                    //MessageBox.Show("Inserted");

                    SqlCommand command = new SqlCommand(Q, connection);

                    command.ExecuteNonQuery();






                    connection.Close();
                }
                MessageBox.Show("Purchase Order Logged");
            }
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

        private void logoutlbl_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                this.Hide();

                POIS login = new POIS();

                login.Show();
            }
        }

        private void Vendorcb_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            string q = "select * from Vendors where VendorName='" + Vendorcb.Text + "'";
            //string V = "select  Vendor_id from Vendors where VendorName '" + Vendorcb.SelectedItem + "')";

            SqlCommand command = new SqlCommand(q, connection);

            //DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader sqlData = command.ExecuteReader();

                while (sqlData.Read())
                {
                    string VendorAddress = sqlData.GetString(2);
                    string VendorNumber = sqlData.GetString(3);
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



        private void Costtb_TextChanged(object sender, EventArgs e)
        {
            Calculate calculate = new Calculate();
            try
            {
                double total = calculate.CalculateTotal(Convert.ToDouble(Quantity1.Text), Convert.ToDouble(Costtb.Text));

                Totaltb.Text = Convert.ToString(total);
            }
            catch (Exception)
            {


            }




        }

        private void Quantity1_TextChanged(object sender, EventArgs e)
        {
            Calculate calculate = new Calculate();
            try
            {
                double total = calculate.CalculateTotal(Convert.ToDouble(Quantity1.Text), Convert.ToDouble(Costtb.Text));

                Totaltb.Text = Convert.ToString(total);
            }
            catch (Exception)
            {


            }






        }

        private void changeThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (poislogo.BackColor == Color.LightSkyBlue)
            {
                Clearbtn.BackColor = Color.White;
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
                POnumberlbl.BackColor = Color.White;
                POstatuslbl.BackColor = Color.White;
                Totallbl.BackColor = Color.White;
                totalcurrencylb.BackColor = Color.White;
                saveicon.BackColor = Color.White;
                totalcurrencylb.BackColor = Color.White;

                poislogo.BackColor = Color.White;
                toppanel.BackColor = Color.FromArgb(0, 117, 214);
            }

            else if (poislogo.BackColor == Color.White)
            {
                Clearbtn.BackColor = Color.LightSkyBlue;
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
                POnumberlbl.BackColor = Color.LightSkyBlue;
                POstatuslbl.BackColor = Color.LightSkyBlue;
                Totallbl.BackColor = Color.LightSkyBlue;
                totalcurrencylb.BackColor = Color.LightSkyBlue;
                saveicon.BackColor = Color.LightSkyBlue;
                totalcurrencylb.BackColor = Color.LightSkyBlue;

                poislogo.BackColor = Color.LightSkyBlue;
                toppanel.BackColor = Color.FromArgb(0, 117, 190);
            }
        }

        private void POstatuscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            string q = "select * from PurchaseOrderStatus";
            string P = "select Status_Id from PurchaseOrdetStatus where Status_type  ('" + POstatuscb.SelectedItem + "')";

            SqlCommand command = new SqlCommand(q, connection);

            //DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader sqlData = command.ExecuteReader();

                while (sqlData.Read())
                {
                    status_id = sqlData[0].ToString();

                    //ItemName1.Text = status_id;
                }
            }

            catch (Exception ex)
            {

            }
            connection.Close();
        }

        private void ItemName1_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            //string Idesc = "select Item_Id from Item where Item_N = '" + ItemName1.Text + "'";


            //SqlCommand command = new SqlCommand(Idesc, connection);




            //    connection.Open();
            //    SqlDataReader sqlData = command.ExecuteReader();

            //    while (sqlData.Read())
            //    {
            //        POnumbertb.Text = sqlData[0].ToString();



            //    }

            //connection.Close();
        }

        private void Itemdesctb_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            //string Idesc = "insert into Items (Item_Description) values  ('" + Itemdesctb + "')";


            //SqlCommand command = new SqlCommand(Idesc, connection);



            //try
            //{
            //    connection.Open();
            //    SqlDataReader sqlData = command.ExecuteReader();

            //    while (sqlData.Read())
            //    {
            //        Idesc = sqlData.GetString(2);



            //    }
            //}

            //catch (Exception ex)
            //{

            //}
            //connection.Close();
        }

        private void totalcurrencycb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");
            string q = "select * from Currency";


            SqlCommand command = new SqlCommand(q, connection);



            try
            {
                connection.Open();
                SqlDataReader sqlData = command.ExecuteReader();

                while (sqlData.Read())
                {
                    CurrencyId = sqlData[0].ToString();


                }
            }

            catch (Exception ex)
            {

            }
            connection.Close();
        }

        private void Currencycb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");
            string q = "select * from Currency";
            string ICurrency = "insert into Items (Currency) values  ('" + Currencycb + "')";

            SqlCommand command = new SqlCommand(q, connection);



            try
            {
                connection.Open();
                SqlDataReader sqlData = command.ExecuteReader();

                while (sqlData.Read())
                {
                    CurrencyId = sqlData[0].ToString();


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            connection.Close();
        }
        public void viewitems()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");
            connection.Open();
            string q = "select * from Items ";




            SqlDataAdapter sqlData = new SqlDataAdapter(q, connection);
            DataTable data = new DataTable();
            sqlData.Fill(data);

            DataGridView dataGrid = new DataGridView();
            dataGrid.DataSource = data;




            connection.Close();



        }
        private void Adddetailsbtn_Click(object sender, EventArgs e)
        {

            bool isValid = false;
            if (ItemName1.Text == "" || Itemdesctb.Text == "" || Quantity1.Text == "" || string.IsNullOrWhiteSpace(Costtb.Text) || Currencycb.Text == "")
            {
                isValid = false;
                MessageBox.Show("Item Details is Missing");
            }


           



            else
            {
                try
                {


                    if ((MessageBox.Show("Do you want to add Item Details?", "Item Details", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                    {

                       

                        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");
                        connection.Open();
                        string q = "insert into Items (Item_Name,Item_Description,Currency,Item_Cost) values  ('" + ItemName1.Text + "', '" + Itemdesctb.Text + "','" + Currencycb.Text + "','" + Costtb.Text + "')";
                        string I = "select Item_id from Items where Item_Name = '" + ItemName1.Text + "'";

                        SqlCommand command = new SqlCommand(q, connection);
                        SqlCommand command1 = new SqlCommand(I, connection);

                        //DataTable dataTable = new DataTable();
                        command.ExecuteNonQuery();

                       

                        SqlDataReader sqlData = command1.ExecuteReader();



                        while (sqlData.Read())
                        {
                            ItemsId = sqlData[0].ToString();
                            

                            //Cost1 = sqlData.GetDouble(4);
                            //Itemdesctb.Text = ItemsId;
                            //ItemName1.Text = status_id;
                        }

                        connection.Close();
                    }
                }

                catch (Exception)
                {

                    throw;
                }
            }


        }







        private void Vendoradd_detailsbtn(object sender, EventArgs e)
        {
           
                SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");
                connection.Open();

                bool isValid = false;
                if (Vendorcb.Text == "" || VndrNumbercb.Text == "" || VndrAddrescb.Text == "")
                {
                    isValid = false;
                    MessageBox.Show("Vendor Details is Missing");
                }

                string s = "select * from Vendors where Vendorname = '" + Vendorcb.Text + "'";
                SqlCommand command4 = new SqlCommand(s, connection);

                SqlDataReader sqlData1 = command4.ExecuteReader();
            while (sqlData1.Read())
            {
                VendorID = sqlData1[0].ToString();
                VendorName = sqlData1.GetString(1);

                //Cost1 = sqlData.GetDouble(4);
                //Itemdesctb.Text = ItemsId;
                //ItemName1.Text = status_id;
            }


            if (Vendorcb.Text == VendorName)
            {
                MessageBox.Show("Vendor details already exist");
            }


            else
            {
                connection.Close();
                if ((MessageBox.Show("Do you want to add Vendor Details?", "Vendor Details", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                {
                    SqlConnection connection1 = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");
                    connection1.Open();





                    string q = "insert into Vendors (Vendorname,VendorAddress,VendorNumber) values  ('" + Vendorcb.Text + "', '" + VndrAddrescb.Text + "','" + VndrNumbercb.Text + "')";
                    
                    SqlCommand command2 = new SqlCommand(q, connection1);
                    

                    
                    SqlDataReader sqlData = command2.ExecuteReader();


                    while (sqlData.Read())
                    {
                        VendorID = sqlData[0].ToString();

                        //Cost1 = sqlData.GetDouble(4);
                        //Itemdesctb.Text = ItemsId;
                        //ItemName1.Text = status_id;
                    }

                    connection1.Close();
                    MessageBox.Show("Vendor Inserted");
                }
            }

           
            


           
        }

        private void ItemsAdddetailsbtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");
            connection.Open();
            bool isValid = false;
            if (ItemName1.Text == "" || Itemdesctb.Text == "" || Quantity1.Text == "" || string.IsNullOrWhiteSpace(Costtb.Text) || Currencycb.Text == "")
            {
                isValid = false;
                MessageBox.Show("Item Details is Missing");
            }

            string s = "select * from Items where Item_Name = '" + ItemName1.Text + "'";
            SqlCommand command4 = new SqlCommand(s, connection);

            SqlDataReader sqlData1 = command4.ExecuteReader();
            while (sqlData1.Read())
            {
                
                Itemname = sqlData1.GetString(1);

                //Cost1 = sqlData.GetDouble(4);
                //Itemdesctb.Text = ItemsId;
                //ItemName1.Text = status_id;
            }


            if (ItemName1.Text == Itemname)
            {
                MessageBox.Show("Item Details already exist");
            }




            else
            {
                try
                {


                    if ((MessageBox.Show("Do you want to add Item Details?", "Item Details", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                    {

                        

                       
                        string q = "insert into Items (Item_Name,Item_Description,Currency,Item_Cost) values  ('" + ItemName1.Text + "', '" + Itemdesctb.Text + "','" + Currencycb.Text + "','" + Costtb.Text + "')";
                        string I = "select Item_id from Items where Item_Name = '" + ItemName1.Text + "'";

                        SqlCommand command = new SqlCommand(q, connection);
                        SqlCommand command1 = new SqlCommand(I, connection);

                        //DataTable dataTable = new DataTable();
                        command.ExecuteNonQuery();



                        SqlDataReader sqlData = command1.ExecuteReader();



                        while (sqlData.Read())
                        {
                            ItemsId = sqlData[0].ToString();


                            //Cost1 = sqlData.GetDouble(4);
                            //Itemdesctb.Text = ItemsId;
                            //ItemName1.Text = status_id;
                        }

                        connection.Close();
                    }
                }

                catch (Exception)
                {

                    throw;
                }
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

                string description = sqlData.GetString(2);
                string currenc = sqlData.GetString(3);
                ItemsId = sqlData[0].ToString();
                double Icost = sqlData.GetDouble(4);


                Currencycb.Text = currenc;
                Costtb.Text = Convert.ToString(Icost);



                Itemdesctb.Text = description;
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
            if ((MessageBox.Show("Log Purchase Order window will be reloaded, are you sure?", "Reload", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                Log_Purchase_Order log_Purchase = new Log_Purchase_Order();
                this.Hide();
                log_Purchase.Show();
            }
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

        private void viewReportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewReport viewreport = new ViewReport();
            viewreport.Show();
        }

        
    }
}


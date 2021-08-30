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
        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            
            //Helplbl.ForeColor = Color.White;
            //Logoutlb.ForeColor = Color.White;


            Reportbtn.ForeColor = Color.White;
            Reportbtn.BackColor = Color.DimGray;
            //PurchaseOrderNumber();

            datagrid();
        }


        public void datagrid()
        {


            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");
            string q = "SELECT LogPurchaseOrder.Vendor as 'Vendor', LogPurchaseOrder.Items as " +
                "'Item Name',LogPurchaseOrder.Quantity as 'Quantity',LogPurchaseOrder.PurchaseOrderNumber as 'PurchaseOrderNumber'," +
                "LogPurchaseOrder.Approval_Date as 'Approval Date'," +
                "LogPurchaseOrder.Status as 'Status',LogPurchaseOrder.Total as " +
                "'Total',Invoices.VendorName as 'Vendor Name',Invoices.ItemName " +
                "as 'Item Name', Invoices.Quantity,Invoices.PurchaseOrderNumber as " +
                "'Purchase Order Number',Invoices.InvoiceNumber as 'Invoice Number',Invoices.ApprovalDate as 'Approval Date',Invoices.DateForPayment as 'Date For Payment'," +
                "Invoices.Status as 'Status',Invoices.Total as 'Total'FROM " +
                "((LogPurchaseOrder INNER JOIN Invoices ON LogPurchaseOrder.PurchaseOrderId = Invoices.PurchaseOrderID) " +
                "INNER JOIN Items ON LogPurchaseOrder.Items_id = Items.Item_id)";


            connection.Open();
            SqlCommand command = new SqlCommand(q, connection);
            command.ExecuteNonQuery();

            SqlDataAdapter sqlData1 = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();


            sqlData1.Fill(dataTable);

            ReportGridView.DataSource = dataTable;
            connection.Close();
        }

        public void Reportcombobox()
        {
            string q = "select Vendor, Items, Quantity, PurchaseOrderNumber, Approval_Date, Status, Total from LogPurchaseOrder  where Approval_Date = '" + Convert.ToDateTime(GenerateReportcb.Text) + "'"; 
            SqlDataAdapter dataAdapter = new SqlDataAdapter(q, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            GenerateReportcb.DataSource = ds.Tables[0];
            connection.Close();

            try
            {
                connection.Open();
                // SqlDataReader sqlData = command.ExecuteReader();

                //while (sqlData.Read())
                //{
                //    string vname = sqlData.GetString(1);
                //    GenerateReportcb.Items.Add(vname);



                //}
            }
            catch (Exception ex)
            {

            }
            connection.Close();

        }

        private void Calculationbtn_Click(object sender, EventArgs e)
        {
            Calculation calculation = new Calculation();
            this.Hide();
            calculation.Show();

        }

        private void LogInvbtn_Click(object sender, EventArgs e)
        {
            Log_Invoice log_Invoice = new Log_Invoice();
            this.Hide();
            log_Invoice.Show();
        }

        private void LogPObtn_Click(object sender, EventArgs e)
        {
            Log_Purchase_Order log_Purchase = new Log_Purchase_Order();
            this.Hide();
            log_Purchase.Show();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            Home_Page home_Page = new Home_Page();
            this.Hide();
            home_Page.Show();
        }

        private void GenerateReportcb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           


            if (GenerateReportcb.Text == "View Purchases")
            {
               
                string q = "select Vendor, Items, Quantity, PurchaseOrderNumber, Approval_Date, Status, Total from LogPurchaseOrder";
                connection.Open();
                SqlCommand command = new SqlCommand(q, connection);
                command.ExecuteNonQuery();

                SqlDataAdapter sqlData1 = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();


                sqlData1.Fill(dataTable);

                ReportGridView.DataSource = dataTable;
                connection.Close();
            }

            else if (GenerateReportcb.Text == "View Invoices")
            {
               
                string q = "select VendorName, ItemName, Quantity, PurchaseOrderNumber, InvoiceNumber, ApprovalDate, DateForPayment, Status, Total from Invoices";
                connection.Open();
                SqlCommand command = new SqlCommand(q, connection);
                command.ExecuteNonQuery();

                SqlDataAdapter sqlData1 = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();


                sqlData1.Fill(dataTable);

                ReportGridView.DataSource = dataTable;
                connection.Close();
            }
             

                    
        }

        public void PurchaseOrderNumber()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            string q = "select Vendor, Items, Quantity, PurchaseOrderNumber, Approval_Date, Status, Total from LogPurchaseOrder";
            SqlCommand command = new SqlCommand(q, connection);
            //DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader sqlData = command.ExecuteReader();

                while (sqlData.Read())
                {
                    string LogPurchase = sqlData[4].ToString();
                    GenerateReportcb.Items.Add(LogPurchase);



                }
            }
            catch (Exception ex)
            {

            }
            connection.Close();
        }


        public void InvoiceNumber()
        {
            

            string q = "select VendorName, ItemName, Quantity, PurchaseOrderNumber, InvoiceNumber, ApprovalDate, DateForPayment, Status, Total from Invoices";
            SqlCommand command = new SqlCommand(q, connection);
            //DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader sqlData = command.ExecuteReader();

                while (sqlData.Read())
                {
                    string Invoice = sqlData[4].ToString();
                    GenerateReportcb.Items.Add(Invoice);



                }
            }
            catch (Exception ex)
            {

            }
            connection.Close();
        }

        private void Reportbtn_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Report window will be reloaded, are you sure?", "Reload", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                Report report = new Report();
                this.Hide();
                report.Show();
            }
        }

        private void changeThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poislogo.BackColor == Color.LightSkyBlue)
            {
                VenderNamelbl.BackColor = Color.DimGray;
                poislogo.BackColor = Color.DimGray;
                ReportGridView.BackgroundColor = Color.DimGray;
                Reportbtn.BackColor = Color.DimGray;
                Reportbtn.IconColor = Color.White;
                Reportbtn.ForeColor = Color.White;
            }

            else if (poislogo.BackColor == Color.White)
            {
                VenderNamelbl.BackColor = Color.LightSkyBlue;
                poislogo.BackColor = Color.LightSkyBlue;
                ReportGridView.BackgroundColor = Color.LightSkyBlue;
                

                Reportbtn.BackColor = Color.LightSkyBlue;
                Reportbtn.IconColor = Color.White;
                Reportbtn.ForeColor = Color.White;
            }
            else if (poislogo.BackColor == Color.DimGray)
            {
                VenderNamelbl.BackColor = Color.White;
                poislogo.BackColor = Color.White;
                ReportGridView.BackgroundColor = Color.White;
                

                Reportbtn.BackColor = Color.White;
                Reportbtn.IconColor = Color.Black;
                Reportbtn.ForeColor = Color.Black;
            }

        }
        
        private void viewReportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewReport viewreport = new ViewReport();
            viewreport.Show();
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            datagrid();
            GenerateReportcb.Text = "";
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {


            //SqlConnection connection2 = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");



            try
            {
                string w = "select Vendor, Items, Quantity, PurchaseOrderNumber, Approval_Date, Status, Total from LogPurchaseOrder where PurchaseOrderNumber =  '" + GenerateReportcb.Text + "'";
                connection.Open();
                SqlCommand command = new SqlCommand(w, connection);
                command.ExecuteNonQuery();

                SqlDataAdapter sqlData1 = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();


                sqlData1.Fill(dataTable);

                ReportGridView.DataSource = dataTable;
                connection.Close();

            }
            catch (Exception)
            {

                throw;
            }


            //SqlConnection connection1 = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            //try
            //{

            //    string r = "select Vendor, Items, Quantity, PurchaseOrderNumber, Approval_Date, Status, Total from Invoices where InvoiceNumber =  '" + GenerateReportcb.Text + "'";
            //    connection1.Open();
            //    SqlCommand command1 = new SqlCommand(r, connection1);
            //    command1.ExecuteNonQuery();

            //    SqlDataAdapter sqlData = new SqlDataAdapter(command1);
            //    DataTable dataTable1 = new DataTable();


            //    sqlData.Fill(dataTable1);

            //    ReportGridView.DataSource = dataTable1;
            //    connection1.Close();

            //}
            //catch (Exception)
            //{

            //    throw;
            //}






        }

        private void searchicon_Click(object sender, EventArgs e)
        {
            SqlConnection connection1 = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");

            try
            {

                string r = "select VendorName, ItemName, Quantity, PurchaseOrderNumber, InvoiceNumber, ApprovalDate, DateForPayment, Status, Total from Invoices where InvoiceNumber =  '" + GenerateReportcb.Text + "'";
                connection1.Open();
                SqlCommand command1 = new SqlCommand(r, connection1);
                command1.ExecuteNonQuery();

                SqlDataAdapter sqlData = new SqlDataAdapter(command1);
                DataTable dataTable1 = new DataTable();


                sqlData.Fill(dataTable1);

                ReportGridView.DataSource = dataTable1;
                connection1.Close();

            }
            catch (Exception)
            {

                throw;
            }



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
    }
}

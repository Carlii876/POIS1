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
    public partial class ViewReport : Form
    {
        public ViewReport()
        {
            InitializeComponent();
        }

        private void ViewReport_Load(object sender, EventArgs e)
        {
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

            ReportdataGridView.DataSource = dataTable;
            connection.Close();
        }

        private void alldataview()
        {

        }
    }
}

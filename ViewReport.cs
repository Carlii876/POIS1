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
            string q = "SELECT LogPurchaseOrder.PurchaseOrderId as 'Purchase Order ID', LogPurchaseOrder.Vendor_id as " +
                "'Vendor ID',LogPurchaseOrder.Items_id as 'Items id',LogPurchaseOrder.Item_amount as 'Item Amount'," +
                "LogPurchaseOrder.Status_Id as 'Purchaser Order Status Id'," +
                "LogPurchaseOrder.PurchaseOrderNumber as 'Purchase Order Number',LogPurchaseOrder.Approval_Date as " +
                "'Approval Date',LogPurchaseOrder.Total,Invoices.Invoice_id as 'Invoice ID',Invoices.DateForPayment " +
                "as 'Date For Payment', Items.Currency,Invoices.total as " +
                "'Invoice Total',Invoices.Status_Id 'Invoice Status Id',Invoices.InvoiceNumber as 'Invoice Number'FROM " +
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

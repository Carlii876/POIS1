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
    public partial class View_Purchase_Order : Form
    {
        public View_Purchase_Order()
        {
            InitializeComponent();
        }

        private void View_Purchase_Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOISDataSet2.LogPurchaseOrder' table. You can move, or remove it, as needed.
            //this.logPurchaseOrderTableAdapter.Fill(this.pOISDataSet2.LogPurchaseOrder);
            datagrid();
        }
        public void datagrid()
        {


            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");
            string q = "select * from Invoices";
            connection.Open();
            SqlCommand command = new SqlCommand(q, connection);
            command.ExecuteNonQuery();

            SqlDataAdapter sqlData1 = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();


            sqlData1.Fill(dataTable);

            POrderdataview.DataSource = dataTable;
            connection.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POIS1
{
    public partial class View_Invoices : Form
    {
        public View_Invoices()
        {
            InitializeComponent();
        }

        private void View_Invoices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOISDataSet1.Invoices' table. You can move, or remove it, as needed.
            //this.invoicesTableAdapter.Fill(this.pOISDataSet1.Invoices);

        }
    }
}

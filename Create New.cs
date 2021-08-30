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
    public partial class Create_New : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");
        public Create_New()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand command = new SqlCommand("sp_role_login", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
               // command.Parameters.AddWithValue("@Uname",)
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}

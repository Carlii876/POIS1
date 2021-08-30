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
    public partial class POIS : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=POIS;Integrated Security=True");
        public string type;
        public static class manage
        {
            public static string type;
        }
        
        
        public POIS()
        {
            InitializeComponent();
        }
        //public static string welcomeuser;
        private void POIS_Load(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = false;
            iconButton1.Visible = false;
            usernametb.ForeColor = Color.LightGray;
            passwordtb.ForeColor = Color.LightGray;

        }
        private void Clearrbtn_Click(object sender, EventArgs e)
        {
            //if (usernametb.Text == "Enter Username" && passwordtb.Text == "Enter Password")
            //{
            //    usernametb.Text = "Enter Username";
            //    passwordtb.Text = "Enter Password";
            //}
            //else
            //{
            //    usernametb.Text = "Enter Username";
            //    passwordtb.Text = "Enter Password";
            //    usernametb.ForeColor = Color.LightGray;
            //    passwordtb.ForeColor = Color.LightGray;
            //    passwordtb.PasswordChar = '\0';

            //}
        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            
            try
            {

                SqlCommand command = new SqlCommand("sp_role_login", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.Parameters.AddWithValue("@Uname", usernametb.Text);
                command.Parameters.AddWithValue("@Pword", passwordtb.Text);

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();

                    if(dataReader[3].ToString()=="admin")
                    {
                        manage.type = "admin";
                    } 
                    else if(dataReader[3].ToString()=="user")
                    {
                        manage.type = "user";
                    }
                    

                    Home_Page home = new Home_Page();
                    this.Hide();
                    home.Show();
                }
               
                else
                {
                    MessageBox.Show("Incorrect Username and Password");
                }
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            //bool isValid = true;
            //string Username = usernametb.Text;
            //string Password = passwordtb.Text;

            //if (string.IsNullOrEmpty(Username) || usernametb.Text == "Enter Username")
            //{
            //    isValid = false;
            //    usernameerror.Text = "Please Enter a Username";

            //}
            
            //else
            //{
            //    usernameerror.Text = "";
                
            //}
            //if (string.IsNullOrEmpty(Password) || Password == "Enter Password")
            //{
            //    isValid = false;
            //    usernameerror.Text = "Please Enter a Username";

            //}
            //else
            //{
            //    Passworderror.Text = "";
            //}
            //if (Username != "Admin" || Password != "Password")
            //{
            //    isValid = false;
            //    MessageBox.Show("Incorrect Username or Password");

            //}
            //if(Username != "Admin")
            //{
            //    usernameerror.Text = "Please Enter Correct Username";
            //}
            //else
            //{
            //    usernameerror.Text = "";
            //}

            //if (Password != "Password")
            //{
            //    Passworderror.Text = "Please Enter Correct Password";
            //}
            //else
            //{
            //    usernameerror.Text = "";
            //}





            //if (string.IsNullOrEmpty(Password) || passwordtb.Text == "Enter Password")
            //{
            //    isValid = false;
            //    Passworderror.Text = "Please Enter a Password";
            //}
            //else
            //{
            //    Passworderror.Text = string.Empty;
            //}
            //if (Username == "Admin" && Password == "Password")
            //{
            //    Home_Page homepage = new Home_Page();
            //    this.Hide();
            //    homepage.Show();

            //}
        }


        private void usernametb_MouseClick(object sender, MouseEventArgs e)
        {

            usernametb.ForeColor = Color.Black;

            if (usernametb.Text == "Enter Username")
            {
                usernametb.Text = string.Empty;
                usernametb.ForeColor = Color.Black;
            }
            if (passwordtb.Text == "")
            {
                passwordtb.Text = "Enter Password";
                passwordtb.ForeColor = Color.LightGray;
               
            }

        }
        private void passwordtb_MouseClick(object sender, MouseEventArgs e)
        {

            passwordtb.ForeColor = Color.Black;

            if (passwordtb.Text == "Enter Password")
            {
                passwordtb.Text = string.Empty;
                passwordtb.ForeColor = Color.Black;
                passwordtb.PasswordChar = '*';
            }
            if (usernametb.Text == "")
            {
                usernametb.Text = "Enter Username";
                usernametb.ForeColor = Color.LightGray;
              
            }




        }
        private void passwordtb_MouseLeave(object sender, EventArgs e)
        {
            //if (passwordtb.Text == "")
            //{

            //    passwordtb.Text = "Enter Password";
            //    passwordtb.ForeColor = Color.LightGray;
            //    passwordtb.PasswordChar = '\0';


            //}

        }
        private void usernametb_MouseLeave(object sender, EventArgs e)
        {
            //if (usernametb.Text == "")
            //{
            //    usernametb.Text = "Enter Username";
            //    usernametb.ForeColor = Color.LightGray;
            //}



        }

        private void usernametb_KeyPress(object sender, KeyPressEventArgs e)
        {
            usernametb.ForeColor = Color.Black;
        }

        private void passwordtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            passwordtb.ForeColor = Color.Black;
            passwordtb.PasswordChar = '*';

        }

        private void passwordtb_MouseHover(object sender, EventArgs e)
        {
            if (passwordtb.Text == "Enter Password")
            {
                passwordtb.Text = "";
                passwordtb.ForeColor = Color.Black;
                passwordtb.PasswordChar = '*';

            }



        }

        private void forgetPbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Contact Admin");
        }

        private void usernametb_TextChanged(object sender, EventArgs e)
        {
            usernameerror.Text = "";
           
        }

        private void passwordtb_TextChanged(object sender, EventArgs e)
        {
           
            Passworderror.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eyeicon_MouseHover(object sender, EventArgs e)
        {
            eyeicon.BackColor = Color.White;
        }

        private void eyeicon_Click(object sender, EventArgs e)
        {
            if (iconButton1.Visible == false)
            {
                iconButton1.Visible = true;
            }
            passwordtb.PasswordChar = '\0';
            eyeicon.Visible = false;
            iconButton1.Visible = true;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (eyeicon.Visible == true)
            {
                eyeicon.Visible = false;
            }


            passwordtb.PasswordChar = '*';
            iconButton1.Visible = false;
            eyeicon.Visible = true;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void forgetPbtn_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void forgetPbtn_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }
    }
}

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
    public partial class POIS : Form
    {
        public POIS()
        {
            InitializeComponent();
        }
        //public static string welcomeuser;
        private void POIS_Load(object sender, EventArgs e)
        {

            usernametb.ForeColor = Color.LightGray;
            passwordtb.ForeColor = Color.LightGray;

        }
        private void Clearrbtn_Click(object sender, EventArgs e)
        {
            if (usernametb.Text == "Enter Username" && passwordtb.Text == "Enter Password")
            {
                usernametb.Text = "Enter Username";
                passwordtb.Text = "Enter Password";
            }
            else
            {
                usernametb.Text = "Enter Username";
                passwordtb.Text = "Enter Password";
                usernametb.ForeColor = Color.LightGray;
                passwordtb.ForeColor = Color.LightGray;
                passwordtb.PasswordChar = '\0';

            }
        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {

            bool isValid = true;
            string Username = usernametb.Text;
            string Password = passwordtb.Text;

            if (string.IsNullOrEmpty(Username) || usernametb.Text == "Enter Username")
            {
                isValid = false;
                usernameerror.Text = "Please Enter a Username";

            }
            else
            {
                usernameerror.Text = "";
            }
            if (Username != "Admin" || Password != "Password")
            {
                isValid = false;
                MessageBox.Show("Incorrect Username or Password");

            }
            if(Username != "Admin")
            {
                usernameerror.Text = "Please Enter Correct Username";
            }
            else
            {
                usernameerror.Text = "";
            }

            if (Password != "Password")
            {
                Passworderror.Text = "Please Enter Correct Password";
            }
            else
            {
                usernameerror.Text = "";
            }





            if (string.IsNullOrEmpty(Password) || passwordtb.Text == "Enter Password")
            {
                isValid = false;
                Passworderror.Text = "Please Enter a Password";
            }
            else
            {
                Passworderror.Text = string.Empty;
            }
            if (Username == "Admin" && Password == "Password")
            {
                Home_Page homepage = new Home_Page();
                this.Hide();
                homepage.Show();

            }
        }


        private void usernametb_MouseClick(object sender, MouseEventArgs e)
        {

            usernametb.ForeColor = Color.Black;

            if (usernametb.Text == "Enter Username")
            {
                usernametb.Text = string.Empty;
                usernametb.ForeColor = Color.Black;
            }
            /*else if(usernametb.Text != "Enter Username")
            {
                usernametb.ForeColor = Color.Black;
            }*/

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




        }
        private void passwordtb_MouseLeave(object sender, EventArgs e)
        {
            if (passwordtb.Text == "")
            {

                passwordtb.Text = "Enter Password";
                passwordtb.ForeColor = Color.LightGray;
                passwordtb.PasswordChar = '\0';


            }

        }
        private void usernametb_MouseLeave(object sender, EventArgs e)
        {
            if (usernametb.Text == "")
            {
                usernametb.Text = "Enter Username";
                usernametb.ForeColor = Color.LightGray;
            }



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
    }
}

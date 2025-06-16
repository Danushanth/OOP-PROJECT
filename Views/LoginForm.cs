using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Student");
            comboBox1.Items.Add("Lectures");
            comboBox1.Items.Add("Staff");
            comboBox1.SelectedIndex = 0;

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void OnLogin(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            // Hardcoded credentials
            string validUsername = "Danushanth";
            string validPassword = "123456";

            if (username == validUsername && password == validPassword)
            {
                // Success — open MainForm
               Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                //Credentials credentials = new Credentials();
                //credentials.Username = username;
                //credentials.Password = password;
                ////var result = _userController.Login(credentials);
                //if (result)
                //{
                //    Form1 form1 = new Form1();
                //    form1.Show();
                //    this.Hide();
                //}
                //else
                //{
                //    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //    // Optionally clear fields
                //    txtUserName.Clear();
                //    txtUserName.Focus();

                }
            }
        // Login Form============================================================================================================================================================
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                string username = txtUserName.Text.Trim();
                string password = txtPassword.Text;

               
                string validUsername = "Danushanth";
                string validPassword = "123456";

                if (username == validUsername && password == validPassword)
                {
                    Form1 form1 = new Form1();
                    form1.Show();     
                    this.Hide();      
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    }
    


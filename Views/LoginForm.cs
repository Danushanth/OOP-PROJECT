using System;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            //comboBox1.Items.Add("select your Role");
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Student");
            comboBox1.Items.Add("Lectures");
            comboBox1.Items.Add("Staff");
            comboBox1.SelectedIndex = 0; 
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;
            string selectedRole = comboBox1.SelectedItem.ToString();

            
            string validUsername = "Danushanth";
            string validPassword = "123456";

            if (username == validUsername && password == validPassword)
            {
                switch (selectedRole)
                {
                    case "Admin":
                        Form1 adminForm = new Form1();
                        adminForm.Show();
                        break;

                    case "Student":
                        ManageStudent studentForm = new ManageStudent(); 
                        studentForm.Show();
                        break;

                    case "Lectures":
                        ManageLecture lectureForm = new ManageLecture(); 
                        lectureForm.Show();
                        break;

                    case "Staff":
                        ManageStaff staffForm = new ManageStaff(); 
                        break;

                    default:
                        MessageBox.Show("Invalid role selected");
                        return;
                }

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



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {          
        }
        private void label3_Click(object sender, EventArgs e)
        {          
        }
    }
}

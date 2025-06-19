using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Views;

namespace UnicomTICManagementSystem
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
           // LoadForm(new Form1());
        }

        // ===========================================================================================================================
        public void LoadForm(object formObj)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }

            Form form = formObj as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form);
            this.mainPanel.Tag = form;
            form.Show();
        }
        // ==============================================================================================================================
        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRoleBasedForm();
           
        }
        private void LoadRoleBasedForm()
        {
            Form childForm = null;

            switch (UserSession.Role)
            {
                case "Admin":
                    childForm = new AdminForm(); // Or dashboard for admin
                    break;
                case "Student":
                    childForm = new ManageStudent();
                    break;
                case "Lectures":
                    childForm = new ManageLecture();
                    break;
                case "Staff":
                    childForm = new ManageStaff();
                    break;
                default:
                    MessageBox.Show("Invalid role");
                    return;
            }

            if (childForm != null)
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                DashBoard.Controls.Clear();      // clear old controls if any
                DashBoard.Controls.Add(childForm); // add new form
                childForm.Show();              // show it
            }
        }

        //==================================================================================================================================

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Login Form: " + ex.Message);
            }
        }



        // LECTURN ===========================================================================================================================
        private void button3_Click(object sender, EventArgs e)
        {
           LoadFormInPanel(new ManageLecture());
        }
        // STAFF =============================================================================================================================
        private void button4_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ManageStaff());
        }
        // STUDENT ===========================================================================================================================

        private void button5_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "Admin" || UserSession.Role == "Student")
            {
                ManageStudent studentForm = new ManageStudent();
                studentForm.TopLevel = false;
                studentForm.FormBorderStyle = FormBorderStyle.None;
                studentForm.Dock = DockStyle.Fill;

                DashBoard.Controls.Clear();       // panelMain = Panel in Form1
                DashBoard.Controls.Add(studentForm);
                studentForm.Show();
            }
            else
            {
                MessageBox.Show("Access Denied", "Permission Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }


        private void LoadFormInPanel2(Form frm)
        {
            mainPanel.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(frm);
            frm.Show();
        }

        private void LoadFormInPanel1(Form frm)
        {
            mainPanel.Controls.Clear(); 
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(frm); 
            frm.Show(); 
        }
        
        private void LoadFormInPanel(Form frm)
        {
            DashBoard.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            DashBoard.Controls.Add(frm);
            frm.Show();
        }





        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel(new ManageCoursesForm());
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel(new ManageSubjectsForm());
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel(new ManageTimetable());
        }
    }

}

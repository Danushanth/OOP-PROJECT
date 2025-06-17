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
            LoadForm(new MainForm());
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
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
            LoadFormInPanel(new ManageStudent());
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }
        // ===================================================================================================================================
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

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Views
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            LoadForm(new AdminForm());
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
          
        }
        

        public void LoadForm(object formObj)
        {
            if (this.AdminPanel.Controls.Count > 0)
            {
                this.AdminPanel.Controls.RemoveAt(0);
            }

            ManageStudent form = formObj as ManageStudent;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.AdminPanel.Controls.Add(form);
            this.AdminPanel.Tag = form;
            form.Show();
        }



        private void AdminPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ManageLecture());
        }

        private void LoadFormInPanel(ManageLecture manageLecture)
        {
            throw new NotImplementedException();
        }

        private void LoadFormInPanel1(AdminForm frm)
        {
            AdminPanel.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            AdminPanel.Controls.Add(frm);
            frm.Show();
        }
        private void LoadFormInPanel(AdminForm frm)
        {
            AdminPanel.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            AdminPanel.Controls.Add(frm);
            frm.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ManageStaff());
        }

        private void LoadFormInPanel(ManageStaff manageStaff)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadFormInPanel(ManageStudent manageStudent)
        {
            throw new NotImplementedException();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel(new ManageLecture());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ManageStudent());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ManageStaff());
        }

        private void button7_Click(object sender, EventArgs e)
        {
           // LoadFormInPanel(new ManageCoursesForm());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //LoadFormInPanel(new ManageSubjectsForm());
        }
    }
}

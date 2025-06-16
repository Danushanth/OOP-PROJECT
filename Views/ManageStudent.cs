using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Views
{
    public partial class ManageStudent : Form
    {
        private int updateStudentId;

        //public string Address { get; private set; }

        public ManageStudent()
        {
            InitializeComponent();
            
            

            StudentController stcontroller = new StudentController();
            List<Student> st = stcontroller.GetStudents();
            DgvStudent.DataSource = st;

            txtN.Text = "";
            txtA.Text = "";
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        // ADD ===================================================================================================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            if (string.IsNullOrWhiteSpace(txtN.Text) || string .IsNullOrWhiteSpace(txtA.Text))
            {
                MessageBox.Show("Please Enter the Both name and Address");
                return;
            }
            student.Name = txtN.Text;
            student.Address = txtA.Text;


            StudentController studentController =new StudentController();
            string outputmessage = studentController.AddStudent(student);
            DgvStudent.DataSource = studentController;

        }
        // UPDATE =================================================================================================

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Id = updateStudentId;
            student.Name = txtN.Text;
            student.Address = txtA.Text;

            StudentController stcontroller = new StudentController();
            string updateMessage = stcontroller.UpdateStudent(student);
            MessageBox.Show(updateMessage);

            txtN.Text = "";
            txtA.Text = "";
            List<Student> st = stcontroller.GetAllStudents();
            DgvStudent.DataSource = st;
        }
        // DELETE ===================================================================================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Id = updateStudentId;

            StudentController stcontroller = new StudentController();
            string deleteMessage = stcontroller.deleteStudent(student);
            MessageBox.Show(deleteMessage);

            txtN.Text = "";
            txtA.Text = "";
            List<Student> st = stcontroller.GetAllStudents();
            DgvStudent.DataSource = st;
        }
        // DGV BOX ===================================================================================================
        private void DgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = (Student)DgvStudent.CurrentRow.DataBoundItem;
            if (student != null)
            {
                updateStudentId = student.Id;
                txtN.Text = student.Name;
                txtA.Text = student.Address;
            }
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {

        }
    }
}

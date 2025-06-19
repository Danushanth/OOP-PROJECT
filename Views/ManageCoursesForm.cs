using System;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class ManageCoursesForm : Form
    {
        private readonly CourseController _controller = new CourseController();

        public ManageCoursesForm()
        {
            InitializeComponent();
            LoadCourses();
            comboBox1.Items.Add("Software develaper");
            comboBox1.Items.Add("Software Engneear");
            comboBox1.Items.Add("Web Development ");
            comboBox1.Items.Add("Cybersecurity");
            comboBox1.Items.Add("Artificial Intelligence");

            if (UserSession.Role != "Admin")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void LoadCourses()
        {
            dgvCourses.DataSource = null;
            dgvCourses.DataSource = _controller.GetAllCourses();
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
        //  ============================================================== ADD ==================================================================================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comboBox1.Text))
            {
               // _controller.AddCourse(txtCourseName.Text.Trim());
                LoadCourses();
                comboBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter a course name.");
            }
        }
        //  =================================================================== UPDATE ===========================================================================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCourses.CurrentRow != null && !string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                int courseId = (int)dgvCourses.CurrentRow.Cells["CourseId"].Value;
               // _controller.UpdateCourse(courseId, txtCourseName.Text.Trim());
                LoadCourses();
                comboBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Please select a course and enter a new name.");
            }
        }
        //======================================================================= DELETE ======================================================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCourses.CurrentRow != null)
            {
                int courseId = (int)dgvCourses.CurrentRow.Cells["CourseId"].Value;

                var result = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                   
                    LoadCourses();
                    comboBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please select a course to delete.");
            }
        }

       // ======================================================================================================================================================

        private void ManageCoursesForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCourses.CurrentRow != null)
            {
                comboBox1.Text = dgvCourses.CurrentRow.Cells["CourseName"].Value.ToString();
            }
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
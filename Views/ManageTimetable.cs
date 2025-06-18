using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTicManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Views
{
    public partial class ManageTimetable : Form
    {
         private int selectedTimetableId = 0;
        public ManageTimetable()
        {
            InitializeComponent();
        }

        private void ManageTimetable_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadRoomTypes();
            LoadTimetables();
        }
        private void LoadCourses()
        {
            using (var cmd = DbConfig.GetConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT CourseID, CourseName FROM Courses";
                DataTable dt = new DataTable();
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                cmdCourse.DataSource = dt;
                cmdCourse.DisplayMember = "CourseName";
                cmdCourse.ValueMember = "CourseId";
            }
        }

        //=========================================================== ROOM TYPE ====================================================================================
        private void LoadRoomTypes()
        {
            using (var cmd = DbConfig.GetConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT DISTINCT RoomType FROM Rooms";
                using (var reader = cmd.ExecuteReader())
                {
                    cmdroomtype.Items.Clear();
                    while (reader.Read())
                    {
                        cmdroomtype.Items.Add(reader["RoomType"].ToString());
                    }
                }
            }
        }

        private void LoadTimetables()
        {
            dgvtimetable.DataSource = null;
            dgvtimetable.DataSource = TimetableController.GetAllTimetables();
        }

        // ====================================================================== ADD ======================================================================================
        private void btnadd_Click(object sender, EventArgs e)
        {
            int subjectId = Convert.ToInt32(cmdSubject.SelectedValue);
            string timeSlot = txtTimeslot.Text;
            string roomType = cmdroomtype.Text;  

            TimetableController.AddTimetable(subjectId, roomType, timeSlot);
            MessageBox.Show("Timetable added successfully.");
            LoadTimetables();
        }

        // ===================================================================== UPDATE ==================================================================================== 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedTimetableId == 0)
            {
                MessageBox.Show("Please select a timetable to update.");
                return;
            }

            int subjectId = Convert.ToInt32(cmdSubject.SelectedValue);
            string timeSlot = txtTimeslot.Text;
            string roomType = cmdroomtype.Text; 

            TimetableController.UpdateTimetable(selectedTimetableId, subjectId, roomType, timeSlot);
            MessageBox.Show("Timetable updated successfully.");
            LoadTimetables();
        }

        // ===================================================================== DELETE ======================================================================================

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedTimetableId == 0)
            {
                MessageBox.Show("Please select a timetable to delete.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this timetable?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TimetableController.DeleteTimetable(selectedTimetableId);
                MessageBox.Show("Timetable deleted successfully.");
                LoadTimetables();
            }
        }

        // ====================================================================== DGV BOX ======================================================================================
        private void dgvtimetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvtimetable.Rows[e.RowIndex];
                selectedTimetableId = Convert.ToInt32(row.Cells["Id"].Value);
                cmdCourse.Text = row.Cells["Course"].Value.ToString();
                cmdSubject.Text = row.Cells["Subject"].Value.ToString();
                cmdroomtype.Text = row.Cells["RoomType"].Value.ToString();
                txtTimeslot.Text = row.Cells["TimeSlot"].Value.ToString();
            }
        }

        // ======================================================================= CMD COURSE ===================================================================================

        private void cmdCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int courseId;
            if (int.TryParse(cmdCourse.SelectedValue.ToString(), out courseId))
            {
                using (var cmd = DbConfig.GetConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT SubjectID, SubjectName FROM Subjects WHERE CourseID = @id";
                    cmd.Parameters.AddWithValue("@id", courseId);
                    DataTable dt = new DataTable();
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    cmdSubject.DataSource = dt;
                    cmdSubject.DisplayMember = "SubjectName";
                    cmdSubject.ValueMember = "SubjectID";
                }
            }
        }
    }
}

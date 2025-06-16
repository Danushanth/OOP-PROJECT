using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class StudentController

    {
        // Add =================================================================================================================================================================
        public string AddStudent(Student st)
        {
            using (var dbconn = DbConfig.Connection())
            {
                dbconn.Open();

                string addstudentQuery = "INSERT INTO Students(Name, Address, Age, UserName) VALUES(@name, @address, @age, @username);";

                using (SQLiteCommand insert = new SQLiteCommand(addstudentQuery, dbconn))
                {
                    insert.Parameters.AddWithValue("@name", st.Name);
                    insert.Parameters.AddWithValue("@address", st.Address);
                    insert.Parameters.AddWithValue("@age", st.Age);
                    insert.Parameters.AddWithValue("@username", st.UserName);

                     insert.ExecuteNonQuery();
                }
            }
            return "Student added successfully";
        }

        //========================================================================================================================================================================

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            using (var conn = DbConfig.Connection())
            {
                
                string getAllStudentQuery = "SELECT * FROM Students";
                SQLiteCommand getAllStudentCommand = new SQLiteCommand(getAllStudentQuery, conn);

                var reader = getAllStudentCommand.ExecuteReader();
                while (reader.Read())
                {
                    Student student = new Student();
                    student.Id = reader.GetInt32(0);
                    student.Name = reader.GetString(1);
                    student.UserName = reader.GetString(2);
                    student.Address = reader.GetString(3);
                    student.Age = reader.GetInt32(4);

                    students.Add(student);
                }
            }

            return students;
        }
        //Update ==================================================================================================================================================

        public string UpdateStudent(Student st)
        {
            using (var dbconn = DbConfig.Connection())
            {
                string updateQuery = "UPDATE Students SET Name = @name , Address = @address WHERE Id = @id;";
                SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, dbconn);
                updateCommand.Parameters.AddWithValue("@name", st.Name);
                updateCommand.Parameters.AddWithValue("@address", st.Address);
                updateCommand.Parameters.AddWithValue("@id", st.Id);

                updateCommand.ExecuteNonQuery();

                return "Student updated successfully";
            }
        }
        // Delete===================================================================================================================================================

        public string deleteStudent(Student st)
        {
            using (var dbconn = DbConfig.Connection())
            {

                string deleteQuery = "DELETE FROM Students WHERE Id = @id";
                SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, dbconn);
                deleteCommand.Parameters.AddWithValue("@id", st.Id);

                deleteCommand.ExecuteNonQuery();

                return "Student deleted successfully";
            }

        }

        internal List<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        
    }
}
    
          
    


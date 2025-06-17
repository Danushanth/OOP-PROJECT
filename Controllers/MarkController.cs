using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    using System.Collections.Generic;
    using System.Data.SQLite;
    using UnicomTicManagementSystem.Repositories;

    internal class MarkController
    {
        
            
            public string AddStudentScore(Mark mark)
            {
                using (var dbconn = DbConfig.GetConnection())
                {
                    dbconn.Open();

                    string insertScoreQuery = "INSERT INTO StudentScores(StudentId, ExamId, Score) VALUES(@studentId, @examId, @score);";

                    using (SQLiteCommand insert = new SQLiteCommand(insertScoreQuery, dbconn))
                    {
                        insert.Parameters.AddWithValue("@studentId", mark.StudentId);
                        insert.Parameters.AddWithValue("@examId", mark.ExamId);
                        insert.Parameters.AddWithValue("@score", mark.Score);

                        insert.ExecuteNonQuery();
                    }
                }
                return "Score added successfully";
            }

            
            public List<Mark> GetAllMarks()
            {
                List<Mark> marks = new List<Mark>();
                using (var conn = DbConfig.GetConnection())
                {
                    conn.Open();

                    string getAllMarksQuery = "SELECT * FROM StudentScores";
                    using (SQLiteCommand command = new SQLiteCommand(getAllMarksQuery, conn))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            marks.Add(new Mark
                            {
                                Id = reader.GetInt32(0),
                                StudentId = reader.GetInt32(1),
                                ExamId = reader.GetInt32(2),
                                Score = reader.GetInt32(3)
                            });
                        }
                    }
                }
                return marks;
            }

            
            public List<Mark> GetMarksByStudent(int studentId)
            {
                List<Mark> marks = new List<Mark>();
                using (var conn = DbConfig.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM StudentScores WHERE StudentId = @studentId";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                marks.Add(new Mark
                                {
                                    Id = reader.GetInt32(0),
                                    StudentId = reader.GetInt32(1),
                                    ExamId = reader.GetInt32(2),
                                    Score = reader.GetInt32(3)
                                });
                            }
                        }
                    }
                }
                return marks;
            }

           
            public List<Mark> GetMarksByExam(int examId)
            {
                List<Mark> marks = new List<Mark>();
                using (var conn = DbConfig.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM StudentScores WHERE ExamId = @examId";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@examId", examId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                marks.Add(new Mark
                                {
                                    Id = reader.GetInt32(0),
                                    StudentId = reader.GetInt32(1),
                                    ExamId = reader.GetInt32(2),
                                    Score = reader.GetInt32(3)
                                });
                            }
                        }
                    }
                }
                return marks;
            }

           
            public string UpdateMark(Mark mark)
            {
                using (var dbconn = DbConfig.GetConnection())
                {
                    dbconn.Open();

                    string updateQuery = "UPDATE StudentScores SET StudentId = @studentId, ExamId = @examId, Score = @score WHERE Id = @id;";
                    using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, dbconn))
                    {
                        updateCommand.Parameters.AddWithValue("@studentId", mark.StudentId);
                        updateCommand.Parameters.AddWithValue("@examId", mark.ExamId);
                        updateCommand.Parameters.AddWithValue("@score", mark.Score);
                        updateCommand.Parameters.AddWithValue("@id", mark.Id);

                        updateCommand.ExecuteNonQuery();
                    }

                    return "Mark updated successfully";
                }
            }

            
            public string DeleteMark(int id)
            {
                using (var dbconn = DbConfig.GetConnection())
                {
                    dbconn.Open();

                    string deleteQuery = "DELETE FROM StudentScores WHERE Id = @id";
                    using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteQuery, dbconn))
                    {
                        deleteCommand.Parameters.AddWithValue("@id", id);
                        deleteCommand.ExecuteNonQuery();
                    }

                    return "Mark deleted successfully";
                }
            }
        }
    }

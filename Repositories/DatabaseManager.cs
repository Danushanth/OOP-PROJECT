using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Repositories
{
    internal static class DatabaseManager
    {
        private static readonly string connectionString = "Data Source=unicomtic.db;Version=3;";

        private static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public static async Task InitializeDatabaseAsync()
        {
            string[] tableCommands = new string[]
            {
                @"CREATE TABLE IF NOT EXISTS Users (
                    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT,
                    Password TEXT,
                    Role TEXT
                );",

                @"CREATE TABLE IF NOT EXISTS Courses (
                    CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                    CourseName TEXT
                );",

                @"CREATE TABLE IF NOT EXISTS Subjects (
                    SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectName TEXT,
                    CourseID INTEGER,
                    FOREIGN KEY(CourseID) REFERENCES Courses
                );",

                @"CREATE TABLE IF NOT EXISTS Students (
                    StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    CourseID INTEGER,
                    Address TEXT,
                    FOREIGN KEY(CourseID) REFERENCES Courses
                );",

                @"CREATE TABLE IF NOT EXISTS Exams (
                    ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ExamName TEXT,
                    SubjectID INTEGER,
                    FOREIGN KEY(SubjectID) REFERENCES Subjects
                );",

                @"CREATE TABLE IF NOT EXISTS Marks (
                    MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentID INTEGER,
                    ExamID INTEGER,
                    Score INTEGER,
                    FOREIGN KEY(StudentID) REFERENCES Students,
                    FOREIGN KEY(ExamID) REFERENCES Exams
                );",

                @"CREATE TABLE IF NOT EXISTS Rooms (
                    RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                    RoomName TEXT,
                    RoomType TEXT
                );",

                @"CREATE TABLE IF NOT EXISTS Timetables (
                    TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectID INTEGER,
                    TimeSlot TEXT,
                    RoomID INTEGER,
                    FOREIGN KEY(SubjectID) REFERENCES Subjects,
                    FOREIGN KEY(RoomID) REFERENCES Rooms
                );"
            };

            foreach (string command in tableCommands)
            {
                await ExecuteNonQueryAsync(command);
            }
        }

        public static async Task<int> ExecuteNonQueryAsync(string query)
        {
            using (var conn = GetConnection())
            using (var cmd = new SQLiteCommand(query, conn))
            {
                await conn.OpenAsync();
                return await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}

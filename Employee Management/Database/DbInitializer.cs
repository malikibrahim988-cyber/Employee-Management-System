using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Employee_Management.Database;

namespace Employee_Management.Database
{
    /// <summary>
    /// Handles the automated initialization of the database schema on application startup.
    /// Ensures all required structural tables and structural columns exist before operations begin.
    /// </summary>
    public class DbInitializer
    {
        /// <summary>
        /// Executes DDL commands to verify and construct the relational schema definitions if missing.
        /// </summary>
        public static void Initialize()
        {
            // Establish a managed database connection block
            using (var con = DbConnection.GetConnection())
            {
                con.Open();

                // Structural Definition: Table for authentication, authorization roles, and employee profiles
                string userTable = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT,
                    PasswordHash TEXT,
                    Role TEXT,
                    FullName TEXT,
                    Department TEXT
                );";

                // Structural Definition: Table for tracking administrative employee records
                string employeeTable = @"
                CREATE TABLE IF NOT EXISTS Employees (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    Salary REAL,
                    Department TEXT,
                    Role TEXT
                );";

                // Structural Definition: Table for administrative inventory/operational categories
                string categoryTable = @"
                CREATE TABLE IF NOT EXISTS Categories (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    Description TEXT
                );";

                // Structural Definition: Log table for transactional daily attendance tracking
                string attendanceTable = @"
                CREATE TABLE IF NOT EXISTS Attendance (
                    AttendanceId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT,
                    LogDate TEXT,
                    Status TEXT
                );";

                // Sequential execution of DDL statements to guarantee database readiness
                using (var cmd = new SQLiteCommand(con))
                {
                    cmd.CommandText = userTable;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = employeeTable;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = categoryTable;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = attendanceTable;
                    cmd.ExecuteNonQuery();
                }

                // Non-destructive fallback verification to gracefully patch older databases missing profile columns
                EnsureLegacyColumnsExist(con);
            }
        }

        /// <summary>
        /// Safely injects profile metadata columns into pre-existing user records without corrupting primary structural keys.
        /// </summary>
        private static void EnsureLegacyColumnsExist(SQLiteConnection con)
        {
            // Safely evaluate FullName column dependency
            using (var cmd = new SQLiteCommand("ALTER TABLE Users ADD COLUMN FullName TEXT;", con))
            {
                try { cmd.ExecuteNonQuery(); }
                catch { /* Execution bypassed if column structure is already satisfied */ }
            }

            // Safely evaluate Department column dependency
            using (var cmd = new SQLiteCommand("ALTER TABLE Users ADD COLUMN Department TEXT;", con))
            {
                try { cmd.ExecuteNonQuery(); }
                catch { /* Execution bypassed if column structure is already satisfied */ }
            }
        }
    }
}


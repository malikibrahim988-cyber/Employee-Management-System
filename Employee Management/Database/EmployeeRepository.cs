using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management.Models;

namespace Employee_Management.Database
{
    /// <summary>
    /// Data Access Object (DAO) encapsulation layer servicing persistence routines for Employee models.
    /// Handles structured transactional entries, dataset parsing, and filter execution against the SQLite store.
    /// </summary>
    public class EmployeeRepository
    {
        /// <summary>
        /// Inserts a new personnel model entry down into the active structural database layer.
        /// </summary>
        /// <param name="emp">The Employee domain instance containing structural data elements to insert.</param>
        public void AddEmployee(Employee emp)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "INSERT INTO Employees (Name, Salary, Department, Role) VALUES (@n, @s, @d, @r)";

                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@n", emp.Name);
                    cmd.Parameters.AddWithValue("@s", emp.Salary);
                    cmd.Parameters.AddWithValue("@d", emp.Department);
                    cmd.Parameters.AddWithValue("@r", emp.Role);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Pulls the complete array dataset records existing inside the primary Employee matrix.
        /// </summary>
        /// <returns>A fully populated DataTable container reflecting localized row data states.</returns>
        public DataTable GetAllEmployees()
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM Employees";

                using (var cmd = new SQLiteCommand(query, con))
                {
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// Performs updates across variable columns matching an updated object model instance's tracking key identifier.
        /// </summary>
        /// <param name="emp">The target Employee item mapping modifications down to persistent structures.</param>
        public void UpdateEmployee(Employee emp)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "UPDATE Employees SET Name = @n, Salary = @s, Department = @d, Role = @r WHERE Id = @id";

                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@n", emp.Name);
                    cmd.Parameters.AddWithValue("@s", emp.Salary);
                    cmd.Parameters.AddWithValue("@d", emp.Department);
                    cmd.Parameters.AddWithValue("@r", emp.Role);
                    cmd.Parameters.AddWithValue("@id", emp.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Drops a singular, specific member record out of standard indices using its record ID code block.
        /// </summary>
        /// <param name="id">The tracked persistence row primary index.</param>
        public void DeleteEmployee(int id)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "DELETE FROM Employees WHERE Id = @id";

                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Wildcard query matrix parsing string keywords over name definitions and structural field contexts.
        /// </summary>
        /// <param name="keyword">The alpha text filter payload evaluated across target table boundaries.</param>
        /// <returns>Filtered data tables containing subset target rows satisfying match arguments.</returns>
        public DataTable SearchEmployees(string keyword)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM Employees WHERE Name LIKE @k OR Department LIKE @k";

                using (var cmd = new SQLiteCommand(query, con))
                {
                    // Injection-safe parametrization applying standardized SQL pattern matching boundaries
                    cmd.Parameters.AddWithValue("@k", "%" + keyword + "%");

                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
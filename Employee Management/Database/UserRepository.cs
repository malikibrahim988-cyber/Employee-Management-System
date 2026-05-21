using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_Management.Services;

namespace Employee_Management.Database
{
    /// <summary>
    /// Data Access Object (DAO) architecture managing credentials, verification validations, 
    /// profile lookups, and notice board communication arrays inside the database layer.
    /// </summary>
    public class UserRepository
    {
        /// <summary>
        /// Registers a fresh identity row record.
        /// </summary>
        /// <param name="username">Unique login identification name string.</param>
        /// <param name="passwordHash">The cryptographically processed security string string signature.</param>
        /// <param name="role">The categorical access level domain designation.</param>
        public void AddUser(string username, string passwordHash, string role)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "INSERT INTO Users (Username, PasswordHash, Role) VALUES (@u, @p, @r)";

                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", passwordHash);
                    cmd.Parameters.AddWithValue("@r", role);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Extracts and evaluates stored cryptographic strings against plain-text submission components 
        /// to determine active user role clearances securely.
        /// </summary>
        /// <param name="username">The identifying account credential string being queried.</param>
        /// <param name="passwordPlainText">The plain text submission payload parsed downstream for verification.</param>
        /// <returns>The confirmed role authorization string upon clear validation match success; otherwise, null.</returns>
        public string GetUserRole(string username, string passwordPlainText)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT PasswordHash, Role FROM Users WHERE Username = @u";

                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@u", username);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            return null; // Identity signature missing from matrix tables
                        }

                        if (reader.Read())
                        {
                            string dbHash = reader["PasswordHash"]?.ToString() ?? "";
                            string role = reader["Role"]?.ToString() ?? "";

                            // Reject old plaintext data signatures or empty fields safely
                            if (string.IsNullOrWhiteSpace(dbHash) || !dbHash.StartsWith("$2"))
                            {
                                return null;
                            }

                            try
                            {
                                // Route properties to the BCrypt provider helper layer
                                if (PasswordHelper.VerifyPassword(passwordPlainText, dbHash))
                                {
                                    return role; // Validation sequence confirmed successfully
                                }
                            }
                            catch (BCrypt.Net.SaltParseException)
                            {
                                // Handle sudden encoding parsing changes gracefully without a crash
                                return null;
                            }
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Checks the structural record columns to evaluate if an individual handle profile index is currently occupied.
        /// </summary>
        /// <param name="username">The target string parameter evaluated for duplicate values.</param>
        /// <returns>True if the matching identity count contains positive references; otherwise, false.</returns>
        public bool UserExists(string username)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @u";

                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        /// <summary>
        /// Gathers onboarding details and profile metadata assigned to an active profile identifier.
        /// </summary>
        /// <param name="username">The target context criteria handle flag.</param>
        /// <returns>A data storage collection block containing descriptive demographic information layout maps.</returns>
        public DataTable GetUserProfile(string username)
        {
            DataTable dt = new DataTable();
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT Username, Role, FullName, Department FROM Users WHERE Username = @u";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// Scans transaction notice tables to filter the most recently committed administrative announcement string.
        /// </summary>
        /// <returns>A localized subset memory table containing the topmost recent alert row text payload.</returns>
        public DataTable GetLatestAnnouncement()
        {
            DataTable dt = new DataTable();
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT Message FROM Announcements ORDER BY Id DESC LIMIT 1";

                using (var cmd = new SQLiteCommand(query, con))
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
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
    /// Data Access Object (DAO) managing database persistence routines for Category entities.
    /// Encapsulates CRUD operations targeting the underlying SQLite database schema.
    /// </summary>
    internal class CategoryRepository
    {
        /// <summary>
        /// Persists a new category entity row into the database.
        /// </summary>
        /// <param name="cat">The category model instance containing population data fields.</param>
        public void AddCategory(Category cat)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "INSERT INTO Categories (Name, Description) VALUES (@n, @d)";

                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@n", cat.Name);
                    cmd.Parameters.AddWithValue("@d", cat.Description);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Queries the database to extract all existing records from the categories matrix table.
        /// </summary>
        /// <returns>A disconnected memory collection table containing the full resulting dataset columns.</returns>
        public DataTable GetAllCategories()
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM Categories";

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
        /// Updates the values of an existing data row based on its primary key tracking index.
        /// </summary>
        /// <param name="cat">The category object containing the updated state fields and specific unique ID.</param>
        public void UpdateCategory(Category cat)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "UPDATE Categories SET Name = @n, Description = @d WHERE Id = @id";

                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@n", cat.Name);
                    cmd.Parameters.AddWithValue("@d", cat.Description);
                    cmd.Parameters.AddWithValue("@id", cat.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Purges a single category row reference out of the persistent data engine using its primary identifier.
        /// </summary>
        /// <param name="id">The explicit record row index tracking key.</param>
        public void DeleteCategory(int id)
        {
            using (var con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "DELETE FROM Categories WHERE Id = @id";

                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}


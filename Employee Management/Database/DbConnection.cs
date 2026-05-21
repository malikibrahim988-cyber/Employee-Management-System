using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Employee_Management.Database
{
    /// <summary>
    /// Manages the centralized database connectivity configuration for the application.
    /// Provides a single point of configuration for the SQLite connection string.
    /// </summary>
    public class DbConnection
    {
        // Centralized connection string defining the target SQLite database file and driver version
        private static string connectionString = "Data Source=ems.db;Version=3;";

        /// <summary>
        /// Instantiates and returns a new SQLiteConnection object using the defined connection string.
        /// Caller is responsible for opening and properly disposing of the connection.
        /// </summary>
        /// <returns>A configured SQLiteConnection instance.</returns>
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}

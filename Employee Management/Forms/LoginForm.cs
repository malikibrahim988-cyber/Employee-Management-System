using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_Management.Database;
using Employee_Management.Services;

namespace Employee_Management.Forms
{
    /// <summary>
    /// Security checkpoint interface managing application authentication routines.
    /// Conditionally branches system routing controls to direct administrators to operational dashboards, 
    /// while channeling employees through profile onboarding matrices.
    /// </summary>
    public partial class LoginForm : System.Windows.Forms.Form
    {
        /// <summary>
        /// Contextual component constructor initializing visual layouts and ensuring structural schema alignment.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            EnsureProfileColumnsExist();
        }

        /// <summary>
        /// Intercepts submission actions to validate system access privileges and navigate to the correct user interface form.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            UserRepository repo = new UserRepository();
            string role = repo.GetUserRole(username, password);

            if (!string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Login successful! Welcome back.", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide(); // Minimize background display footprints

                // Conditional routing branch determining the appropriate user panel form
                if (string.Equals(role, "Admin", StringComparison.OrdinalIgnoreCase))
                {
                    // Direct administrative contexts to the higher-tier management panel
                    DashboardForm dash = new DashboardForm(role);
                    dash.Show();
                }
                else
                {
                    bool isProfileSetup = false;

                    try
                    {
                        using (var con = Database.DbConnection.GetConnection())
                        {
                            con.Open();

                            // Query checking the onboarding assignment states for standard employees
                            string query = "SELECT Department FROM Users WHERE Username = @u";
                            using (var cmd = new SQLiteCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@u", username);
                                var result = cmd.ExecuteScalar();

                                // Positive onboarding verification bypasses onboarding screen layouts
                                if (result != null && result != DBNull.Value && !string.IsNullOrEmpty(result.ToString()))
                                {
                                    isProfileSetup = true;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error verifying profile status: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Direct user paths based on setup completion states
                    if (isProfileSetup)
                    {
                        // Open the core standard employee landing area
                        EmployeePortalForm empPortal = new EmployeePortalForm(username);
                        empPortal.Show();
                    }
                    else
                    {
                        // Intercept new accounts and guide them through metadata assignments
                        ProfileSetupForm setupForm = new ProfileSetupForm(username);
                        setupForm.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Instantiates registration display modules to handle fresh account setup queries.
        /// </summary>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
        }

        /// <summary>
        /// Empty listener method kept in place to fully prevent designer context binding issues.
        /// </summary>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Event method stub kept active to satisfy layout connections
        }

        /// <summary>
        /// Database validation script ensuring structural tables contain necessary onboarding columns 
        /// and transactional entities without causing runtime database collisions.
        /// </summary>
        private void EnsureProfileColumnsExist()
        {
            try
            {
                using (var con = Database.DbConnection.GetConnection())
                {
                    con.Open();

                    // Installs FullName text strings into user schemas if not already created
                    using (var cmd = new SQLiteCommand("ALTER TABLE Users ADD COLUMN FullName TEXT;", con))
                    {
                        try { cmd.ExecuteNonQuery(); }
                        catch { /* Silent drop ignoring duplicate column index exceptions */ }
                    }

                    // Installs Department text strings into user schemas if not already created
                    using (var cmd = new SQLiteCommand("ALTER TABLE Users ADD COLUMN Department TEXT;", con))
                    {
                        try { cmd.ExecuteNonQuery(); }
                        catch { /* Silent drop ignoring duplicate column index exceptions */ }
                    }

                    // Creates the transactional logging table structure for daily operations if missing
                    string createAttendanceTable = @"
                        CREATE TABLE IF NOT EXISTS Attendance (
                            AttendanceId INTEGER PRIMARY KEY AUTOINCREMENT,
                            Username TEXT,
                            LogDate TEXT,
                            Status TEXT
                        );";

                    using (var cmd = new SQLiteCommand(createAttendanceTable, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Fallback catch boundary ensuring uninterrupted local prototyping loops
                System.Diagnostics.Debug.WriteLine("Column check passed: " + ex.Message);
            }
        }
    }
}

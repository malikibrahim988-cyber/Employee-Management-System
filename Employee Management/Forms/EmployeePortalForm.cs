using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using Employee_Management.Database;

namespace Employee_Management.Forms
{
    /// <summary>
    /// Presentation layer form representing the secure employee self-service workspace environment.
    /// Handles authenticated user profile extraction, management announcement feeds, and 
    /// transactional daily attendance check-in controls.
    /// </summary>
    public partial class EmployeePortalForm : Form
    {
        // Session variable tracking the logged-in user credentials
        private string currentUsername;

        // Decoupled repository handler for executing administrative query operations
        private UserRepository userRepo = new UserRepository();

        /// <summary>
        /// Explicit constructor instantiating the employee portal form context.
        /// </summary>
        /// <param name="username">The authenticated unique identity token passed down from session access controls.</param>
        public EmployeePortalForm(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        /// <summary>
        /// Component lifecycle execution loop initialization. Pulls real-time employee profile metadata and notes.
        /// </summary>
        private void EmployeePortalForm_Load(object sender, EventArgs e)
        {
            lblFullname.Text = currentUsername;

            LoadUserProfileData();
            LoadSystemAnnouncement();
        }

        /// <summary>
        /// Connects directly to database layers to fetch name strings and department records mapped to the active profile session.
        /// </summary>
        private void LoadUserProfileData()
        {
            try
            {
                // Managed connection block to verify user records safely
                using (var con = Database.DbConnection.GetConnection())
                {
                    con.Open();

                    // Parametric structural evaluation query preventing standard injection flaws
                    string query = "SELECT FullName, Department FROM Users WHERE Username = @u";
                    using (var cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@u", currentUsername);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Safely isolate database fields using fallbacks to avoid unassigned data casting exceptions
                                string realName = reader["FullName"] != DBNull.Value ? reader["FullName"].ToString() : "Not Set";
                                string realDept = reader["Department"] != DBNull.Value ? reader["Department"].ToString() : "General Pool";

                                // Refresh layout display surfaces cleanly
                                lblUser.Text = "📧 Username:      " + currentUsername;
                                lblRole.Text = "🔑 Access Level:  Standard Employee";
                                lblFullname.Text = "👤 Name:          " + realName;
                                lblDept.Text = "🏢 Department:    " + realDept;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Graceful validation exception layer mapping runtime defaults to avoid application lockouts
                lblFullname.Text = "👤 Name:          " + currentUsername.ToUpper();
                lblDept.Text = "🏢 Department:    Default Workstation";
                System.Diagnostics.Debug.WriteLine("Error loading dynamic profile data: " + ex.Message);
            }
        }

        /// <summary>
        /// Queries the corporate directory data layer to process recent management notification summaries.
        /// </summary>
        private void LoadSystemAnnouncement()
        {
            DataTable dt = userRepo.GetLatestAnnouncement();
            if (dt.Rows.Count > 0)
            {
                lblAnnouncementText.Text = dt.Rows[0]["Message"].ToString();
            }
            else
            {
                lblAnnouncementText.Text = "✨ No active announcements from management at this time.";
            }
        }

        /// <summary>
        /// Empty or legacy listener kept in place to completely satisfy background form designer component dependencies.
        /// </summary>
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            // Method hook preserved to protect automatic background configuration links
        }

        /// <summary>
        /// Empty listener method kept in place to fully prevent designer context binding issues.
        /// </summary>
        private void lblFullname_Click(object sender, EventArgs e)
        {
            // Method hook preserved to protect automatic background configuration links
        }

        /// <summary>
        /// Attendance submission click dispatcher. Checks for duplicate daily transaction entries 
        /// before persisting attendance records and disabling further submissions.
        /// </summary>
        private void btnAttendance_Click_1(object sender, EventArgs e)
        {
            string todayDate = DateTime.Now.ToString("yyyy-MM-dd");
            string logTime = DateTime.Now.ToString("hh:mm tt");

            try
            {
                using (var con = Database.DbConnection.GetConnection())
                {
                    con.Open();

                    // Duplicate verification sequence to guarantee transaction uniqueness for the current calendar date
                    string checkQuery = "SELECT COUNT(*) FROM Attendance WHERE Username = @u AND LogDate = @d";
                    using (var checkCmd = new SQLiteCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@u", currentUsername);
                        checkCmd.Parameters.AddWithValue("@d", todayDate);

                        long alreadyMarked = (long)checkCmd.ExecuteScalar();
                        if (alreadyMarked > 0)
                        {
                            MessageBox.Show("You have already checked in for today!", "Attendance Noted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Immediately updates the interface appearance state if the background database records show it was completed
                            btnAttendance.Enabled = false;
                            btnAttendance.Text = "✅ Checked In for Today";
                            btnAttendance.BackColor = Color.FromArgb(40, 167, 69);
                            return;
                        }
                    }

                    // Write transactional record state down to the localized persistent storage subsystem
                    string insertQuery = "INSERT INTO Attendance (Username, LogDate, Status) VALUES (@u, @d, 'Present')";
                    using (var insertCmd = new SQLiteCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@u", currentUsername);
                        insertCmd.Parameters.AddWithValue("@d", todayDate);

                        insertCmd.ExecuteNonQuery();
                    }
                }

                // Smoothly update user interface controls to display successful state transition logs
                MessageBox.Show($"Check-in accepted successfully at {logTime}!", "Attendance Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnAttendance.Enabled = false;
                btnAttendance.Text = "✅ Checked In for Today";
                btnAttendance.BackColor = Color.FromArgb(40, 167, 69); // Professional Green tint assignment
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging attendance: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeePortalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
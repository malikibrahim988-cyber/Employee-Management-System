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

namespace Employee_Management.Forms
{
    /// <summary>
    /// Core administrative and executive command dashboard layout.
    /// Manages role-based visibility configurations, controls navigation interfaces,
    /// and handles system announcement broadcast transactions.
    /// </summary>
    public partial class DashboardForm : Form
    {
        private string userRole;

        /// <summary>
        /// Context-driven constructor assigning permission constraints passed down from verification checks.
        /// </summary>
        public DashboardForm(string role)
        {
            InitializeComponent();
            userRole = role;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm(userRole);
            form.Show();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Logged in as: " + userRole;

            if (string.Equals(userRole, "User", StringComparison.OrdinalIgnoreCase))
            {
                button1.Text = "View Employees";
            }
            else
            {
                button1.Text = "Manage Employees";
            }
        }

        // KEEPING DESIGNER STUB - DO NOT REMOVE
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // KEEPING DESIGNER STUB - DO NOT REMOVE
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CategoryForm catForm = new CategoryForm();
            catForm.Show();
        }

        // KEEPING DESIGNER STUB - DO NOT REMOVE
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        // KEEPING DESIGNER STUB - DO NOT REMOVE
        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Commits administrative announcement text messages straight down to active notice-board schemas.
        /// </summary>
        private void btnPublishAnnouncement_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminNotice.Text))
            {
                MessageBox.Show("Please type an announcement message before broadcasting.",
                                "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var con = DbConnection.GetConnection()) // Uses your existing SQLite connection framework
                {
                    con.Open();
                    string query = "INSERT INTO Announcements (Title, Message) VALUES ('System Broadcast', @msg)";

                    using (var cmd = new SQLiteCommand(query, con))
                    {
                        // Protects against SQL Injection errors if an admin uses quotes or special punctuation
                        cmd.Parameters.AddWithValue("@msg", txtAdminNotice.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                // Success Notification & Clean Up
                MessageBox.Show("Announcement broadcasted live to all employee portals successfully!",
                                "Broadcast Live", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAdminNotice.Clear(); // Empty out the box so it's ready for next time
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error while publishing: " + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // KEEPING DESIGNER STUB - DO NOT REMOVE
        private void txtAdminNotice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnViewAttendance_Click(object sender, EventArgs e)
        {
            AttendanceViewerForm viewer = new AttendanceViewerForm();
            viewer.ShowDialog();
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Employee_Management.Database;

namespace Employee_Management.Forms
{
    /// <summary>
    /// Intermediary presentation framework managing new user profile onboarding assets.
    /// Captures unique account metadata identifiers and commits transaction updates 
    /// down to targeted rows in the relational database layer.
    /// </summary>
    public partial class ProfileSetupForm : Form
    {
        // Internal tracking variable identifying the active onboarding session index
        private string usernameToUpdate;

        /// <summary>
        /// Contextual parameter constructor inheriting session authentication variables from the security layer.
        /// </summary>
        /// <param name="username">The unassigned account login key undergoing active onboarding validation.</param>
        public ProfileSetupForm(string username)
        {
            InitializeComponent();
            usernameToUpdate = username;
        }

        /// <summary>
        /// Forward-routes interaction triggers straight to the unified onboarding persistence method block.
        /// </summary>
        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            // Safeguards layout processing actions by calling the core query update sequence
            btnSaveProfile_Click_1(sender, e);
        }

        /// <summary>
        /// Empty event listener method kept in place to fully prevent designer context binding issues.
        /// </summary>
        private void ProfileSetupForm_Load(object sender, EventArgs e)
        {
            // Event method stub kept active to satisfy background frame setups
        }

        /// <summary>
        /// Core data manipulation transaction. Validates control fields, processes parametric injection-safe 
        /// queries, updates structural user schema entries, and balances interface routing properties.
        /// </summary>
        private void btnSaveProfile_Click_1(object sender, EventArgs e)
        {
            // Gating boundary ensuring input field arrays are non-null and definitively evaluated
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out your full name and select a department.",
                                "Incomplete Profile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Instantiate managed data channels utilizing project connection templates
                using (var con = Database.DbConnection.GetConnection())
                {
                    con.Open();

                    // Parametric structural update string avoiding string concatenation security vulnerabilities
                    string query = "UPDATE Users SET FullName = @name, Department = @dept WHERE Username = @user";

                    using (var cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@dept", cmbDepartment.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@user", usernameToUpdate);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Profile setup complete! Welcome to the team.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Initialize a smooth visual transition out into the primary workspace terminal
                EmployeePortalForm portal = new EmployeePortalForm(usernameToUpdate);
                portal.Show();

                this.Hide(); // Suppress onboarding screen layouts cleanly to prevent application window leakage
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving profile details to database: " + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

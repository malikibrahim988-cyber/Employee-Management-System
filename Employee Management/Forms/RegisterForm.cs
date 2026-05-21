using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    /// Presentation layer component managing identity registration procedures.
    /// Implements verification validation gates, duplication checking patterns via repositories,
    /// and incorporates cryptographic pass-string hashing helpers before execution persistence.
    /// </summary>
    public partial class RegisterForm : System.Windows.Forms.Form
    {
        /// <summary>
        /// Component constructor initializing visual layout modules.
        /// </summary>
        public RegisterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dispatches registration input parsing. Validates structural format properties, 
        /// evaluates duplication indexes, hashes secret key blocks, and inserts a fresh user record.
        /// </summary>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Sanitize string arrays to prevent white-space entry exploits
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;
            string role = cmbRole.Text.Trim();

            // Input integrity validation checkpoint
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all fields including selecting a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // String verification checkpoint matching original and confirmation pass-phrases
            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserRepository repo = new UserRepository();

            // Uniqueness evaluation query intercepting duplicate registration anomalies
            if (repo.UserExists(username))
            {
                MessageBox.Show("This username is already taken. Please choose another one.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Encapsulate plaintext strings down into secure cryptographic hash patterns
            string hashedPassword = PasswordHelper.HashPassword(password);
            repo.AddUser(username, hashedPassword, role);

            MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Execute input layout resets 
            ClearInputControls();

            this.Close(); // Conclude registration operational layer sequence smoothly
        }

        /// <summary>
        /// Empty event listener method kept in place to fully prevent designer context binding issues.
        /// </summary>
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Event method stub kept active to satisfy background frame setups
        }

        /// <summary>
        /// Resets interactive interface fields when processing manual validation overrides.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            ClearInputControls();
        }

        /// <summary>
        /// Reusable internal method to wipe form fields and restore combo dropdown lists to default unselected indexes.
        /// </summary>
        private void ClearInputControls()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            cmbRole.SelectedIndex = -1; // Reset selection array indexes completely
        }
    }
}

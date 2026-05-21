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

namespace Employee_Management.Forms
{
    /// <summary>
    /// Presentation layer form providing administrative review of employee attendance transaction records.
    /// Displays historical transactional check-ins using a structured, read-only data grid configuration.
    /// </summary>
    public partial class AttendanceViewerForm : Form
    {
        /// <summary>
        /// Initializes the UI components. Standard class constructor required by Windows Forms.
        /// </summary>
        public AttendanceViewerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form lifecycle event handler. Executes automatic retrieval of tracking data when the window launches.
        /// </summary>
        private void AttendanceViewerForm_Load(object sender, EventArgs e)
        {
            LoadAttendanceGrid();
        }

        /// <summary>
        /// Direct data communication routine to query transaction history logs and map them to the display interface.
        /// </summary>
        private void LoadAttendanceGrid()
        {
            try
            {
                // Managed data connection sequence block
                using (var con = Database.DbConnection.GetConnection())
                {
                    con.Open();

                    // Transactional query mapping table rows and applying explicit aliases for presentation display headers
                    string query = "SELECT AttendanceId AS [Log ID], Username AS [Employee], LogDate AS [Date], Status AS [Attendance Status] FROM Attendance ORDER BY AttendanceId DESC";

                    using (var cmd = new SQLiteCommand(query, con))
                    {
                        // Bridge data extraction sequence into local memory matrix
                        using (var adapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Bind processed memory matrix collections to the screen layout grid control
                            dgvAttendance.DataSource = dt;
                        }
                    }
                }

                // Layout display rule configuring responsive column width distributions across the form view width
                dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                // Execution safety exception handler to intercept database anomalies and prevent runtime instability
                MessageBox.Show("Error loading attendance records: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
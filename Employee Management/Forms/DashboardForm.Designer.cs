namespace Employee_Management.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblWelcome = new Label();
            label1 = new Label();
            btnManageCategories = new Button();
            panel2 = new Panel();
            label2 = new Label();
            txtAdminNotice = new TextBox();
            btnPublishAnnouncement = new Button();
            btnViewAttendance = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 90, 122);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(485, 319);
            button1.Name = "button1";
            button1.Size = new Size(303, 67);
            button1.TabIndex = 1;
            button1.Text = "Manage Employees";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(80, 80, 80);
            button2.Location = new Point(486, 452);
            button2.Name = "button2";
            button2.Size = new Size(304, 44);
            button2.TabIndex = 2;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 114);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.edit;
            pictureBox1.Location = new Point(221, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblWelcome.ForeColor = Color.FromArgb(120, 120, 120);
            lblWelcome.Location = new Point(574, 51);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(149, 32);
            lblWelcome.TabIndex = 5;
            lblWelcome.Text = "Logged in as:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(32, 32, 32);
            label1.Location = new Point(267, 35);
            label1.Name = "label1";
            label1.Size = new Size(264, 48);
            label1.TabIndex = 4;
            label1.Text = "Welcome Back";
            label1.Click += label1_Click_1;
            // 
            // btnManageCategories
            // 
            btnManageCategories.BackColor = Color.FromArgb(24, 90, 122);
            btnManageCategories.Cursor = Cursors.Hand;
            btnManageCategories.FlatAppearance.BorderSize = 0;
            btnManageCategories.FlatStyle = FlatStyle.Flat;
            btnManageCategories.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageCategories.ForeColor = Color.White;
            btnManageCategories.Location = new Point(485, 246);
            btnManageCategories.Name = "btnManageCategories";
            btnManageCategories.Size = new Size(303, 67);
            btnManageCategories.TabIndex = 5;
            btnManageCategories.Text = "Manage Category";
            btnManageCategories.UseVisualStyleBackColor = false;
            btnManageCategories.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtAdminNotice);
            panel2.Controls.Add(btnPublishAnnouncement);
            panel2.Location = new Point(1, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 257);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(20, 21);
            label2.Name = "label2";
            label2.Size = new Size(389, 28);
            label2.TabIndex = 2;
            label2.Text = "Create Global Company Announcement:";
            label2.Click += label2_Click;
            // 
            // txtAdminNotice
            // 
            txtAdminNotice.Location = new Point(20, 93);
            txtAdminNotice.Multiline = true;
            txtAdminNotice.Name = "txtAdminNotice";
            txtAdminNotice.Size = new Size(346, 60);
            txtAdminNotice.TabIndex = 1;
            txtAdminNotice.TextChanged += txtAdminNotice_TextChanged;
            // 
            // btnPublishAnnouncement
            // 
            btnPublishAnnouncement.BackColor = Color.Silver;
            btnPublishAnnouncement.Cursor = Cursors.Hand;
            btnPublishAnnouncement.FlatAppearance.BorderSize = 0;
            btnPublishAnnouncement.FlatStyle = FlatStyle.Flat;
            btnPublishAnnouncement.Location = new Point(20, 176);
            btnPublishAnnouncement.Name = "btnPublishAnnouncement";
            btnPublishAnnouncement.Size = new Size(258, 44);
            btnPublishAnnouncement.TabIndex = 0;
            btnPublishAnnouncement.Text = "📢 Broadcast Live Notice";
            btnPublishAnnouncement.UseVisualStyleBackColor = false;
            btnPublishAnnouncement.Click += btnPublishAnnouncement_Click;
            // 
            // btnViewAttendance
            // 
            btnViewAttendance.BackColor = Color.FromArgb(24, 90, 122);
            btnViewAttendance.Cursor = Cursors.Hand;
            btnViewAttendance.FlatAppearance.BorderSize = 0;
            btnViewAttendance.FlatStyle = FlatStyle.Flat;
            btnViewAttendance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewAttendance.ForeColor = Color.White;
            btnViewAttendance.Location = new Point(485, 150);
            btnViewAttendance.Name = "btnViewAttendance";
            btnViewAttendance.Size = new Size(303, 90);
            btnViewAttendance.TabIndex = 7;
            btnViewAttendance.Text = "📋 View Attendance Log";
            btnViewAttendance.UseVisualStyleBackColor = false;
            btnViewAttendance.Click += btnViewAttendance_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 508);
            Controls.Add(btnViewAttendance);
            Controls.Add(panel2);
            Controls.Add(btnManageCategories);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Management System - Dashboard";
            FormClosed += DashboardForm_FormClosed;
            Load += DashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label lblWelcome;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnManageCategories;
        private Panel panel2;
        private Label label2;
        private TextBox txtAdminNotice;
        private Button btnPublishAnnouncement;
        private Button btnViewAttendance;
    }
}
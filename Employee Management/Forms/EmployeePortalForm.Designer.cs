namespace Employee_Management.Forms
{
    partial class EmployeePortalForm
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblFullname = new Label();
            lblDept = new Label();
            lblRole = new Label();
            lblUser = new Label();
            btnAttendance = new Button();
            pnlAnnounceContainer = new Panel();
            lblAnnouncementText = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            pnlAnnounceContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 43, 54);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 60);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 18);
            label1.Name = "label1";
            label1.Size = new Size(468, 32);
            label1.TabIndex = 0;
            label1.Text = "👤 EMPLOYEE PORTAL | Welcome Back!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(108, 117, 125);
            label2.Location = new Point(29, 98);
            label2.Name = "label2";
            label2.Size = new Size(236, 30);
            label2.TabIndex = 1;
            label2.Text = "My Workplace Profile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(108, 117, 125);
            label3.Location = new Point(28, 128);
            label3.Name = "label3";
            label3.Size = new Size(237, 30);
            label3.TabIndex = 2;
            label3.Text = "==============";
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Location = new Point(36, 189);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(68, 28);
            lblFullname.TabIndex = 3;
            lblFullname.Text = "Name:";
            lblFullname.Click += lblFullname_Click;
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Location = new Point(36, 217);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(121, 28);
            lblDept.TabIndex = 4;
            lblDept.Text = "Department:";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(36, 245);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(54, 28);
            lblRole.TabIndex = 5;
            lblRole.Text = "Role:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(36, 273);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(88, 28);
            lblUser.TabIndex = 6;
            lblUser.Text = "Account:";
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.FromArgb(0, 123, 255);
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttendance.ForeColor = Color.White;
            btnAttendance.Location = new Point(52, 369);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(320, 55);
            btnAttendance.TabIndex = 7;
            btnAttendance.Text = "⏰ MARK DAILY ATTENDANCE";
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click_1;
            // 
            // pnlAnnounceContainer
            // 
            pnlAnnounceContainer.BackColor = Color.White;
            pnlAnnounceContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlAnnounceContainer.Controls.Add(lblAnnouncementText);
            pnlAnnounceContainer.Location = new Point(470, 168);
            pnlAnnounceContainer.Name = "pnlAnnounceContainer";
            pnlAnnounceContainer.Size = new Size(450, 280);
            pnlAnnounceContainer.TabIndex = 8;
            // 
            // lblAnnouncementText
            // 
            lblAnnouncementText.Dock = DockStyle.Fill;
            lblAnnouncementText.Location = new Point(0, 0);
            lblAnnouncementText.Name = "lblAnnouncementText";
            lblAnnouncementText.Padding = new Padding(15);
            lblAnnouncementText.Size = new Size(448, 278);
            lblAnnouncementText.TabIndex = 0;
            lblAnnouncementText.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(108, 117, 125);
            label4.Location = new Point(471, 128);
            label4.Name = "label4";
            label4.Size = new Size(237, 30);
            label4.TabIndex = 10;
            label4.Text = "==============";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(108, 117, 125);
            label5.Location = new Point(472, 98);
            label5.Name = "label5";
            label5.Size = new Size(294, 30);
            label5.TabIndex = 9;
            label5.Text = "Company announncements";
            // 
            // EmployeePortalForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(944, 497);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(pnlAnnounceContainer);
            Controls.Add(btnAttendance);
            Controls.Add(lblUser);
            Controls.Add(lblRole);
            Controls.Add(lblDept);
            Controls.Add(lblFullname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "EmployeePortalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeePortalForm";
            FormClosed += EmployeePortalForm_FormClosed;
            Load += EmployeePortalForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlAnnounceContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblFullname;
        private Label lblDept;
        private Label lblRole;
        private Label lblUser;
        private Button btnAttendance;
        private Panel pnlAnnounceContainer;
        private Label lblAnnouncementText;
        private Label label4;
        private Label label5;
    }
}
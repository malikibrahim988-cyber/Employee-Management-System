namespace Employee_Management.Forms
{
    partial class ProfileSetupForm
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
            label1 = new Label();
            txtFullName = new TextBox();
            cmbDepartment = new ComboBox();
            btnSaveProfile = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 49);
            label1.Name = "label1";
            label1.Size = new Size(425, 32);
            label1.TabIndex = 0;
            label1.Text = "📋 Complete Your Employee Profile";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(245, 136);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(311, 31);
            txtFullName.TabIndex = 1;
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "Human Resources", "IT Support", "Finance", "Operations Management Division", "Marketing" });
            cmbDepartment.Location = new Point(245, 192);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(309, 33);
            cmbDepartment.TabIndex = 2;
            // 
            // btnSaveProfile
            // 
            btnSaveProfile.BackColor = Color.FromArgb(0, 64, 64);
            btnSaveProfile.FlatAppearance.BorderSize = 0;
            btnSaveProfile.FlatStyle = FlatStyle.Flat;
            btnSaveProfile.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveProfile.ForeColor = Color.White;
            btnSaveProfile.Location = new Point(245, 267);
            btnSaveProfile.Name = "btnSaveProfile";
            btnSaveProfile.Size = new Size(311, 51);
            btnSaveProfile.TabIndex = 3;
            btnSaveProfile.Text = "✅ Save & Enter Portal";
            btnSaveProfile.UseVisualStyleBackColor = false;
            btnSaveProfile.Click += btnSaveProfile_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(121, 136);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 4;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(122, 192);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 5;
            label3.Text = "Department";
            // 
            // ProfileSetupForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSaveProfile);
            Controls.Add(cmbDepartment);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Name = "ProfileSetupForm";
            Text = "ProfileSetupForm";
            Load += ProfileSetupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFullName;
        private ComboBox cmbDepartment;
        private Button btnSaveProfile;
        private Label label2;
        private Label label3;
    }
}
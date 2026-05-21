namespace Employee_Management.Forms
{
    partial class EmployeeForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            txtName = new TextBox();
            txtSalary = new TextBox();
            labelSalary = new Label();
            labelRole = new Label();
            label4 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            txtSearch = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            cmbRole = new ComboBox();
            cmbdepartment = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 113);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(255, 110);
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 39);
            txtName.TabIndex = 1;
            // 
            // txtSalary
            // 
            txtSalary.BorderStyle = BorderStyle.FixedSingle;
            txtSalary.Font = new Font("Segoe UI", 12F);
            txtSalary.Location = new Point(255, 177);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(236, 39);
            txtSalary.TabIndex = 3;
            txtSalary.TextChanged += txtSalary_TextChanged;
            // 
            // labelSalary
            // 
            labelSalary.AutoSize = true;
            labelSalary.Location = new Point(125, 180);
            labelSalary.Name = "labelSalary";
            labelSalary.Size = new Size(59, 25);
            labelSalary.TabIndex = 2;
            labelSalary.Text = "Salary";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(125, 253);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(46, 25);
            labelRole.TabIndex = 4;
            labelRole.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 328);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 6;
            label4.Text = "Department";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(24, 90, 120);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(200, 413);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(190, 44);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 55, 44);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(991, 411);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 44);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(396, 413);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(190, 44);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(240, 244, 248);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(33, 43, 54);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(629, 155);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 123, 255);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(514, 222);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(629, 113);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 12;
            label5.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(711, 110);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(423, 31);
            txtSearch.TabIndex = 14;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 87);
            panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.Image = Properties.Resources.details;
            pictureBox1.Location = new Point(37, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(83, 29);
            label2.Name = "label2";
            label2.Size = new Size(243, 38);
            label2.TabIndex = 0;
            label2.Text = "Employee Details";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 12F);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "HR Manager", "Project Manager", "Senior Developer", "Junior Developer", "QA Engineer", "Data Analyst", "Accountant" });
            cmbRole.Location = new Point(255, 253);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(236, 40);
            cmbRole.TabIndex = 1;
            // 
            // cmbdepartment
            // 
            cmbdepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbdepartment.Font = new Font("Segoe UI", 12F);
            cmbdepartment.FormattingEnabled = true;
            cmbdepartment.Items.AddRange(new object[] { "Human Resources", "IT Support", "Finance", "Operations Management Division", "Marketing" });
            cmbdepartment.Location = new Point(255, 328);
            cmbdepartment.Name = "cmbdepartment";
            cmbdepartment.Size = new Size(236, 40);
            cmbdepartment.TabIndex = 16;
            cmbdepartment.SelectedIndexChanged += cmbdepartment_SelectedIndexChanged;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1167, 476);
            Controls.Add(cmbdepartment);
            Controls.Add(cmbRole);
            Controls.Add(panel1);
            Controls.Add(txtSearch);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(labelRole);
            Controls.Add(txtSalary);
            Controls.Add(labelSalary);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtSalary;
        private Label labelSalary;
        private Label labelRole;
        private Label label4;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox txtSearch;
        private Panel panel1;
        private Label label2;
        private ComboBox cmbRole;
        private ComboBox cmbdepartment;
        private PictureBox pictureBox1;
    }
}
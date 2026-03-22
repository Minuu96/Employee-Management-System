
namespace EmployeeManagementSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.labelAppTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sideAccent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.greet_user = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.navDivider = new System.Windows.Forms.Label();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.addEmployee_btn = new System.Windows.Forms.Button();
            this.salary_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboard1 = new EmployeeManagementSystem.Dashboard();
            this.addEmployee1 = new EmployeeManagementSystem.AddEmployee();
            this.salary1 = new EmployeeManagementSystem.Salary();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // ── TOP BAR (panel1) ─────────────────────────────────────────────
            this.panel1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel1.Controls.Add(this.labelAppTitle);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 40);
            this.panel1.TabIndex = 0;

            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.exit.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.exit.Location = new System.Drawing.Point(1069, 10);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 20);
            this.exit.TabIndex = 0;
            this.exit.Text = "✕";
            this.exit.Click += new System.EventHandler(this.exit_Click);

            this.labelAppTitle.AutoSize = true;
            this.labelAppTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelAppTitle.ForeColor = System.Drawing.Color.FromArgb(6, 182, 212);
            this.labelAppTitle.Location = new System.Drawing.Point(12, 11);
            this.labelAppTitle.Name = "labelAppTitle";
            this.labelAppTitle.Size = new System.Drawing.Size(220, 19);
            this.labelAppTitle.TabIndex = 1;
            this.labelAppTitle.Text = "● Employee Management System";

            // ── SIDEBAR (panel2) ─────────────────────────────────────────────
            this.panel2.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panel2.Controls.Add(this.sideAccent);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.greet_user);
            this.panel2.Controls.Add(this.labelRole);
            this.panel2.Controls.Add(this.navDivider);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.addEmployee_btn);
            this.panel2.Controls.Add(this.salary_btn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 560);
            this.panel2.TabIndex = 1;

            // cyan right border accent
            this.sideAccent.BackColor = System.Drawing.Color.FromArgb(6, 182, 212);
            this.sideAccent.Dock = System.Windows.Forms.DockStyle.Right;
            this.sideAccent.Location = new System.Drawing.Point(227, 0);
            this.sideAccent.Name = "sideAccent";
            this.sideAccent.Size = new System.Drawing.Size(3, 560);
            this.sideAccent.TabIndex = 20;

            this.pictureBox1.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_employee_card_100px;
            this.pictureBox1.Location = new System.Drawing.Point(65, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            this.greet_user.AutoSize = false;
            this.greet_user.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.greet_user.ForeColor = System.Drawing.Color.FromArgb(6, 182, 212);
            this.greet_user.Location = new System.Drawing.Point(5, 128);
            this.greet_user.Name = "greet_user";
            this.greet_user.Size = new System.Drawing.Size(220, 24);
            this.greet_user.TabIndex = 1;
            this.greet_user.Text = "Welcome, Admin";
            this.greet_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.labelRole = new System.Windows.Forms.Label();
            this.labelRole.AutoSize = false;
            this.labelRole.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.labelRole.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.labelRole.Location = new System.Drawing.Point(5, 152);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(220, 18);
            this.labelRole.TabIndex = 7;
            this.labelRole.Text = "Administrator";
            this.labelRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.navDivider = new System.Windows.Forms.Label();
            this.navDivider.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.navDivider.Location = new System.Drawing.Point(15, 182);
            this.navDivider.Name = "navDivider";
            this.navDivider.Size = new System.Drawing.Size(200, 1);
            this.navDivider.TabIndex = 8;

            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(6, 182, 212);
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(8, 145, 178);
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(8, 145, 178);
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(8, 145, 178);
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dashboard_btn.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dashboard_btn.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_dashboard_30px;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(15, 196);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dashboard_btn.Size = new System.Drawing.Size(200, 42);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "  DASHBOARD";
            this.dashboard_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);

            this.addEmployee_btn.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.addEmployee_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_btn.FlatAppearance.BorderSize = 0;
            this.addEmployee_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.addEmployee_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.addEmployee_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.addEmployee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_btn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.addEmployee_btn.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.addEmployee_btn.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_employee_card_30px;
            this.addEmployee_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmployee_btn.Location = new System.Drawing.Point(15, 248);
            this.addEmployee_btn.Name = "addEmployee_btn";
            this.addEmployee_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.addEmployee_btn.Size = new System.Drawing.Size(200, 42);
            this.addEmployee_btn.TabIndex = 3;
            this.addEmployee_btn.Text = "  EMPLOYEES";
            this.addEmployee_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmployee_btn.UseVisualStyleBackColor = false;
            this.addEmployee_btn.Click += new System.EventHandler(this.addEmployee_btn_Click);

            this.salary_btn.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.salary_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_btn.FlatAppearance.BorderSize = 0;
            this.salary_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.salary_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.salary_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.salary_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salary_btn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.salary_btn.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.salary_btn.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_Salary_male_30px;
            this.salary_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salary_btn.Location = new System.Drawing.Point(15, 300);
            this.salary_btn.Name = "salary_btn";
            this.salary_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.salary_btn.Size = new System.Drawing.Size(200, 42);
            this.salary_btn.TabIndex = 4;
            this.salary_btn.Text = "  SALARY";
            this.salary_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salary_btn.UseVisualStyleBackColor = false;
            this.salary_btn.Click += new System.EventHandler(this.salary_btn_Click);

            this.label4.AutoSize = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.label4.Location = new System.Drawing.Point(55, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sign Out";

            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(127, 29, 29);
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.logout_btn.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_logout_rounded_up_filled_25px;
            this.logout_btn.Location = new System.Drawing.Point(15, 500);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(36, 36);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);

            // ── CONTENT AREA (panel3) ─────────────────────────────────────
            this.panel3.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.addEmployee1);
            this.panel3.Controls.Add(this.salary1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(230, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(870, 560);
            this.panel3.TabIndex = 2;

            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(870, 560);
            this.dashboard1.TabIndex = 2;

            this.addEmployee1.Location = new System.Drawing.Point(0, 0);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(870, 560);
            this.addEmployee1.TabIndex = 1;

            this.salary1.Location = new System.Drawing.Point(0, 0);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(870, 560);
            this.salary1.TabIndex = 0;

            // ── FORM ─────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label labelAppTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sideAccent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label greet_user;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label navDivider;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button salary_btn;
        private System.Windows.Forms.Button addEmployee_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private Salary salary1;
        private Dashboard dashboard1;
        private AddEmployee addEmployee1;
    }
}
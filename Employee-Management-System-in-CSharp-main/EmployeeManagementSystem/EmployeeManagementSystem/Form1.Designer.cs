
namespace EmployeeManagementSystem
{
    partial class Form1
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
            this.accentBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSub = new System.Windows.Forms.Label();
            this.login_signupBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDivider = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.login_showPass = new System.Windows.Forms.CheckBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // ── LEFT PANEL ──────────────────────────────────────────────────
            this.panel1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel1.Controls.Add(this.accentBar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelSub);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.login_signupBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 460);
            this.panel1.TabIndex = 0;

            // accent top bar
            this.accentBar.BackColor = System.Drawing.Color.FromArgb(6, 182, 212);
            this.accentBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.accentBar.Location = new System.Drawing.Point(0, 0);
            this.accentBar.Name = "accentBar";
            this.accentBar.Size = new System.Drawing.Size(280, 4);
            this.accentBar.TabIndex = 10;

            // pictureBox1 — logo icon
            this.pictureBox1.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_employee_card_100px;
            this.pictureBox1.Location = new System.Drawing.Point(90, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;

            // label6 — app name
            this.label6.AutoSize = false;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(6, 182, 212);
            this.label6.Location = new System.Drawing.Point(10, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Employee Management";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelSub
            this.labelSub = new System.Windows.Forms.Label();
            this.labelSub.AutoSize = false;
            this.labelSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelSub.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.labelSub.Location = new System.Drawing.Point(10, 205);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(260, 22);
            this.labelSub.TabIndex = 11;
            this.labelSub.Text = "System";
            this.labelSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // label5 — hint text
            this.label5.AutoSize = false;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.label5.Location = new System.Drawing.Point(10, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Don\'t have an account?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // login_signupBtn
            this.login_signupBtn.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.login_signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_signupBtn.FlatAppearance.BorderSize = 0;
            this.login_signupBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(6, 182, 212);
            this.login_signupBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(8, 145, 178);
            this.login_signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_signupBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.login_signupBtn.ForeColor = System.Drawing.Color.FromArgb(6, 182, 212);
            this.login_signupBtn.Location = new System.Drawing.Point(30, 412);
            this.login_signupBtn.Name = "login_signupBtn";
            this.login_signupBtn.Size = new System.Drawing.Size(220, 34);
            this.login_signupBtn.TabIndex = 1;
            this.login_signupBtn.Text = "CREATE ACCOUNT";
            this.login_signupBtn.UseVisualStyleBackColor = false;
            this.login_signupBtn.Click += new System.EventHandler(this.login_signupBtn_Click);

            // ── RIGHT PANEL controls ─────────────────────────────────────────
            // exit
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.exit.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.exit.Location = new System.Drawing.Point(592, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(17, 20);
            this.exit.TabIndex = 1;
            this.exit.Text = "✕";
            this.exit.Click += new System.EventHandler(this.exit_Click);

            // label2 — "Welcome Back"
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.label2.Location = new System.Drawing.Point(295, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome Back";

            // labelDivider
            this.labelDivider = new System.Windows.Forms.Label();
            this.labelDivider.AutoSize = true;
            this.labelDivider.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDivider.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.labelDivider.Location = new System.Drawing.Point(296, 108);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.TabIndex = 12;
            this.labelDivider.Text = "Sign in to your account";

            // label3 — Username
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.label3.Location = new System.Drawing.Point(296, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "USERNAME";

            // login_username
            this.login_username.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.login_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_username.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.login_username.ForeColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.login_username.Location = new System.Drawing.Point(296, 178);
            this.login_username.Multiline = true;
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(290, 34);
            this.login_username.TabIndex = 4;

            // label4 — Password
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.label4.Location = new System.Drawing.Point(296, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "PASSWORD";

            // login_password
            this.login_password.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.login_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_password.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.login_password.ForeColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.login_password.Location = new System.Drawing.Point(296, 252);
            this.login_password.Multiline = true;
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '●';
            this.login_password.Size = new System.Drawing.Size(290, 34);
            this.login_password.TabIndex = 6;

            // login_showPass
            this.login_showPass.AutoSize = true;
            this.login_showPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_showPass.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.login_showPass.Location = new System.Drawing.Point(296, 296);
            this.login_showPass.Name = "login_showPass";
            this.login_showPass.Size = new System.Drawing.Size(112, 19);
            this.login_showPass.TabIndex = 7;
            this.login_showPass.Text = "Show Password";
            this.login_showPass.UseVisualStyleBackColor = false;
            this.login_showPass.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.login_showPass.CheckedChanged += new System.EventHandler(this.login_showPass_CheckedChanged);

            // login_btn
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(6, 182, 212);
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(8, 145, 178);
            this.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(8, 145, 178);
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.login_btn.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.login_btn.Location = new System.Drawing.Point(296, 334);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(290, 42);
            this.login_btn.TabIndex = 8;
            this.login_btn.Text = "SIGN IN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);

            // ── FORM ─────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.ClientSize = new System.Drawing.Size(620, 460);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_showPass);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDivider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel accentBar;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDivider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox login_showPass;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button login_signupBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

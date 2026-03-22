
namespace EmployeeManagementSystem
{
    partial class RegisterForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.signup_loginBtn = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDivider = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signup_showPass = new System.Windows.Forms.CheckBox();
            this.signup_btn = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.signup_loginBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 460);
            this.panel1.TabIndex = 9;

            this.accentBar.BackColor = System.Drawing.Color.FromArgb(6, 182, 212);
            this.accentBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.accentBar.Location = new System.Drawing.Point(0, 0);
            this.accentBar.Name = "accentBar";
            this.accentBar.Size = new System.Drawing.Size(280, 4);
            this.accentBar.TabIndex = 10;

            this.pictureBox1.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_employee_card_100px;
            this.pictureBox1.Location = new System.Drawing.Point(90, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;

            this.label6.AutoSize = false;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(6, 182, 212);
            this.label6.Location = new System.Drawing.Point(10, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Employee Management";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

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

            this.label5.AutoSize = false;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.label5.Location = new System.Drawing.Point(10, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Already have an account?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.signup_loginBtn.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.signup_loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_loginBtn.FlatAppearance.BorderSize = 0;
            this.signup_loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(6, 182, 212);
            this.signup_loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(8, 145, 178);
            this.signup_loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_loginBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.signup_loginBtn.ForeColor = System.Drawing.Color.FromArgb(6, 182, 212);
            this.signup_loginBtn.Location = new System.Drawing.Point(30, 412);
            this.signup_loginBtn.Name = "signup_loginBtn";
            this.signup_loginBtn.Size = new System.Drawing.Size(220, 34);
            this.signup_loginBtn.TabIndex = 1;
            this.signup_loginBtn.Text = "SIGN IN INSTEAD";
            this.signup_loginBtn.UseVisualStyleBackColor = false;
            this.signup_loginBtn.Click += new System.EventHandler(this.signup_loginBtn_Click);

            // ── RIGHT PANEL controls ─────────────────────────────────────────
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.exit.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.exit.Location = new System.Drawing.Point(592, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(17, 20);
            this.exit.TabIndex = 10;
            this.exit.Text = "✕";
            this.exit.Click += new System.EventHandler(this.exit_Click);

            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.label2.Location = new System.Drawing.Point(298, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Create Account";

            this.labelDivider = new System.Windows.Forms.Label();
            this.labelDivider.AutoSize = true;
            this.labelDivider.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDivider.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.labelDivider.Location = new System.Drawing.Point(299, 108);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.TabIndex = 12;
            this.labelDivider.Text = "Register a new account below";

            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.label3.Location = new System.Drawing.Point(299, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "USERNAME";

            this.signup_username.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.signup_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signup_username.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.signup_username.ForeColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.signup_username.Location = new System.Drawing.Point(299, 178);
            this.signup_username.Multiline = true;
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(290, 34);
            this.signup_username.TabIndex = 13;

            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.label4.Location = new System.Drawing.Point(299, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "PASSWORD";

            this.signup_password.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.signup_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signup_password.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.signup_password.ForeColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.signup_password.Location = new System.Drawing.Point(299, 252);
            this.signup_password.Multiline = true;
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '●';
            this.signup_password.Size = new System.Drawing.Size(290, 34);
            this.signup_password.TabIndex = 15;

            this.signup_showPass.AutoSize = true;
            this.signup_showPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signup_showPass.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.signup_showPass.Location = new System.Drawing.Point(299, 296);
            this.signup_showPass.Name = "signup_showPass";
            this.signup_showPass.Size = new System.Drawing.Size(112, 19);
            this.signup_showPass.TabIndex = 16;
            this.signup_showPass.Text = "Show Password";
            this.signup_showPass.UseVisualStyleBackColor = false;
            this.signup_showPass.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.signup_showPass.CheckedChanged += new System.EventHandler(this.signup_showPass_CheckedChanged);

            this.signup_btn.BackColor = System.Drawing.Color.FromArgb(6, 182, 212);
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btn.FlatAppearance.BorderSize = 0;
            this.signup_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(8, 145, 178);
            this.signup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(8, 145, 178);
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.signup_btn.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.signup_btn.Location = new System.Drawing.Point(299, 334);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(290, 42);
            this.signup_btn.TabIndex = 17;
            this.signup_btn.Text = "REGISTER";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);

            // ── FORM ─────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.ClientSize = new System.Drawing.Size(620, 460);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.signup_showPass);
            this.Controls.Add(this.signup_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signup_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDivider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel accentBar;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.CheckBox signup_showPass;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDivider;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.Button signup_loginBtn;
        private System.Windows.Forms.Label label5;
    }
}
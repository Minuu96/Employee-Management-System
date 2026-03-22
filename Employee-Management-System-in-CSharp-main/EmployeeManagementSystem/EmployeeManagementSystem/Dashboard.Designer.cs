
namespace EmployeeManagementSystem
{
    partial class Dashboard
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCards = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.card3Accent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboard_TE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.card4Accent = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dashboard_AE = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.card5Accent = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dashboard_IE = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();

            // ── CARDS OUTER PANEL ────────────────────────────────────────────
            this.panel1.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel1.Controls.Add(this.labelCards);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 200);
            this.panel1.TabIndex = 0;

            this.labelCards.AutoSize = true;
            this.labelCards = new System.Windows.Forms.Label();
            this.labelCards.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelCards.ForeColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.labelCards.Location = new System.Drawing.Point(0, 0);
            this.labelCards.Name = "labelCards";
            this.labelCards.Size = new System.Drawing.Size(120, 20);
            this.labelCards.TabIndex = 10;
            this.labelCards.Text = "Overview";

            // ── STAT CARD — Total Employees ──────────────────────────────────
            this.panel3.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panel3.Controls.Add(this.card3Accent);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.dashboard_TE);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 130);
            this.panel3.TabIndex = 0;

            this.card3Accent.BackColor = System.Drawing.Color.FromArgb(6, 182, 212);
            this.card3Accent.Dock = System.Windows.Forms.DockStyle.Left;
            this.card3Accent.Location = new System.Drawing.Point(0, 0);
            this.card3Accent.Name = "card3Accent";
            this.card3Accent.Size = new System.Drawing.Size(5, 130);
            this.card3Accent.TabIndex = 10;

            this.pictureBox1.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_employee_card_60px_1;
            this.pictureBox1.Location = new System.Drawing.Point(14, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            this.dashboard_TE.AutoSize = true;
            this.dashboard_TE.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.dashboard_TE.ForeColor = System.Drawing.Color.FromArgb(6, 182, 212);
            this.dashboard_TE.Location = new System.Drawing.Point(74, 18);
            this.dashboard_TE.Name = "dashboard_TE";
            this.dashboard_TE.Size = new System.Drawing.Size(40, 47);
            this.dashboard_TE.TabIndex = 2;
            this.dashboard_TE.Text = "0";

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.label1.Location = new System.Drawing.Point(14, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Employees";

            // ── STAT CARD — Active Employees ─────────────────────────────────
            this.panel4.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panel4.Controls.Add(this.card4Accent);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.dashboard_AE);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(292, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 130);
            this.panel4.TabIndex = 1;

            this.card4Accent.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.card4Accent.Dock = System.Windows.Forms.DockStyle.Left;
            this.card4Accent.Location = new System.Drawing.Point(0, 0);
            this.card4Accent.Name = "card4Accent";
            this.card4Accent.Size = new System.Drawing.Size(5, 130);
            this.card4Accent.TabIndex = 10;

            this.pictureBox2.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_group_background_selected_filled_60px;
            this.pictureBox2.Location = new System.Drawing.Point(14, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;

            this.dashboard_AE.AutoSize = true;
            this.dashboard_AE.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.dashboard_AE.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.dashboard_AE.Location = new System.Drawing.Point(74, 18);
            this.dashboard_AE.Name = "dashboard_AE";
            this.dashboard_AE.Size = new System.Drawing.Size(40, 47);
            this.dashboard_AE.TabIndex = 4;
            this.dashboard_AE.Text = "0";

            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.label4.Location = new System.Drawing.Point(14, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Active Employees";

            // ── STAT CARD — Inactive Employees ───────────────────────────────
            this.panel5.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panel5.Controls.Add(this.card5Accent);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.dashboard_IE);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(584, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 130);
            this.panel5.TabIndex = 2;

            this.card5Accent.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.card5Accent.Dock = System.Windows.Forms.DockStyle.Left;
            this.card5Accent.Location = new System.Drawing.Point(0, 0);
            this.card5Accent.Name = "card5Accent";
            this.card5Accent.Size = new System.Drawing.Size(5, 130);
            this.card5Accent.TabIndex = 10;

            this.pictureBox3.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_group_background_selected_60px;
            this.pictureBox3.Location = new System.Drawing.Point(14, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;

            this.dashboard_IE.AutoSize = true;
            this.dashboard_IE.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.dashboard_IE.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.dashboard_IE.Location = new System.Drawing.Point(74, 18);
            this.dashboard_IE.Name = "dashboard_IE";
            this.dashboard_IE.Size = new System.Drawing.Size(40, 47);
            this.dashboard_IE.TabIndex = 6;
            this.dashboard_IE.Text = "0";

            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.label6.Location = new System.Drawing.Point(14, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Inactive Employees";

            // ── PHOTO / BOTTOM PANEL ─────────────────────────────────────────
            this.panel2.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(12, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 312);
            this.panel2.TabIndex = 1;

            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::EmployeeManagementSystem.Properties.Resources.pexels_jane_doan_1024248;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(846, 312);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;

            // ── CONTROL ──────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(875, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCards;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel card5Accent;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel card4Accent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel card3Accent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label dashboard_IE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label dashboard_AE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dashboard_TE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

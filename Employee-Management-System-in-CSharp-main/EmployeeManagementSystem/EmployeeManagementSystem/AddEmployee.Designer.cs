
namespace EmployeeManagementSystem
{
    partial class AddEmployee
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle altRowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelGrid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.addEmployee_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addEmployee_fullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addEmployee_gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addEmployee_phoneNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addEmployee_position = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addEmployee_status = new System.Windows.Forms.ComboBox();
            this.addEmployee_picture = new System.Windows.Forms.PictureBox();
            this.addEmployee_importBtn = new System.Windows.Forms.Button();
            this.addEmployee_addBtn = new System.Windows.Forms.Button();
            this.addEmployee_updateBtn = new System.Windows.Forms.Button();
            this.addEmployee_deleteBtn = new System.Windows.Forms.Button();
            this.addEmployee_clearBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).BeginInit();
            this.SuspendLayout();

            // ── GRID PANEL ───────────────────────────────────────────────────
            this.panel1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.labelGrid);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 280);
            this.panel1.TabIndex = 0;

            this.labelGrid.AutoSize = true;
            this.labelGrid = new System.Windows.Forms.Label();
            this.labelGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelGrid.ForeColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.labelGrid.Location = new System.Drawing.Point(12, 12);
            this.labelGrid.Name = "labelGrid";
            this.labelGrid.Size = new System.Drawing.Size(130, 20);
            this.labelGrid.TabIndex = 2;
            this.labelGrid.Text = "Employee Records";

            // DataGridView
            headerStyle.BackColor = System.Drawing.Color.FromArgb(6, 182, 212);
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            rowStyle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(241, 245, 249);
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 9F);

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            altRowStyle.ForeColor = System.Drawing.Color.FromArgb(241, 245, 249);
            altRowStyle.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DefaultCellStyle = rowStyle;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = altRowStyle;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(822, 222);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            this.panel2.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panel2.Location = new System.Drawing.Point(0, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 0);
            this.panel2.TabIndex = 1;

            // ── FORM PANEL ───────────────────────────────────────────────────
            this.panel3.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.addEmployee_id);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.addEmployee_fullName);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.addEmployee_gender);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.addEmployee_phoneNum);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.addEmployee_position);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.addEmployee_status);
            this.panel3.Controls.Add(this.addEmployee_picture);
            this.panel3.Controls.Add(this.addEmployee_importBtn);
            this.panel3.Controls.Add(this.addEmployee_addBtn);
            this.panel3.Controls.Add(this.addEmployee_updateBtn);
            this.panel3.Controls.Add(this.addEmployee_deleteBtn);
            this.panel3.Controls.Add(this.addEmployee_clearBtn);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 310);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 235);
            this.panel3.TabIndex = 2;

            // Labels — muted style
            void StyleLabel(System.Windows.Forms.Label lbl, string text, System.Drawing.Point loc)
            {
                lbl.AutoSize = true;
                lbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
                lbl.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
                lbl.Location = loc;
                lbl.Text = text;
            }

            this.label2 = new System.Windows.Forms.Label();
            StyleLabel(this.label2, "EMP ID:", new System.Drawing.Point(20, 22));
            this.label2.Name = "label2"; this.label2.TabIndex = 2;

            this.label3 = new System.Windows.Forms.Label();
            StyleLabel(this.label3, "FULL NAME:", new System.Drawing.Point(20, 62));
            this.label3.Name = "label3"; this.label3.TabIndex = 4;

            this.label4 = new System.Windows.Forms.Label();
            StyleLabel(this.label4, "GENDER:", new System.Drawing.Point(20, 102));
            this.label4.Name = "label4"; this.label4.TabIndex = 6;

            this.label5 = new System.Windows.Forms.Label();
            StyleLabel(this.label5, "PHONE:", new System.Drawing.Point(290, 22));
            this.label5.Name = "label5"; this.label5.TabIndex = 8;

            this.label6 = new System.Windows.Forms.Label();
            StyleLabel(this.label6, "POSITION:", new System.Drawing.Point(290, 62));
            this.label6.Name = "label6"; this.label6.TabIndex = 10;

            this.label7 = new System.Windows.Forms.Label();
            StyleLabel(this.label7, "STATUS:", new System.Drawing.Point(290, 102));
            this.label7.Name = "label7"; this.label7.TabIndex = 18;

            // TextBox helper style
            void StyleTextBox(System.Windows.Forms.TextBox tb, System.Drawing.Point loc, int w = 200)
            {
                tb.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
                tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                tb.Font = new System.Drawing.Font("Segoe UI", 10F);
                tb.ForeColor = System.Drawing.Color.FromArgb(241, 245, 249);
                tb.Location = loc;
                tb.Size = new System.Drawing.Size(w, 24);
            }

            this.addEmployee_id = new System.Windows.Forms.TextBox();
            StyleTextBox(this.addEmployee_id, new System.Drawing.Point(110, 18), 160);
            this.addEmployee_id.Name = "addEmployee_id"; this.addEmployee_id.TabIndex = 3;

            this.addEmployee_fullName = new System.Windows.Forms.TextBox();
            StyleTextBox(this.addEmployee_fullName, new System.Drawing.Point(110, 58), 160);
            this.addEmployee_fullName.Name = "addEmployee_fullName"; this.addEmployee_fullName.TabIndex = 5;

            this.addEmployee_phoneNum = new System.Windows.Forms.TextBox();
            StyleTextBox(this.addEmployee_phoneNum, new System.Drawing.Point(370, 18), 180);
            this.addEmployee_phoneNum.Name = "addEmployee_phoneNum"; this.addEmployee_phoneNum.TabIndex = 9;

            // ComboBox helper style
            void StyleCombo(System.Windows.Forms.ComboBox cb, System.Drawing.Point loc, int w = 200)
            {
                cb.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
                cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                cb.Font = new System.Drawing.Font("Segoe UI", 10F);
                cb.ForeColor = System.Drawing.Color.FromArgb(241, 245, 249);
                cb.Location = loc;
                cb.Size = new System.Drawing.Size(w, 25);
                cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            }

            this.addEmployee_gender = new System.Windows.Forms.ComboBox();
            StyleCombo(this.addEmployee_gender, new System.Drawing.Point(110, 98), 160);
            this.addEmployee_gender.FormattingEnabled = true;
            this.addEmployee_gender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            this.addEmployee_gender.Name = "addEmployee_gender"; this.addEmployee_gender.TabIndex = 7;

            this.addEmployee_position = new System.Windows.Forms.ComboBox();
            StyleCombo(this.addEmployee_position, new System.Drawing.Point(370, 58), 200);
            this.addEmployee_position.FormattingEnabled = true;
            this.addEmployee_position.Items.AddRange(new object[] {
                "Business Management", "Front-End Developer",
                "Back-End Developer", "Data Administrator", "UI/UX Design" });
            this.addEmployee_position.Name = "addEmployee_position"; this.addEmployee_position.TabIndex = 11;

            this.addEmployee_status = new System.Windows.Forms.ComboBox();
            StyleCombo(this.addEmployee_status, new System.Drawing.Point(370, 98), 160);
            this.addEmployee_status.FormattingEnabled = true;
            this.addEmployee_status.Items.AddRange(new object[] { "Active", "Ianctive" });
            this.addEmployee_status.Name = "addEmployee_status"; this.addEmployee_status.TabIndex = 19;

            // Picture box
            this.addEmployee_picture.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.addEmployee_picture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addEmployee_picture.Location = new System.Drawing.Point(680, 16);
            this.addEmployee_picture.Name = "addEmployee_picture";
            this.addEmployee_picture.Size = new System.Drawing.Size(100, 110);
            this.addEmployee_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmployee_picture.TabIndex = 12;
            this.addEmployee_picture.TabStop = false;

            // Import button
            this.addEmployee_importBtn.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.addEmployee_importBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_importBtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_importBtn.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.addEmployee_importBtn.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.addEmployee_importBtn.Location = new System.Drawing.Point(680, 134);
            this.addEmployee_importBtn.Name = "addEmployee_importBtn";
            this.addEmployee_importBtn.Size = new System.Drawing.Size(100, 28);
            this.addEmployee_importBtn.TabIndex = 13;
            this.addEmployee_importBtn.Text = "📁 Import";
            this.addEmployee_importBtn.UseVisualStyleBackColor = false;
            this.addEmployee_importBtn.Click += new System.EventHandler(this.addEmployee_importBtn_Click);

            // Action buttons helper
            void StyleBtn(System.Windows.Forms.Button btn, string text, System.Drawing.Point loc,
                System.Drawing.Color bg, System.Drawing.Color fg, System.EventHandler handler)
            {
                btn.BackColor = bg;
                btn.Cursor = System.Windows.Forms.Cursors.Hand;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                btn.ForeColor = fg;
                btn.Location = loc;
                btn.Size = new System.Drawing.Size(120, 38);
                btn.Text = text;
                btn.UseVisualStyleBackColor = false;
                btn.Click += handler;
            }

            this.addEmployee_addBtn = new System.Windows.Forms.Button();
            this.addEmployee_addBtn.Name = "addEmployee_addBtn"; this.addEmployee_addBtn.TabIndex = 14;
            StyleBtn(this.addEmployee_addBtn, "✔ Add", new System.Drawing.Point(20, 178),
                System.Drawing.Color.FromArgb(16, 185, 129), System.Drawing.Color.White,
                this.addEmployee_addBtn_Click);

            this.addEmployee_updateBtn = new System.Windows.Forms.Button();
            this.addEmployee_updateBtn.Name = "addEmployee_updateBtn"; this.addEmployee_updateBtn.TabIndex = 15;
            StyleBtn(this.addEmployee_updateBtn, "✎ Update", new System.Drawing.Point(152, 178),
                System.Drawing.Color.FromArgb(6, 182, 212), System.Drawing.Color.FromArgb(15, 23, 42),
                this.addEmployee_updateBtn_Click);

            this.addEmployee_deleteBtn = new System.Windows.Forms.Button();
            this.addEmployee_deleteBtn.Name = "addEmployee_deleteBtn"; this.addEmployee_deleteBtn.TabIndex = 16;
            StyleBtn(this.addEmployee_deleteBtn, "✖ Delete", new System.Drawing.Point(284, 178),
                System.Drawing.Color.FromArgb(239, 68, 68), System.Drawing.Color.White,
                this.addEmployee_deleteBtn_Click);

            this.addEmployee_clearBtn = new System.Windows.Forms.Button();
            this.addEmployee_clearBtn.Name = "addEmployee_clearBtn"; this.addEmployee_clearBtn.TabIndex = 17;
            StyleBtn(this.addEmployee_clearBtn, "↺ Clear", new System.Drawing.Point(416, 178),
                System.Drawing.Color.FromArgb(245, 158, 11), System.Drawing.Color.FromArgb(15, 23, 42),
                this.addEmployee_clearBtn_Click);

            this.panel4.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panel4.Location = new System.Drawing.Point(0, 280);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(846, 0);
            this.panel4.TabIndex = 1;

            // ── CONTROL ──────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(875, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addEmployee_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addEmployee_fullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox addEmployee_gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addEmployee_phoneNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addEmployee_position;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox addEmployee_status;
        private System.Windows.Forms.PictureBox addEmployee_picture;
        private System.Windows.Forms.Button addEmployee_importBtn;
        private System.Windows.Forms.Button addEmployee_addBtn;
        private System.Windows.Forms.Button addEmployee_updateBtn;
        private System.Windows.Forms.Button addEmployee_deleteBtn;
        private System.Windows.Forms.Button addEmployee_clearBtn;
        private System.Windows.Forms.Label label1;
    }
}

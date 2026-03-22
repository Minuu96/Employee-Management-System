
namespace EmployeeManagementSystem
{
    partial class Salary
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
            this.labelForm = new System.Windows.Forms.Label();
            this.salary_clearBtn = new System.Windows.Forms.Button();
            this.salary_updateBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.salary_salary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salary_position = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salary_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.salary_employeeID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // ── LEFT FORM PANEL ──────────────────────────────────────────────
            this.panel1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel1.Controls.Add(this.labelForm);
            this.panel1.Controls.Add(this.salary_clearBtn);
            this.panel1.Controls.Add(this.salary_updateBtn);
            this.panel1.Controls.Add(this.salary_salary);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.salary_position);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.salary_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.salary_employeeID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 530);
            this.panel1.TabIndex = 0;

            this.labelForm.AutoSize = true;
            this.labelForm = new System.Windows.Forms.Label();
            this.labelForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelForm.ForeColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.labelForm.Location = new System.Drawing.Point(14, 18);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(130, 22);
            this.labelForm.TabIndex = 20;
            this.labelForm.Text = "Salary Details";

            // Labels — muted uppercase
            void StyleLabel(System.Windows.Forms.Label lbl, string text, System.Drawing.Point loc)
            {
                lbl.AutoSize = true;
                lbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
                lbl.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
                lbl.Location = loc;
                lbl.Text = text;
            }

            this.label2 = new System.Windows.Forms.Label();
            StyleLabel(this.label2, "EMPLOYEE ID:", new System.Drawing.Point(16, 66));
            this.label2.Name = "label2"; this.label2.TabIndex = 0;

            this.label3 = new System.Windows.Forms.Label();
            StyleLabel(this.label3, "FULL NAME:", new System.Drawing.Point(16, 130));
            this.label3.Name = "label3"; this.label3.TabIndex = 2;

            this.label4 = new System.Windows.Forms.Label();
            StyleLabel(this.label4, "POSITION:", new System.Drawing.Point(16, 194));
            this.label4.Name = "label4"; this.label4.TabIndex = 4;

            this.label5 = new System.Windows.Forms.Label();
            StyleLabel(this.label5, "SALARY (₹):", new System.Drawing.Point(16, 258));
            this.label5.Name = "label5"; this.label5.TabIndex = 6;

            // TextBox helper style
            void StyleTextBox(System.Windows.Forms.TextBox tb, System.Drawing.Point loc)
            {
                tb.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
                tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                tb.Font = new System.Drawing.Font("Segoe UI", 11F);
                tb.ForeColor = System.Drawing.Color.FromArgb(241, 245, 249);
                tb.Location = loc;
                tb.Multiline = true;
                tb.Size = new System.Drawing.Size(260, 30);
            }

            this.salary_employeeID = new System.Windows.Forms.TextBox();
            StyleTextBox(this.salary_employeeID, new System.Drawing.Point(16, 86));
            this.salary_employeeID.Name = "salary_employeeID"; this.salary_employeeID.TabIndex = 1;

            this.salary_name = new System.Windows.Forms.TextBox();
            StyleTextBox(this.salary_name, new System.Drawing.Point(16, 150));
            this.salary_name.Name = "salary_name"; this.salary_name.TabIndex = 3;

            this.salary_position = new System.Windows.Forms.TextBox();
            StyleTextBox(this.salary_position, new System.Drawing.Point(16, 214));
            this.salary_position.Name = "salary_position"; this.salary_position.TabIndex = 5;

            this.salary_salary = new System.Windows.Forms.TextBox();
            StyleTextBox(this.salary_salary, new System.Drawing.Point(16, 278));
            this.salary_salary.Name = "salary_salary"; this.salary_salary.TabIndex = 7;

            // Buttons
            this.salary_updateBtn.BackColor = System.Drawing.Color.FromArgb(6, 182, 212);
            this.salary_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_updateBtn.FlatAppearance.BorderSize = 0;
            this.salary_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(8, 145, 178);
            this.salary_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(8, 145, 178);
            this.salary_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salary_updateBtn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.salary_updateBtn.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.salary_updateBtn.Location = new System.Drawing.Point(16, 336);
            this.salary_updateBtn.Name = "salary_updateBtn";
            this.salary_updateBtn.Size = new System.Drawing.Size(120, 38);
            this.salary_updateBtn.TabIndex = 15;
            this.salary_updateBtn.Text = "✎ Update";
            this.salary_updateBtn.UseVisualStyleBackColor = false;
            this.salary_updateBtn.Click += new System.EventHandler(this.salary_updateBtn_Click);

            this.salary_clearBtn.BackColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.salary_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_clearBtn.FlatAppearance.BorderSize = 0;
            this.salary_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salary_clearBtn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.salary_clearBtn.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.salary_clearBtn.Location = new System.Drawing.Point(148, 336);
            this.salary_clearBtn.Name = "salary_clearBtn";
            this.salary_clearBtn.Size = new System.Drawing.Size(120, 38);
            this.salary_clearBtn.TabIndex = 16;
            this.salary_clearBtn.Text = "↺ Clear";
            this.salary_clearBtn.UseVisualStyleBackColor = false;
            this.salary_clearBtn.Click += new System.EventHandler(this.salary_clearBtn_Click);

            // ── RIGHT GRID PANEL ─────────────────────────────────────────────
            this.panel2.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(322, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 530);
            this.panel2.TabIndex = 1;

            this.label1.AutoSize = true;
            this.label1 = new System.Windows.Forms.Label();
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees";

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
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(512, 462);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // ── CONTROL ──────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Salary";
            this.Size = new System.Drawing.Size(875, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salary_employeeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salary_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salary_position;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox salary_salary;
        private System.Windows.Forms.Button salary_clearBtn;
        private System.Windows.Forms.Button salary_updateBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

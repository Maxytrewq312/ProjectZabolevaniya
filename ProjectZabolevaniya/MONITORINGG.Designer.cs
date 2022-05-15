
namespace ProjectZabolevaniya
{
    partial class MONITORINGG
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.DateBegin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateExit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Employee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.BREMOVE = new System.Windows.Forms.Button();
            this.BEDIT = new System.Windows.Forms.Button();
            this.BADD = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CBEMPM = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TEXIT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBEGIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBSTATUS = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DateBegin,
            this.DateExit,
            this.Status,
            this.Employee});
            this.listView1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(338, 139);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(819, 404);
            this.listView1.TabIndex = 70;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // DateBegin
            // 
            this.DateBegin.Text = "ДАТА НАЧАЛА БОЛЕЗНИ";
            this.DateBegin.Width = 282;
            // 
            // DateExit
            // 
            this.DateExit.Text = "ДАТА ВЫХОДА НА РАБОТУ";
            this.DateExit.Width = 231;
            // 
            // Status
            // 
            this.Status.Text = "СТАТУС";
            this.Status.Width = 144;
            // 
            // Employee
            // 
            this.Employee.Text = "СОТРУДНИК";
            this.Employee.Width = 155;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Beige;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(946, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 47);
            this.button4.TabIndex = 69;
            this.button4.Text = "ВЕРНУТЬСЯ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BREMOVE
            // 
            this.BREMOVE.BackColor = System.Drawing.Color.Red;
            this.BREMOVE.FlatAppearance.BorderSize = 0;
            this.BREMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BREMOVE.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BREMOVE.ForeColor = System.Drawing.Color.Black;
            this.BREMOVE.Location = new System.Drawing.Point(946, 562);
            this.BREMOVE.Name = "BREMOVE";
            this.BREMOVE.Size = new System.Drawing.Size(211, 47);
            this.BREMOVE.TabIndex = 68;
            this.BREMOVE.Text = "УДАЛИТЬ";
            this.BREMOVE.UseVisualStyleBackColor = false;
            this.BREMOVE.Click += new System.EventHandler(this.BREMOVE_Click);
            // 
            // BEDIT
            // 
            this.BEDIT.BackColor = System.Drawing.Color.LawnGreen;
            this.BEDIT.FlatAppearance.BorderSize = 0;
            this.BEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEDIT.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BEDIT.ForeColor = System.Drawing.Color.Black;
            this.BEDIT.Location = new System.Drawing.Point(729, 562);
            this.BEDIT.Name = "BEDIT";
            this.BEDIT.Size = new System.Drawing.Size(211, 47);
            this.BEDIT.TabIndex = 67;
            this.BEDIT.Text = "ОБНОВИТЬ";
            this.BEDIT.UseVisualStyleBackColor = false;
            this.BEDIT.Click += new System.EventHandler(this.BEDIT_Click);
            // 
            // BADD
            // 
            this.BADD.BackColor = System.Drawing.Color.LawnGreen;
            this.BADD.FlatAppearance.BorderSize = 0;
            this.BADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BADD.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BADD.ForeColor = System.Drawing.Color.Black;
            this.BADD.Location = new System.Drawing.Point(512, 562);
            this.BADD.Name = "BADD";
            this.BADD.Size = new System.Drawing.Size(211, 47);
            this.BADD.TabIndex = 66;
            this.BADD.Text = "СОЗДАТЬ";
            this.BADD.UseVisualStyleBackColor = false;
            this.BADD.Click += new System.EventHandler(this.BADD_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.LawnGreen;
            this.label9.Location = new System.Drawing.Point(11, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 26);
            this.label9.TabIndex = 65;
            this.label9.Text = "Сотрудник";
            // 
            // CBEMPM
            // 
            this.CBEMPM.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBEMPM.FormattingEnabled = true;
            this.CBEMPM.Location = new System.Drawing.Point(16, 390);
            this.CBEMPM.Name = "CBEMPM";
            this.CBEMPM.Size = new System.Drawing.Size(288, 34);
            this.CBEMPM.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.LawnGreen;
            this.label6.Location = new System.Drawing.Point(11, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 26);
            this.label6.TabIndex = 63;
            this.label6.Text = "Статус";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(11, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 26);
            this.label2.TabIndex = 61;
            this.label2.Text = "Дата выхода на работу";
            // 
            // TEXIT
            // 
            this.TEXIT.Font = new System.Drawing.Font("Montserrat Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TEXIT.Location = new System.Drawing.Point(16, 240);
            this.TEXIT.Multiline = true;
            this.TEXIT.Name = "TEXIT";
            this.TEXIT.Size = new System.Drawing.Size(288, 38);
            this.TEXIT.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.LawnGreen;
            this.label4.Location = new System.Drawing.Point(491, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 33);
            this.label4.TabIndex = 59;
            this.label4.Text = "MONITORING";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.LawnGreen;
            this.label5.Location = new System.Drawing.Point(11, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 26);
            this.label5.TabIndex = 58;
            this.label5.Text = "Дата начала болезни";
            // 
            // TBEGIN
            // 
            this.TBEGIN.Font = new System.Drawing.Font("Montserrat Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBEGIN.Location = new System.Drawing.Point(16, 165);
            this.TBEGIN.Multiline = true;
            this.TBEGIN.Name = "TBEGIN";
            this.TBEGIN.Size = new System.Drawing.Size(288, 38);
            this.TBEGIN.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 22);
            this.label3.TabIndex = 56;
            this.label3.Text = "DISEASE MONITORING COMPANY";
            // 
            // CBSTATUS
            // 
            this.CBSTATUS.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBSTATUS.FormattingEnabled = true;
            this.CBSTATUS.Location = new System.Drawing.Point(16, 315);
            this.CBSTATUS.Name = "CBSTATUS";
            this.CBSTATUS.Size = new System.Drawing.Size(288, 34);
            this.CBSTATUS.TabIndex = 71;
            // 
            // MONITORINGG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1169, 626);
            this.Controls.Add(this.CBSTATUS);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BREMOVE);
            this.Controls.Add(this.BEDIT);
            this.Controls.Add(this.BADD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CBEMPM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TEXIT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBEGIN);
            this.Controls.Add(this.label3);
            this.Name = "MONITORINGG";
            this.Text = "MONITORING";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader DateBegin;
        private System.Windows.Forms.ColumnHeader DateExit;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Employee;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BREMOVE;
        private System.Windows.Forms.Button BEDIT;
        private System.Windows.Forms.Button BADD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBEMPM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TEXIT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBEGIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBSTATUS;

        #endregion
    }
}

namespace ProjectZabolevaniya
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BAUTH = new System.Windows.Forms.Button();
            this.TLOG = new System.Windows.Forms.TextBox();
            this.TPASS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BNOAC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BAUTH
            // 
            this.BAUTH.BackColor = System.Drawing.Color.LawnGreen;
            this.BAUTH.FlatAppearance.BorderSize = 0;
            this.BAUTH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAUTH.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAUTH.ForeColor = System.Drawing.Color.Black;
            this.BAUTH.Location = new System.Drawing.Point(158, 357);
            this.BAUTH.Name = "BAUTH";
            this.BAUTH.Size = new System.Drawing.Size(352, 47);
            this.BAUTH.TabIndex = 1;
            this.BAUTH.Text = "ВОЙТИ";
            this.BAUTH.UseVisualStyleBackColor = false;
            this.BAUTH.Click += new System.EventHandler(this.BAUTH_Click);
            // 
            // TLOG
            // 
            this.TLOG.Font = new System.Drawing.Font("Montserrat Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TLOG.Location = new System.Drawing.Point(158, 172);
            this.TLOG.Multiline = true;
            this.TLOG.Name = "TLOG";
            this.TLOG.Size = new System.Drawing.Size(352, 43);
            this.TLOG.TabIndex = 2;
            // 
            // TPASS
            // 
            this.TPASS.Font = new System.Drawing.Font("Montserrat Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TPASS.Location = new System.Drawing.Point(158, 264);
            this.TPASS.Multiline = true;
            this.TPASS.Name = "TPASS";
            this.TPASS.PasswordChar = '*';
            this.TPASS.Size = new System.Drawing.Size(352, 43);
            this.TPASS.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(154, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(154, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "DISEASE MONITORING COMPANY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.LawnGreen;
            this.label4.Location = new System.Drawing.Point(220, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "AUTHORIZATION";
            // 
            // BNOAC
            // 
            this.BNOAC.BackColor = System.Drawing.Color.Yellow;
            this.BNOAC.FlatAppearance.BorderSize = 0;
            this.BNOAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNOAC.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BNOAC.ForeColor = System.Drawing.Color.Black;
            this.BNOAC.Location = new System.Drawing.Point(490, 12);
            this.BNOAC.Name = "BNOAC";
            this.BNOAC.Size = new System.Drawing.Size(168, 47);
            this.BNOAC.TabIndex = 8;
            this.BNOAC.Text = "У МЕНЯ НЕТ АККАУНТА";
            this.BNOAC.UseVisualStyleBackColor = false;
            this.BNOAC.Click += new System.EventHandler(this.BNOAC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(670, 468);
            this.Controls.Add(this.BNOAC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TPASS);
            this.Controls.Add(this.TLOG);
            this.Controls.Add(this.BAUTH);
            this.Name = "Form1";
            this.Text = "AUTH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAUTH;
        private System.Windows.Forms.TextBox TLOG;
        private System.Windows.Forms.TextBox TPASS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BNOAC;
    }
}


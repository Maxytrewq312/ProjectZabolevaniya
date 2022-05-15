
namespace ProjectZabolevaniya
{
    partial class Main
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BEMP = new System.Windows.Forms.Button();
            this.BSTAT = new System.Windows.Forms.Button();
            this.BMON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.LawnGreen;
            this.label4.Location = new System.Drawing.Point(217, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "MAIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "DISEASE MONITORING COMPANY";
            // 
            // BEMP
            // 
            this.BEMP.BackColor = System.Drawing.Color.Yellow;
            this.BEMP.FlatAppearance.BorderSize = 0;
            this.BEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEMP.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BEMP.ForeColor = System.Drawing.Color.Black;
            this.BEMP.Location = new System.Drawing.Point(59, 133);
            this.BEMP.Name = "BEMP";
            this.BEMP.Size = new System.Drawing.Size(392, 62);
            this.BEMP.TabIndex = 17;
            this.BEMP.Text = "СОТРУДНИКИ";
            this.BEMP.UseVisualStyleBackColor = false;
            this.BEMP.Click += new System.EventHandler(this.BEMP_Click);
            // 
            // BSTAT
            // 
            this.BSTAT.BackColor = System.Drawing.Color.Yellow;
            this.BSTAT.FlatAppearance.BorderSize = 0;
            this.BSTAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSTAT.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSTAT.ForeColor = System.Drawing.Color.Black;
            this.BSTAT.Location = new System.Drawing.Point(59, 214);
            this.BSTAT.Name = "BSTAT";
            this.BSTAT.Size = new System.Drawing.Size(392, 62);
            this.BSTAT.TabIndex = 18;
            this.BSTAT.Text = "СТАТУС";
            this.BSTAT.UseVisualStyleBackColor = false;
            this.BSTAT.Click += new System.EventHandler(this.BSTAT_Click);
            // 
            // BMON
            // 
            this.BMON.BackColor = System.Drawing.Color.Yellow;
            this.BMON.FlatAppearance.BorderSize = 0;
            this.BMON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMON.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMON.ForeColor = System.Drawing.Color.Black;
            this.BMON.Location = new System.Drawing.Point(59, 295);
            this.BMON.Name = "BMON";
            this.BMON.Size = new System.Drawing.Size(392, 62);
            this.BMON.TabIndex = 19;
            this.BMON.Text = "МОНИТОРИНГ ЗАБОЛЕВШИХ";
            this.BMON.UseVisualStyleBackColor = false;
            this.BMON.Click += new System.EventHandler(this.BMON_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(521, 398);
            this.Controls.Add(this.BMON);
            this.Controls.Add(this.BSTAT);
            this.Controls.Add(this.BEMP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BEMP;
        private System.Windows.Forms.Button BSTAT;
        private System.Windows.Forms.Button BMON;
    }
}
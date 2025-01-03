namespace prjFinalCountdown
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblLAbel = new System.Windows.Forms.Label();
            this.lblHoursMinutesSeconds = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTotalSeconds = new System.Windows.Forms.Label();
            this.lblTotalMinutes = new System.Windows.Forms.Label();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLAbel
            // 
            this.lblLAbel.AutoSize = true;
            this.lblLAbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLAbel.Location = new System.Drawing.Point(12, 9);
            this.lblLAbel.Name = "lblLAbel";
            this.lblLAbel.Size = new System.Drawing.Size(92, 32);
            this.lblLAbel.TabIndex = 0;
            this.lblLAbel.Text = "label1";
            // 
            // lblHoursMinutesSeconds
            // 
            this.lblHoursMinutesSeconds.AutoSize = true;
            this.lblHoursMinutesSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursMinutesSeconds.Location = new System.Drawing.Point(12, 41);
            this.lblHoursMinutesSeconds.Name = "lblHoursMinutesSeconds";
            this.lblHoursMinutesSeconds.Size = new System.Drawing.Size(92, 32);
            this.lblHoursMinutesSeconds.TabIndex = 0;
            this.lblHoursMinutesSeconds.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTotalSeconds
            // 
            this.lblTotalSeconds.AutoSize = true;
            this.lblTotalSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSeconds.Location = new System.Drawing.Point(12, 90);
            this.lblTotalSeconds.Name = "lblTotalSeconds";
            this.lblTotalSeconds.Size = new System.Drawing.Size(92, 32);
            this.lblTotalSeconds.TabIndex = 0;
            this.lblTotalSeconds.Text = "label1";
            // 
            // lblTotalMinutes
            // 
            this.lblTotalMinutes.AutoSize = true;
            this.lblTotalMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMinutes.Location = new System.Drawing.Point(12, 122);
            this.lblTotalMinutes.Name = "lblTotalMinutes";
            this.lblTotalMinutes.Size = new System.Drawing.Size(92, 32);
            this.lblTotalMinutes.TabIndex = 0;
            this.lblTotalMinutes.Text = "label1";
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHours.Location = new System.Drawing.Point(12, 154);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(92, 32);
            this.lblTotalHours.TabIndex = 0;
            this.lblTotalHours.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 201);
            this.Controls.Add(this.lblTotalHours);
            this.Controls.Add(this.lblTotalMinutes);
            this.Controls.Add(this.lblTotalSeconds);
            this.Controls.Add(this.lblHoursMinutesSeconds);
            this.Controls.Add(this.lblLAbel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLAbel;
        private System.Windows.Forms.Label lblHoursMinutesSeconds;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTotalSeconds;
        private System.Windows.Forms.Label lblTotalMinutes;
        private System.Windows.Forms.Label lblTotalHours;
    }
}


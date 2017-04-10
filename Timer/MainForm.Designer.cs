namespace Timer
{
    partial class MainForm
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
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.cbMinute = new System.Windows.Forms.ComboBox();
            this.cbSecond = new System.Windows.Forms.ComboBox();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.lblRemain = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnHibernate = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnSleep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbHour
            // 
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Location = new System.Drawing.Point(23, 109);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(54, 24);
            this.cbHour.TabIndex = 0;
            // 
            // cbMinute
            // 
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.Location = new System.Drawing.Point(141, 109);
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(54, 24);
            this.cbMinute.TabIndex = 1;
            // 
            // cbSecond
            // 
            this.cbSecond.FormattingEnabled = true;
            this.cbSecond.Location = new System.Drawing.Point(269, 109);
            this.cbSecond.Name = "cbSecond";
            this.cbSecond.Size = new System.Drawing.Size(54, 24);
            this.cbSecond.TabIndex = 2;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(83, 116);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(43, 16);
            this.lblHour.TabIndex = 3;
            this.lblHour.Text = "Hour";
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.Location = new System.Drawing.Point(201, 116);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(57, 16);
            this.lblMinute.TabIndex = 4;
            this.lblMinute.Text = "Minute";
            this.lblMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.Location = new System.Drawing.Point(329, 116);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(61, 16);
            this.lblSecond.TabIndex = 5;
            this.lblSecond.Text = "Second";
            this.lblSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Castellar", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(97, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(207, 34);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Nice Timer";
            // 
            // btnLogoff
            // 
            this.btnLogoff.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnLogoff.Location = new System.Drawing.Point(141, 164);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(121, 38);
            this.btnLogoff.TabIndex = 8;
            this.btnLogoff.Text = "Log off";
            this.btnLogoff.UseVisualStyleBackColor = true;
            // 
            // btnShutdown
            // 
            this.btnShutdown.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnShutdown.Location = new System.Drawing.Point(141, 208);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(121, 38);
            this.btnShutdown.TabIndex = 11;
            this.btnShutdown.Text = "Shutdown";
            this.btnShutdown.UseVisualStyleBackColor = true;
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnResume.Location = new System.Drawing.Point(141, 252);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(121, 38);
            this.btnResume.TabIndex = 14;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold);
            this.lblText.Location = new System.Drawing.Point(23, 74);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(53, 17);
            this.lblText.TabIndex = 16;
            this.lblText.Text = "label5";
            // 
            // lblRemain
            // 
            this.lblRemain.AutoSize = true;
            this.lblRemain.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold);
            this.lblRemain.Location = new System.Drawing.Point(272, 74);
            this.lblRemain.Name = "lblRemain";
            this.lblRemain.Size = new System.Drawing.Size(53, 17);
            this.lblRemain.TabIndex = 17;
            this.lblRemain.Text = "label6";
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnPause.Location = new System.Drawing.Point(14, 252);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(121, 38);
            this.btnPause.TabIndex = 20;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnHibernate
            // 
            this.btnHibernate.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnHibernate.Location = new System.Drawing.Point(14, 208);
            this.btnHibernate.Name = "btnHibernate";
            this.btnHibernate.Size = new System.Drawing.Size(121, 38);
            this.btnHibernate.TabIndex = 19;
            this.btnHibernate.Text = "Hibernate";
            this.btnHibernate.UseVisualStyleBackColor = true;
            // 
            // btnLock
            // 
            this.btnLock.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnLock.Location = new System.Drawing.Point(14, 164);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(121, 38);
            this.btnLock.TabIndex = 18;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(269, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 38);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnRestart.Location = new System.Drawing.Point(269, 208);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(121, 38);
            this.btnRestart.TabIndex = 22;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // btnSleep
            // 
            this.btnSleep.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnSleep.Location = new System.Drawing.Point(269, 164);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(121, 38);
            this.btnSleep.TabIndex = 21;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 327);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnHibernate);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.lblRemain);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.cbSecond);
            this.Controls.Add(this.cbMinute);
            this.Controls.Add(this.cbHour);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.ComboBox cbMinute;
        private System.Windows.Forms.ComboBox cbSecond;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblRemain;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnHibernate;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnSleep;
    }
}
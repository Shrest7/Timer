namespace timer2
{
    partial class TimerBaseForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBoxTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::timer2.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(310, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBoxTime
            // 
            this.txtBoxTime.BackColor = System.Drawing.Color.Silver;
            this.txtBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxTime.Location = new System.Drawing.Point(13, 53);
            this.txtBoxTime.Name = "txtBoxTime";
            this.txtBoxTime.Size = new System.Drawing.Size(325, 76);
            this.txtBoxTime.TabIndex = 1;
            this.txtBoxTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTime_KeyDown);
            this.txtBoxTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTime_KeyPress);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(0, 283);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(349, 77);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Set a time!";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(15, 160);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(325, 55);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(15, 233);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(325, 55);
            this.btnResume.TabIndex = 4;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(277, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Location = new System.Drawing.Point(12, 14);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(75, 23);
            this.BtnSettings.TabIndex = 6;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // TimerBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(349, 365);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtBoxTime);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimerBaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBoxTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button BtnSettings;
    }
}


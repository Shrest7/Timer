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
            this.lblTime = new System.Windows.Forms.Label();
            this._mainTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.hoursUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondsUpDown = new System.Windows.Forms.NumericUpDown();
            this.minutesUpDown = new System.Windows.Forms.NumericUpDown();
            this._backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.btnResume = new System.Windows.Forms.Button();
            this.progressBar = new timer2.CustomProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.hoursUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::timer2.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(428, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(44, 267);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(405, 88);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Set a time:)";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _mainTimer
            // 
            this._mainTimer.Interval = 1000;
            this._mainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPause.Location = new System.Drawing.Point(329, 166);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(149, 55);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(15, 166);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 55);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(375, 5);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 50);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSettings.Location = new System.Drawing.Point(15, 12);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(114, 46);
            this.BtnSettings.TabIndex = 6;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.BackColor = System.Drawing.Color.Transparent;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHours.ForeColor = System.Drawing.Color.White;
            this.lblHours.Location = new System.Drawing.Point(84, 75);
            this.lblHours.Margin = new System.Windows.Forms.Padding(0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(78, 73);
            this.lblHours.TabIndex = 9;
            this.lblHours.Text = "H";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.BackColor = System.Drawing.Color.Transparent;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMinutes.ForeColor = System.Drawing.Color.White;
            this.lblMinutes.Location = new System.Drawing.Point(245, 76);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(85, 73);
            this.lblMinutes.TabIndex = 11;
            this.lblMinutes.Text = "M";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.BackColor = System.Drawing.Color.Transparent;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSeconds.ForeColor = System.Drawing.Color.White;
            this.lblSeconds.Location = new System.Drawing.Point(408, 76);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(75, 73);
            this.lblSeconds.TabIndex = 13;
            this.lblSeconds.Text = "S";
            // 
            // hoursUpDown
            // 
            this.hoursUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hoursUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hoursUpDown.Location = new System.Drawing.Point(15, 82);
            this.hoursUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.hoursUpDown.Name = "hoursUpDown";
            this.hoursUpDown.Size = new System.Drawing.Size(76, 58);
            this.hoursUpDown.TabIndex = 2;
            this.hoursUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursUpDown.Enter += new System.EventHandler(this.HoursUpDown_Enter);
            this.hoursUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HoursUpDown_KeyDown);
            this.hoursUpDown.Leave += new System.EventHandler(this.HandleEmptyNumericUpDown);
            // 
            // secondsUpDown
            // 
            this.secondsUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsUpDown.Location = new System.Drawing.Point(339, 82);
            this.secondsUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsUpDown.Name = "secondsUpDown";
            this.secondsUpDown.Size = new System.Drawing.Size(76, 58);
            this.secondsUpDown.TabIndex = 4;
            this.secondsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.secondsUpDown.Enter += new System.EventHandler(this.SecondsUpDown_Enter);
            this.secondsUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SecondsUpDown_KeyDown);
            this.secondsUpDown.Leave += new System.EventHandler(this.HandleEmptyNumericUpDown);
            // 
            // minutesUpDown
            // 
            this.minutesUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minutesUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesUpDown.Location = new System.Drawing.Point(174, 82);
            this.minutesUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesUpDown.Name = "minutesUpDown";
            this.minutesUpDown.Size = new System.Drawing.Size(76, 58);
            this.minutesUpDown.TabIndex = 3;
            this.minutesUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minutesUpDown.Enter += new System.EventHandler(this.MinutesUpDown_Enter);
            this.minutesUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MinutesUpDown_KeyDown);
            this.minutesUpDown.Leave += new System.EventHandler(this.HandleEmptyNumericUpDown);
            // 
            // _backgroundWorker
            // 
            this._backgroundWorker.WorkerReportsProgress = true;
            this._backgroundWorker.WorkerSupportsCancellation = true;
            this._backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this._backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            // 
            // btnResume
            // 
            this.btnResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResume.Location = new System.Drawing.Point(172, 166);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(149, 55);
            this.btnResume.TabIndex = 14;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.BtnResume_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 241);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(463, 33);
            this.progressBar.TabIndex = 1;
            // 
            // TimerBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(493, 358);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.minutesUpDown);
            this.Controls.Add(this.secondsUpDown);
            this.Controls.Add(this.hoursUpDown);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimerBaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.hoursUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer _mainTimer;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.NumericUpDown hoursUpDown;
        private System.Windows.Forms.NumericUpDown secondsUpDown;
        private System.Windows.Forms.NumericUpDown minutesUpDown;
        private CustomProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker _backgroundWorker;
        private System.Windows.Forms.Button btnResume;
    }
}


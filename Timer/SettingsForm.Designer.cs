namespace timer2
{
    partial class SettingsForm
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
            this.DockTimerCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // DockTimerCheckBox
            // 
            this.DockTimerCheckBox.AutoSize = true;
            this.DockTimerCheckBox.Location = new System.Drawing.Point(12, 12);
            this.DockTimerCheckBox.Name = "DockTimerCheckBox";
            this.DockTimerCheckBox.Size = new System.Drawing.Size(15, 14);
            this.DockTimerCheckBox.TabIndex = 0;
            this.DockTimerCheckBox.UseVisualStyleBackColor = true;
            this.DockTimerCheckBox.CheckedChanged += new System.EventHandler(this.DockTimerCheckBox_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 38);
            this.Controls.Add(this.DockTimerCheckBox);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox DockTimerCheckBox;
    }
}
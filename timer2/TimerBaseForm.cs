using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace timer2
{
    public partial class TimerBaseForm : Form
    {
        const int taskbarHeight = 40;
        SoundPlayer soundPlayer;
        TimeSpan tsp = new TimeSpan();

        private static SettingsForm _settingsForm;
        public static SettingsForm GetSettingsForm
        {
            get
            {
                if (_settingsForm == null || _settingsForm.IsDisposed)
                    _settingsForm = new SettingsForm();
                return _settingsForm;
            }
        }

        public string ConvertCommaToDot(string text)
        {
            char[] textArr = text.ToCharArray();

            for(int i = 0; i<textArr.Length; i++)
            {
                if (textArr[i].Equals(','))
                    textArr[i] = '.';
            }
            return new string(textArr);
        }
        public TimerBaseForm()
        {
            InitializeComponent();
            //_settingsForm = GetSettingsForm;
            const string fileName = "videoplayback.wav";
            string currentDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(currentDirectory).Parent.FullName;
            
            string path = Path.Combine(projectDirectory, @"Resources", fileName);
            soundPlayer = new SoundPlayer(path);

            this.Location = new Point(1920 - Size.Width, 1080 - Size.Height - taskbarHeight);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan second = TimeSpan.FromSeconds(1);
            tsp = tsp.Subtract(second);
            if(tsp.Seconds >= 0)
            {
                lblTime.Text = tsp.ToString("hh':'mm':'ss");
            }
            else
            {
                timer1.Stop();
            }

            if (!timer1.Enabled)    
            {
                soundPlayer.Play();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            soundPlayer.Stop();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == false)
            {
                timer1.Start();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                try
                {
                    float time = float.Parse(ConvertCommaToDot(txtBoxTime.Text));
                    tsp = TimeSpan.FromHours(time);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (!string.IsNullOrEmpty(txtBoxTime.Text))
                {
                    timer1.Start();
                    lblTime.Text = tsp.ToString("hh':'mm':'ss");
                }
                txtBoxTime.Clear();
            }
        }

        private void txtBoxTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Space)
            {
                if (timer1.Enabled)
                {
                    timer1.Stop();
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            _settingsForm.Show();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HT_CAPTION = 0x2;

            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
    }
}

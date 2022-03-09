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
using System.Globalization;

namespace timer2
{
    public partial class TimerBaseForm : Form
    {
        private readonly Timer _progressTimer;
        private SoundPlayer _soundPlayer;
        private TimeSpan _timeSpan;
        private int _elapsedTimePercentage;
        private bool _isPaused = false;

        private SettingsForm _settingsForm;
        public SettingsForm GetSettingsForm
        {
            get
            {
                if (_settingsForm == null || _settingsForm.IsDisposed)
                    _settingsForm = new SettingsForm();
                return _settingsForm;
            }
        }

        public TimerBaseForm()
        {
            InitializeComponent();

            _settingsForm = GetSettingsForm;
            _timeSpan = new TimeSpan();
            _progressTimer = new Timer();
            SetUpSoundPlayer();
            SetUpNumericUpDowns();
            CenterToScreen();
        }

        private void SetUpNumericUpDowns()
        {
            hoursUpDown.Leave += HandleEmptyNumericUpDown;
            minutesUpDown.Leave += HandleEmptyNumericUpDown;
            secondsUpDown.Leave += HandleEmptyNumericUpDown;
        }

        private void HandleEmptyNumericUpDown(object sender, EventArgs e)
        {
            var numericUpDown = (NumericUpDown) sender;
            if (numericUpDown != null)
            {
                if (string.IsNullOrWhiteSpace(numericUpDown.Text))
                {
                    numericUpDown.Value = numericUpDown.Minimum;
                    numericUpDown.Text = numericUpDown.Value.ToString();
                }
            }
        }

        private void SetUpSoundPlayer()
        {
            const string fileName = "videoplayback.wav";
            string currentDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(currentDirectory).Parent.FullName;
            _progressTimer.Tick += ProgressTimer_Tick;
            string path = Path.Combine(projectDirectory, @"Resources", fileName);
            _soundPlayer = new SoundPlayer(path);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit?",
                "Confirm", MessageBoxButtons.YesNo);

            if(dialogResult.Equals(DialogResult.Yes))
                Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan second = TimeSpan.FromSeconds(1);
            _timeSpan = _timeSpan.Subtract(second);

            if(_timeSpan.Seconds >= 0)
            {
                UpdateLblTime();
            }
            else
            {
                ProgressBar.Value = 100;

                _mainTimer.Stop();
                _progressTimer.Stop();
                HandleSoundPlaying();
            }
        }

        private void HandleSoundPlaying()
        {
            _soundPlayer.PlayLooping();
            DialogResult dialogResult = MessageBox.Show("Time's up!",
                "Notification");

            if (dialogResult.Equals(DialogResult.OK))
                _soundPlayer.Stop();
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            IncreaseProgressBar(_elapsedTimePercentage);
            _elapsedTimePercentage++;
        }

        private void IncreaseProgressBar(int value)
        {
            if(value <= 100)
            {
                ProgressBar.Value = value;
                ProgressBar.Value = value - 1;
            }
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (_mainTimer.Enabled)
                _mainTimer.Stop();

            if (_progressTimer.Enabled)
                _progressTimer.Stop();
        }

        private void HandleCountdown()
        {
            _timeSpan = TimeSpan.Zero;

            int hours = (int) hoursUpDown.Value;
            int minutes = (int) minutesUpDown.Value;
            int seconds = (int) secondsUpDown.Value;

            _timeSpan = new TimeSpan(hours, minutes, seconds);

            if (_timeSpan.TotalSeconds == 0)
                return;

            var totalTime = _timeSpan.TotalHours;

            _progressTimer.Interval =
                    Convert.ToInt32(totalTime * 60 * 60 * 1000 / 100);

            _mainTimer.Start();
            _elapsedTimePercentage = 1;
            ProgressBar.Value = 0;
            _progressTimer.Start();

            UpdateLblTime();
        }

        private void UpdateLblTime()
        {
            if (_timeSpan.TotalDays < 1)
            {
                lblTime.Text = _timeSpan.ToString("hh':'mm':'ss");
            }
            else
            {
                lblTime.Text = _timeSpan.ToString("c", new CultureInfo("en-US"));
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HT_CAPTION = 0x2;

            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private void StartOnEnterClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;

                HandleEmptyNumericUpDown(sender, e);
                HandleCountdown();
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            _settingsForm.Show();
        }

        private void BtnStartResume_Click(object sender, EventArgs e)
        {
            HandleCountdown();
        }

        private void HoursUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            StartOnEnterClick(sender, e);
        }

        private void MinutesUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            StartOnEnterClick(sender, e);
        }

        private void SecondsUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            StartOnEnterClick(sender, e);
        }
    }
}

using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Threading;
using System.ComponentModel;

namespace timer2
{
    public partial class TimerBaseForm : Form
    {
        private readonly ManualResetEvent _resetEvent =
            new ManualResetEvent(false);
        private TimeSpan _mainTime = new TimeSpan();
        private SoundPlayer _soundPlayer;
        private int _totalTimeInSeconds;
        private bool _isPaused = false;


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

        public TimerBaseForm()
        {
            InitializeComponent();

            SetUpSoundPlayer();
            SetUpVisuals();
        }

        private void SetUpVisuals()
        {
            CenterToScreen();

            MaximumSize = Size;
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatAppearance.BorderSize = 1;
            btnMinimize.FlatAppearance.BorderSize = 1;
        }

        private void SetUpSoundPlayer()
        {
            const string fileName = "videoplayback.wav";
            string currentDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(currentDirectory).Parent.FullName;
            string path = Path.Combine(projectDirectory, @"Resources", fileName);
            _soundPlayer = new SoundPlayer(path);
        }

        private void HandleEmptyNumericUpDown(object sender, EventArgs e)
        {
            var numericUpDown = (NumericUpDown)sender;

            if (numericUpDown != null &&
                string.IsNullOrWhiteSpace(numericUpDown.Text))
            {
                numericUpDown.Value = numericUpDown.Minimum;
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            _mainTime = _mainTime.Subtract(TimeSpan.FromSeconds(1));

            if (_mainTime.Seconds >= 0)
            {
                UpdateLblTime();
            }
            else
            {
                _mainTimer.Stop();
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

        private void UpdateLblTime()
        {
            if (_mainTime.TotalDays < 1)
                lblTime.Text = _mainTime.ToString("hh':'mm':'ss");
            else
                lblTime.Text = _mainTime.ToString("c", new CultureInfo("en-US"));
        }

        // Makes dragging form possible with FormBorderStyle set to none.
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HT_CAPTION = 0x2;

            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (_backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    progressBar.Invoke(new Action(() =>
                    {
                        _backgroundWorker = new BackgroundWorker();
                        _backgroundWorker.DoWork += BackgroundWorker_DoWork;
                        _backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
                        _backgroundWorker.WorkerReportsProgress = true;
                        _backgroundWorker.WorkerSupportsCancellation = true;
                        _backgroundWorker.RunWorkerAsync();
                    }));

                    break;
                }

                _resetEvent.WaitOne();
                _backgroundWorker.ReportProgress(i);
                Thread.Sleep(_totalTimeInSeconds * 10);
            }
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
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

        private void StartOnEnterClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;

                HandleEmptyNumericUpDown(sender, e);
                HandleStart();
            }
        }

        private void MinutesUpDown_Enter(object sender, EventArgs e)
        {
            minutesUpDown.Select(0, minutesUpDown.Maximum.ToString().Length);
        }

        private void SecondsUpDown_Enter(object sender, EventArgs e)
        {
            secondsUpDown.Select(0, secondsUpDown.Maximum.ToString().Length);
        }

        private void HoursUpDown_Enter(object sender, EventArgs e)
        {
            hoursUpDown.Select(0, hoursUpDown.Maximum.ToString().Length);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            HandleStart();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            HandlePause();
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            if (_isPaused)
                HandleResume();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            _settingsForm = GetSettingsForm;
            _settingsForm.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit?",
                "Please confirm", MessageBoxButtons.YesNo);

            if (dialogResult.Equals(DialogResult.Yes))
                Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void HandleStart()
        {
            int hours = (int)hoursUpDown.Value;
            int minutes = (int)minutesUpDown.Value;
            int seconds = (int)secondsUpDown.Value;

            _mainTime = new TimeSpan(hours, minutes, seconds);
            _totalTimeInSeconds = (int)_mainTime.TotalSeconds;

            if (_mainTime.TotalSeconds == 0)
                return;

            _mainTimer.Start();

            progressBar.Value = 0;

            _backgroundWorker.CancelAsync();

            if (!_backgroundWorker.IsBusy)
            {
                _resetEvent.Set();
                _backgroundWorker.RunWorkerAsync();
            }

            UpdateLblTime();
        }

        private void HandleResume()
        {
            _mainTimer.Start();
            _isPaused = false;
            _resetEvent.Set();
        }

        private void HandlePause()
        {
            _isPaused = true;

            if (_mainTimer.Enabled)
                _mainTimer.Stop();

            if (_backgroundWorker.IsBusy)
                _resetEvent.Reset();
        }
    }
}
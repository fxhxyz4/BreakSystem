namespace BreakSystem
{
    public partial class BreakSystemUI : Form
    {
        private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
        private int _workSecondsRemaining;
        private int _breakSecondsRemaining;

        private int _initialWorkMinutes;
        private int _initialBreakMinutes;

        private bool _onBreak = false;
        private LockScreenForm _lockScreenForm;

        public BreakSystemUI()
        {
            InitializeComponent();

            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
        }

        private void BreakSystemUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(timeText.Text, out int workMinutes) ||
                !int.TryParse(breakText.Text, out int breakMinutes) ||
                workMinutes <= 0 || breakMinutes <= 0)
            {
                MessageBox.Show("Please enter valid positive integers for work and break time.");
                return;
            }

            _initialWorkMinutes = workMinutes;
            _initialBreakMinutes = breakMinutes;

            _workSecondsRemaining = _initialWorkMinutes * 60;
            _breakSecondsRemaining = _initialBreakMinutes * 60;

            _onBreak = false;

            title2.Text = "Work time";
            title3.Text = $"Break: {_initialBreakMinutes} minute(s)";

            MessageBox.Show($"Work time: {_initialWorkMinutes} min\nBreak time: {_initialBreakMinutes} min");

            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!_onBreak)
            {
                if (_workSecondsRemaining > 0)
                {
                    _workSecondsRemaining--;
                    UpdateTimerLabel(_workSecondsRemaining);
                }
                else
                {
                    _onBreak = true;
                    _breakSecondsRemaining = _initialBreakMinutes * 60;

                    title2.Text = "Break time";

                    _lockScreenForm = new LockScreenForm();
                    _lockScreenForm.Show();
                }
            }
            else
            {
                if (_breakSecondsRemaining > 0)
                {
                    _breakSecondsRemaining--;
                    UpdateTimerLabel(_breakSecondsRemaining);
                }
                else
                {
                    _onBreak = false;
                    _workSecondsRemaining = _initialWorkMinutes * 60;

                    _lockScreenForm?.Hide();
                    _lockScreenForm = null;

                    title2.Text = "Work time";
                }
            }
        }

        private void UpdateTimerLabel(int totalSeconds)
        {
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            timeText.Text = $"{minutes:D2}:{seconds:D2}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _timer.Stop();

            timeText.Text = "";
            breakText.Text = "";

            _workSecondsRemaining = 0;
            _breakSecondsRemaining = 0;

            _onBreak = false;

            _lockScreenForm?.Hide();
            _lockScreenForm = null;
        }
    }
}

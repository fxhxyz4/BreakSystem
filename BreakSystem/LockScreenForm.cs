using System.Runtime.CompilerServices;

namespace BreakSystem;

public partial class LockScreenForm : Form
{
    public LockScreenForm()
    {
        InitializeComponent();
        this.FormBorderStyle = FormBorderStyle.None;
        this.WindowState = FormWindowState.Maximized;

        this.TopMost = true;
        this.ControlBox = false;

        this.ShowInTaskbar = false;
        this.BackColor = Color.Black;

        Label label = new Label
        {
            Text = "Break time! Relax.",
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 48, FontStyle.Bold),
            AutoSize = true,
            Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - 300, (Screen.PrimaryScreen.Bounds.Height / 2) - 50)
        };

        this.Controls.Add(label);
    }
}
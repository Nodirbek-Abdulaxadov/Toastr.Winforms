namespace Toastr.Winforms;

public partial class Toast : Form
{
    private int _duration;
    private bool _enableSoundEffect;
    public Toast(ToastrPosition toastrPosition = ToastrPosition.TopRight, int duration = 3000,
                bool enableSoundEffect = false)
    {
        InitializeComponent();
        _duration = duration;
        _enableSoundEffect = enableSoundEffect;
        StartPosition = FormStartPosition.Manual;
        foreach (var scrn in Screen.AllScreens)
        {
            if (scrn.Bounds.Contains(Location))
            {
                switch (toastrPosition)
                {
                    case ToastrPosition.TopLeft:
                        Location = new Point(scrn.WorkingArea.Left + 10, scrn.WorkingArea.Top + 10);
                        break;
                    case ToastrPosition.TopRight:
                        Location = new Point(scrn.WorkingArea.Right - Width - 10, scrn.WorkingArea.Top + 10);
                        break;
                    case ToastrPosition.TopCenter:
                        Location = new Point(scrn.WorkingArea.Left + (scrn.WorkingArea.Width / 2) - (Width / 2), scrn.WorkingArea.Top + 10);
                        break;
                    case ToastrPosition.BottomLeft:
                        Location = new Point(scrn.WorkingArea.Left + 10, scrn.WorkingArea.Bottom - Height - 10);
                        break;
                    case ToastrPosition.BottomRight:
                        Location = new Point(scrn.WorkingArea.Right - Width - 10, scrn.WorkingArea.Bottom - Height - 10);
                        break;
                    case ToastrPosition.BottomCenter:
                        Location = new Point(scrn.WorkingArea.Left + (scrn.WorkingArea.Width / 2) - (Width / 2), scrn.WorkingArea.Bottom - Height - 10);
                        break;
                }
                return;
            }
        }
    }

    /// <summary>
    /// close toastr
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void close_Click(object sender, EventArgs e)
    {
        Close();
    }

    /// <summary>
    /// Show success
    /// </summary>
    public void ShowSuccess()
    {
        icon.Image = Properties.Resources.success_icon;
        message.Text = "Successfully!";
        BackColor = Color.FromArgb(113, 179, 113);
        Show();
        if (_enableSoundEffect)
        {
            PlaySounds.Success();
        }
    }

    /// <summary>
    /// Show success with custom message
    /// </summary>
    /// <param name="msg"></param>
    public void ShowSuccess(string msg)
    {
        icon.Image = Properties.Resources.success_icon;
        message.Text = msg;
        BackColor = Color.FromArgb(113, 179, 113);
        Show();
        if (_enableSoundEffect)
        {
            PlaySounds.Success();
        }
    }

    /// <summary>
    /// Show error
    /// </summary>
    public void ShowError()
    {
        icon.Image = Properties.Resources.error_icon;
        message.Text = "Something went wrong!";
        BackColor = Color.FromArgb(202, 94, 88);
        Show();
        if (_enableSoundEffect)
        {
            PlaySounds.Error();
        }
    }

    /// <summary>
    /// Show error with custom message
    /// </summary>
    public void ShowError(string msg)
    {
        icon.Image = Properties.Resources.error_icon;
        message.Text = msg;
        BackColor = Color.FromArgb(202, 94, 88);
        Show();
        if (_enableSoundEffect)
        {
            PlaySounds.Error();
        }
    }

    /// <summary>
    /// Show warning
    /// </summary>
    /// <param name="msg"></param>
    public void ShowWarning()
    {
        icon.Image = Properties.Resources.warning_icon;
        message.Text = "Warning!";
        BackColor = Color.FromArgb(247, 167, 53);
        Show();
        if (_enableSoundEffect)
        {
            PlaySounds.Warning();
        }
    }

    /// <summary>
    /// Show warning with custom message
    /// </summary>
    /// <param name="msg"></param>
    public void ShowWarning(string msg)
    {
        icon.Image = Properties.Resources.warning_icon;
        message.Text = msg;
        BackColor = Color.FromArgb(247, 167, 53);
        Show();
        if (_enableSoundEffect)
        {
            PlaySounds.Warning();
        }
    }

    /// <summary>
    /// load event - close after timeout seconds
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void Toastr_Load(object sender, EventArgs e)
    {
        icon.Image = Properties.Resources.success_icon;
        close.BackgroundImage = Properties.Resources.x_icon_light;
        await Task.Delay(_duration);
        Close();
    }
}
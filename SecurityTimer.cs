namespace HBSPC_1_WindowsApp;

public class SecurityTimer
{
    private readonly System.Windows.Forms.Timer timer = new();

    public void Initialize(int interval, EventHandler handler)
    {
        timer.Interval = interval;
        timer.Enabled = false;
        timer.Tick += handler;
    }

    public void Start() => timer.Start();

    public void Stop() => timer.Stop();

    public void Reset()
    {
        timer.Stop();
        timer.Start();
    }
}

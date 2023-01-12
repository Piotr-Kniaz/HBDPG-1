namespace HBSPC_1;

public static class ClipboardSecurity
{
    private static readonly System.Windows.Forms.Timer timer = new();

    public static void InitializeTimer()
    {
        timer.Interval = 60000;
        timer.Enabled = false;
        timer.Tick += new EventHandler(TimerEventProcessor);
    }

    public static void ResetTimer()
    {
        timer.Stop();
        timer.Start();
    }

    public static void Clear()
    {
        if (Clipboard.GetText().ToString().Length == 32)
            Clipboard.Clear();
        timer.Stop();
    }

    private static void TimerEventProcessor(object? sender, EventArgs e) => Clear();
}

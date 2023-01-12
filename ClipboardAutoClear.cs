namespace HBSPC_1;

public static class ClipboardAutoClear
{
    private static readonly System.Timers.Timer timer = new(10000); // 10 sec
    public static void InitializeTimer()
    {
        timer.AutoReset = false;
        timer.Elapsed += OnTimedEvent;
    }

    public static void ResetTimer()
    {
        timer.Stop();
        timer.Start();
    }

    private static void OnTimedEvent(object? sender, ElapsedEventArgs e) => Clipboard.Clear();
    // doesn't work
}

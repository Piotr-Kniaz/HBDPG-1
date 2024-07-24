namespace HBDPG_1_WindowsApp;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        Application.Idle += Form_Idle;
        idleTimer.Initialize(60000, new EventHandler(TextBoxesAutoClearProcessor));
        clipboardTimer.Initialize(60000, new EventHandler(ClipboardAutoClearProcessor));

        ActiveControl = input;

        input.KeyDown += new KeyEventHandler(KeyDown_EventProcessor);
        iterationsCount.KeyDown += new KeyEventHandler(KeyDown_EventProcessor);
        showPasskeyCheckbox.KeyDown += new KeyEventHandler(KeyDown_EventProcessor);
        showPasswordCheckbox.KeyDown += new KeyEventHandler(KeyDown_EventProcessor);

        FormClosed += new FormClosedEventHandler(Form_Closed);
    }

    private void Calculate()
    {
        StringBuilder temp = new(input.Text);
        int iterations = (int)iterationsCount.Value;

        do
            temp = HBDPG_1.CalculatePassword(temp);
        while (--iterations > 0);

        result.Text = temp.ToString();
        input.Focus();
    }

    #region Main GUI features

    private void CalculateButton_Click(object sender, EventArgs e) => Calculate();

    private void ClearButton_Click(object? sender, EventArgs e) => ClearTextBoxes();

    private void CopyButton_Click(object sender, EventArgs e)
    {
        if (result.Text.Length > 0)
        {
            Clipboard.SetText(result.Text);
            clipboardTimer.Reset();

            MessageBox.Show(
                "Password copied to clipboard.\n\nClipboard will be automatically cleared in 60 seconds or immediately after closing the app.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        input.Focus();
    }

    private void ShowPasskeyCheckbox_CheckedChanged(object sender, EventArgs e)
    {
        input.UseSystemPasswordChar = !showPasskeyCheckbox.Checked;
        input.Focus();
    }

    private void ShowPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
    {
        result.UseSystemPasswordChar = !showPasswordCheckbox.Checked;
        input.Focus();
    }

    private void Logo_Click(object sender, EventArgs e)
    {
        MessageBox.Show(
            "Project \"HBSPC-1\" has been renamed to \"HBDPG-1\"",
            "Note",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void LinkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        try
        {
            System.Diagnostics.Process.Start("explorer", "https://github.com/Piotr-Kniaz/HBDPG-1");
        }
        catch
        {
            MessageBox.Show(
                "Unable to open link.\n\nProject repo: https://github.com/Piotr-Kniaz/HBDPG-1",
                "OOPS!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        input.Focus();
    }

    #endregion

    #region Additional GUI features

    private void KeyDown_EventProcessor(object? sender, KeyEventArgs e)
    {
        // Only for CheckBoxes.
        if (sender is CheckBox c && e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            c.Checked = !c.Checked;
            return;
        }

        switch (e.KeyCode)
        {
            case Keys.Enter:
                e.SuppressKeyPress = true;
                Calculate();
                break;
            case Keys.Escape:
                e.SuppressKeyPress = true;
                ClearTextBoxes();
                break;
        }

        if (sender is TextBox)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    e.SuppressKeyPress = true;
                    iterationsCount.UpButton();
                    break;
                case Keys.Down:
                    e.SuppressKeyPress = true;
                    iterationsCount.DownButton();
                    break;
            }
        }
    }

    private void Input_DoubleClick(object sender, EventArgs e) => input.SelectAll();

    #endregion

    #region Security features

    private void ClearTextBoxes()
    {
        input.Text = string.Empty;
        result.Text = string.Empty;
        iterationsCount.Value = 1;
        input.Focus();
    }

    private void ClearClipboard()
    {
        if (Clipboard.GetText().ToString().Length == 32)
            Clipboard.Clear();
        clipboardTimer.Stop();
    }

    private void TextBoxesAutoClearProcessor(object? sender, EventArgs e) => ClearTextBoxes();

    private void ClipboardAutoClearProcessor(object? sender, EventArgs e) => ClearClipboard();

    private void Form_Idle(object? sender, EventArgs e) => idleTimer.Reset();

    private void Form_Closed(object? sender, EventArgs e) => ClearClipboard();

    private readonly SecurityTimer idleTimer = new();
    private readonly SecurityTimer clipboardTimer = new();

    #endregion
}
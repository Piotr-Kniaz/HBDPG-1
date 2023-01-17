namespace HBSPC_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ClipboardSecurity.InitializeTimer();
            ActiveControl = input;

            input.KeyDown += new KeyEventHandler(Input_KeyDown);
            iterationsCount.KeyDown += new KeyEventHandler(Input_KeyDown);

            FormClosed += new FormClosedEventHandler(Form_Closed);
        }

        private void CalculateButton_Click(object sender, EventArgs e) => Calculate();

        private void ClearButton_Click(object sender, EventArgs e) => Clear();

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (result.Text.Length > 0)
            {
                Clipboard.SetText(result.Text);
                result.Focus();
                result.SelectAll();
                ClipboardSecurity.ResetTimer();
            }
        }

        private void Input_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    Calculate();
                    break;
                case Keys.Escape:
                    e.SuppressKeyPress = true;
                    Clear();
                    break;
            }

            if (sender is TextBox)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        e.SuppressKeyPress = true;
                        iterationsCount.Focus();
                        if (iterationsCount.Value < iterationsCount.Maximum)
                            iterationsCount.Value++;
                        break;
                    case Keys.Down:
                        e.SuppressKeyPress = true;
                        iterationsCount.Focus();
                        if (iterationsCount.Value > iterationsCount.Minimum)
                            iterationsCount.Value--;
                        break;
                }
            }
        }

        private void ShowPasskeyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            input.UseSystemPasswordChar = !showPasskeyCheckbox.Checked;
            input.Focus();
        }

        private void Input_DoubleClick(object sender, EventArgs e) => input.SelectAll();

        private void Result_Click(object sender, EventArgs e) => result.SelectAll();

        private void LinkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try { System.Diagnostics.Process.Start("explorer", "https://github.com/Piotr-Kniaz/HBSPC-1"); }
            catch { MessageBox.Show("Unable to open link.\n\nProject repo: https://github.com/Piotr-Kniaz/HBSPC-1", "OOPS!"); }
        }

        private void Form_Closed(object? sender, EventArgs e) => ClipboardSecurity.Clear();

        private void Calculate()
        {
            StringBuilder result = new(input.Text);
            int i = (int)iterationsCount.Value;

            do
                result = GetPassword.HBSPC_1(result);
            while (--i > 0);

            this.result.Text = result.ToString();
            input.Focus();
        }

        private void Clear()
        {
            input.Text = string.Empty;
            result.Text = string.Empty;
            iterationsCount.Value = 1;
            input.Focus();
        }
    }
}
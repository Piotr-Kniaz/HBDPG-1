namespace HBSPC_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ActiveControl = input;
            input.KeyDown += new KeyEventHandler(Input_KeyDown);
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
            }
        }

        private void Input_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; Calculate(); }
            if (e.KeyCode == Keys.Escape) { e.SuppressKeyPress = true; Clear(); }
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

        private void Form_Closed(object? sender, EventArgs e) => Clipboard.Clear();

        private void Calculate()
        {
            StringBuilder passkey = new();
            passkey.Append(input.Text);
            result.Text = GetPassword.HBSPC_1(passkey).ToString();
            input.Focus();
        }

        private void Clear()
        {
            input.Text = string.Empty;
            result.Text = string.Empty;
            input.Focus();
        }
    }
}
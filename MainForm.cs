namespace HBSPC_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.input.KeyDown += new KeyEventHandler(Input_KeyDown);
            this.ActiveControl = input;
        }

        private void ShowPasskeyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            input.UseSystemPasswordChar = !showPasskeyCheckbox.Checked;
            input.Focus();
        }

        private void Input_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; Calculate(); }
            if (e.KeyCode == Keys.Escape) { e.SuppressKeyPress = true; Clear(); }
        }

        private void Input_DoubleClick(object sender, EventArgs e) => input.SelectAll();

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

        private void Result_Click(object sender, EventArgs e) => result.SelectAll();

        private void Calculate()
        {
            StringBuilder passkey = new();
            passkey.Append(input.Text);
            result.Text = GetPassword.Method1(passkey).ToString();
            input.Focus();
        }

        private void Clear()
        {
            input.Text = string.Empty;
            result.Text = string.Empty;
            input.Focus();
        }

        private void LinkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try { System.Diagnostics.Process.Start("explorer", "https://github.com/piotr-kniaz-official/HBSPC-1"); }
            catch { MessageBox.Show("Unable to open link.\n\nProject repo: https://github.com/piotr-kniaz-official/HBSPC-1", "OOPS!"); }
        }
    }
}
namespace HBDPG_1_WindowsApp;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        showPasskeyCheckbox = new CheckBox();
        calculateButton = new Button();
        copyButton = new Button();
        input = new TextBox();
        label1 = new Label();
        label2 = new Label();
        result = new TextBox();
        copyright = new Label();
        version = new Label();
        clearButton = new Button();
        linkGitHub = new LinkLabel();
        iterationsCount = new NumericUpDown();
        label3 = new Label();
        showPasswordCheckbox = new CheckBox();
        logo = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)iterationsCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
        SuspendLayout();
        // 
        // showPasskeyCheckbox
        // 
        showPasskeyCheckbox.AutoSize = true;
        showPasskeyCheckbox.Location = new Point(75, 169);
        showPasskeyCheckbox.Name = "showPasskeyCheckbox";
        showPasskeyCheckbox.Size = new Size(99, 19);
        showPasskeyCheckbox.TabIndex = 2;
        showPasskeyCheckbox.Text = "Show passkey";
        showPasskeyCheckbox.UseVisualStyleBackColor = true;
        showPasskeyCheckbox.CheckedChanged += ShowPasskeyCheckbox_CheckedChanged;
        // 
        // showPasswordCheckbox
        // 
        showPasswordCheckbox.AutoSize = true;
        showPasswordCheckbox.Location = new Point(75, 256);
        showPasswordCheckbox.Name = "showPasswordCheckbox";
        showPasswordCheckbox.Size = new Size(108, 19);
        showPasswordCheckbox.TabIndex = 5;
        showPasswordCheckbox.Text = "Show password";
        showPasswordCheckbox.UseVisualStyleBackColor = true;
        showPasswordCheckbox.CheckedChanged += ShowPasswordCheckbox_CheckedChanged;
        // 
        // calculateButton
        // 
        calculateButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
        calculateButton.Location = new Point(219, 288);
        calculateButton.Name = "calculateButton";
        calculateButton.Size = new Size(146, 53);
        calculateButton.TabIndex = 6;
        calculateButton.Text = "Calculate";
        calculateButton.UseVisualStyleBackColor = true;
        calculateButton.Click += CalculateButton_Click;
        // 
        // copyButton
        // 
        copyButton.Location = new Point(379, 225);
        copyButton.Name = "copyButton";
        copyButton.Size = new Size(130, 25);
        copyButton.TabIndex = 4;
        copyButton.Text = "Copy to clipboard";
        copyButton.UseVisualStyleBackColor = true;
        copyButton.Click += CopyButton_Click;
        // 
        // input
        // 
        input.Font = new Font("Consolas", 11F);
        input.Location = new Point(75, 138);
        input.Name = "input";
        input.Size = new Size(360, 25);
        input.TabIndex = 0;
        input.UseSystemPasswordChar = true;
        input.DoubleClick += Input_DoubleClick;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(75, 120);
        label1.Name = "label1";
        label1.Size = new Size(51, 15);
        label1.TabIndex = 13;
        label1.Text = "Passkey:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(75, 207);
        label2.Name = "label2";
        label2.Size = new Size(87, 15);
        label2.TabIndex = 12;
        label2.Text = "Your password:";
        // 
        // result
        // 
        result.Enabled = false;
        result.Font = new Font("Consolas", 11F);
        result.Location = new Point(75, 225);
        result.MaxLength = 32;
        result.Name = "result";
        result.ReadOnly = true;
        result.Size = new Size(290, 25);
        result.TabIndex = 11;
        result.TabStop = false;
        result.TextAlign = HorizontalAlignment.Center;
        result.UseSystemPasswordChar = true;
        // 
        // copyright
        // 
        copyright.AutoSize = true;
        copyright.Location = new Point(439, 407);
        copyright.Name = "copyright";
        copyright.Size = new Size(133, 15);
        copyright.TabIndex = 10;
        copyright.Text = "© 2023-2024 Piotr Kniaz";
        copyright.TextAlign = ContentAlignment.TopRight;
        // 
        // version
        // 
        version.AutoSize = true;
        version.Location = new Point(12, 407);
        version.Name = "version";
        version.Size = new Size(87, 15);
        version.TabIndex = 9;
        version.Text = "version 1.3.0-rc";
        // 
        // clearButton
        // 
        clearButton.Location = new Point(219, 358);
        clearButton.Name = "clearButton";
        clearButton.Size = new Size(146, 30);
        clearButton.TabIndex = 7;
        clearButton.Text = "Clear";
        clearButton.UseCompatibleTextRendering = true;
        clearButton.UseVisualStyleBackColor = true;
        clearButton.Click += ClearButton_Click;
        // 
        // linkGitHub
        // 
        linkGitHub.AutoSize = true;
        linkGitHub.Location = new Point(12, 392);
        linkGitHub.Name = "linkGitHub";
        linkGitHub.Size = new Size(45, 15);
        linkGitHub.TabIndex = 8;
        linkGitHub.TabStop = true;
        linkGitHub.Text = "GitHub";
        linkGitHub.LinkClicked += LinkGitHub_LinkClicked;
        // 
        // iterationsCount
        // 
        iterationsCount.Font = new Font("Segoe UI", 10F);
        iterationsCount.Location = new Point(449, 138);
        iterationsCount.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
        iterationsCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        iterationsCount.Name = "iterationsCount";
        iterationsCount.Size = new Size(60, 25);
        iterationsCount.TabIndex = 1;
        iterationsCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(449, 120);
        label3.Name = "label3";
        label3.Size = new Size(59, 15);
        label3.TabIndex = 6;
        label3.Text = "Iterations:";
        // 
        // logo
        // 
        logo.Cursor = Cursors.Hand;
        logo.Image = (Image)resources.GetObject("logo.Image");
        logo.Location = new Point(242, 10);
        logo.Name = "logo";
        logo.Size = new Size(100, 100);
        logo.SizeMode = PictureBoxSizeMode.Zoom;
        logo.TabIndex = 0;
        logo.TabStop = false;
        logo.Click += Logo_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(584, 431);
        Controls.Add(logo);
        Controls.Add(showPasswordCheckbox);
        Controls.Add(label3);
        Controls.Add(iterationsCount);
        Controls.Add(linkGitHub);
        Controls.Add(clearButton);
        Controls.Add(version);
        Controls.Add(copyright);
        Controls.Add(result);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(input);
        Controls.Add(copyButton);
        Controls.Add(calculateButton);
        Controls.Add(showPasskeyCheckbox);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "HBDPG-1 (HBSPC-1)";
        ((System.ComponentModel.ISupportInitialize)iterationsCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)logo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private CheckBox showPasskeyCheckbox;
    private Button calculateButton;
    private Button copyButton;
    private TextBox input;
    private Label label1;
    private Label label2;
    private TextBox result;
    private Label copyright;
    private Label version;
    private Button clearButton;
    private LinkLabel linkGitHub;
    private NumericUpDown iterationsCount;
    private Label label3;
    private CheckBox showPasswordCheckbox;
    private PictureBox logo;
}
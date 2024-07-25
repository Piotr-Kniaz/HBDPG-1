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
        generateButton = new Button();
        copyButton = new Button();
        input = new TextBox();
        label1Input = new Label();
        label3Result = new Label();
        result = new TextBox();
        copyright = new Label();
        version = new Label();
        clearButton = new Button();
        linkGitHub = new LinkLabel();
        iterationsCount = new NumericUpDown();
        label2Iterations = new Label();
        showPasswordCheckbox = new CheckBox();
        logo = new PictureBox();
        label4Entropy = new Label();
        entropyCount = new Label();
        ((System.ComponentModel.ISupportInitialize)iterationsCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
        SuspendLayout();
        // 
        // showPasskeyCheckbox
        // 
        showPasskeyCheckbox.AutoSize = true;
        showPasskeyCheckbox.Location = new Point(75, 172);
        showPasskeyCheckbox.Name = "showPasskeyCheckbox";
        showPasskeyCheckbox.Size = new Size(99, 19);
        showPasskeyCheckbox.TabIndex = 5;
        showPasskeyCheckbox.Text = "Show passkey";
        showPasskeyCheckbox.UseVisualStyleBackColor = true;
        showPasskeyCheckbox.CheckedChanged += ShowPasskeyCheckbox_CheckedChanged;
        // 
        // generateButton
        // 
        generateButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
        generateButton.Location = new Point(219, 291);
        generateButton.Name = "generateButton";
        generateButton.Size = new Size(146, 53);
        generateButton.TabIndex = 12;
        generateButton.Text = "Generate";
        generateButton.UseVisualStyleBackColor = true;
        generateButton.Click += GenerateButton_Click;
        // 
        // copyButton
        // 
        copyButton.Enabled = false;
        copyButton.Location = new Point(379, 228);
        copyButton.Name = "copyButton";
        copyButton.Size = new Size(130, 25);
        copyButton.TabIndex = 10;
        copyButton.Text = "Copy to clipboard";
        copyButton.UseVisualStyleBackColor = true;
        copyButton.Click += CopyButton_Click;
        // 
        // input
        // 
        input.Font = new Font("Consolas", 11F);
        input.Location = new Point(75, 141);
        input.Name = "input";
        input.Size = new Size(360, 25);
        input.TabIndex = 3;
        input.UseSystemPasswordChar = true;
        input.DoubleClick += Input_DoubleClick;
        // 
        // label1Input
        // 
        label1Input.AutoSize = true;
        label1Input.Location = new Point(75, 123);
        label1Input.Name = "label1Input";
        label1Input.Size = new Size(51, 15);
        label1Input.TabIndex = 1;
        label1Input.Text = "Passkey:";
        // 
        // label3Result
        // 
        label3Result.AutoSize = true;
        label3Result.Location = new Point(75, 210);
        label3Result.Name = "label3Result";
        label3Result.Size = new Size(87, 15);
        label3Result.TabIndex = 6;
        label3Result.Text = "Your password:";
        // 
        // result
        // 
        result.Enabled = false;
        result.Font = new Font("Consolas", 11F);
        result.Location = new Point(75, 228);
        result.MaxLength = 32;
        result.Name = "result";
        result.ReadOnly = true;
        result.Size = new Size(290, 25);
        result.TabIndex = 7;
        result.TextAlign = HorizontalAlignment.Center;
        result.UseSystemPasswordChar = true;
        // 
        // copyright
        // 
        copyright.AutoSize = true;
        copyright.Location = new Point(468, 392);
        copyright.Name = "copyright";
        copyright.Size = new Size(104, 30);
        copyright.TabIndex = 16;
        copyright.Text = "MIT License\r\n© 2024 Piotr Kniaz";
        copyright.TextAlign = ContentAlignment.TopRight;
        // 
        // version
        // 
        version.AutoSize = true;
        version.Location = new Point(12, 407);
        version.Name = "version";
        version.Size = new Size(72, 15);
        version.TabIndex = 15;
        version.Text = "version 1.3.0";
        // 
        // clearButton
        // 
        clearButton.Location = new Point(219, 361);
        clearButton.Name = "clearButton";
        clearButton.Size = new Size(146, 30);
        clearButton.TabIndex = 13;
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
        linkGitHub.TabIndex = 14;
        linkGitHub.TabStop = true;
        linkGitHub.Text = "GitHub";
        linkGitHub.LinkClicked += LinkGitHub_LinkClicked;
        // 
        // iterationsCount
        // 
        iterationsCount.Font = new Font("Segoe UI", 10F);
        iterationsCount.Location = new Point(449, 141);
        iterationsCount.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
        iterationsCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        iterationsCount.Name = "iterationsCount";
        iterationsCount.Size = new Size(60, 25);
        iterationsCount.TabIndex = 4;
        iterationsCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label2Iterations
        // 
        label2Iterations.AutoSize = true;
        label2Iterations.Location = new Point(449, 123);
        label2Iterations.Name = "label2Iterations";
        label2Iterations.Size = new Size(59, 15);
        label2Iterations.TabIndex = 2;
        label2Iterations.Text = "Iterations:";
        // 
        // showPasswordCheckbox
        // 
        showPasswordCheckbox.AutoSize = true;
        showPasswordCheckbox.Location = new Point(75, 259);
        showPasswordCheckbox.Name = "showPasswordCheckbox";
        showPasswordCheckbox.Size = new Size(108, 19);
        showPasswordCheckbox.TabIndex = 11;
        showPasswordCheckbox.Text = "Show password";
        showPasswordCheckbox.UseVisualStyleBackColor = true;
        showPasswordCheckbox.CheckedChanged += ShowPasswordCheckbox_CheckedChanged;
        // 
        // logo
        // 
        logo.ErrorImage = null;
        logo.Image = (Image)resources.GetObject("logo.Image");
        logo.InitialImage = null;
        logo.Location = new Point(142, 10);
        logo.Name = "logo";
        logo.Size = new Size(300, 110);
        logo.SizeMode = PictureBoxSizeMode.Zoom;
        logo.TabIndex = 0;
        logo.TabStop = false;
        // 
        // label4Entropy
        // 
        label4Entropy.AutoSize = true;
        label4Entropy.Location = new Point(255, 210);
        label4Entropy.Name = "label4Entropy";
        label4Entropy.Size = new Size(51, 15);
        label4Entropy.TabIndex = 8;
        label4Entropy.Text = "Entropy:";
        label4Entropy.Visible = false;
        // 
        // entropyCount
        // 
        entropyCount.AutoSize = true;
        entropyCount.Location = new Point(304, 210);
        entropyCount.Name = "entropyCount";
        entropyCount.Size = new Size(0, 15);
        entropyCount.TabIndex = 9;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(584, 431);
        Controls.Add(entropyCount);
        Controls.Add(label4Entropy);
        Controls.Add(showPasswordCheckbox);
        Controls.Add(label2Iterations);
        Controls.Add(iterationsCount);
        Controls.Add(linkGitHub);
        Controls.Add(clearButton);
        Controls.Add(version);
        Controls.Add(copyright);
        Controls.Add(result);
        Controls.Add(label3Result);
        Controls.Add(label1Input);
        Controls.Add(input);
        Controls.Add(copyButton);
        Controls.Add(generateButton);
        Controls.Add(showPasskeyCheckbox);
        Controls.Add(logo);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "HBDPG-1 for Windows";
        ((System.ComponentModel.ISupportInitialize)iterationsCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)logo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private CheckBox showPasskeyCheckbox;
    private Button generateButton;
    private Button copyButton;
    private TextBox input;
    private Label label1Input;
    private Label label3Result;
    private TextBox result;
    private Label copyright;
    private Label version;
    private Button clearButton;
    private LinkLabel linkGitHub;
    private NumericUpDown iterationsCount;
    private Label label2Iterations;
    private CheckBox showPasswordCheckbox;
    private PictureBox logo;
    private Label label4Entropy;
    private Label entropyCount;
}
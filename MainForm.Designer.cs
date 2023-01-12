namespace HBSPC_1
{
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
            this.showPasskeyCheckbox = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.title1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.copyright = new System.Windows.Forms.Label();
            this.title2 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // showPasskeyCheckbox
            // 
            this.showPasskeyCheckbox.AutoSize = true;
            this.showPasskeyCheckbox.Location = new System.Drawing.Point(75, 161);
            this.showPasskeyCheckbox.Name = "showPasskeyCheckbox";
            this.showPasskeyCheckbox.Size = new System.Drawing.Size(99, 19);
            this.showPasskeyCheckbox.TabIndex = 0;
            this.showPasskeyCheckbox.Text = "Show passkey";
            this.showPasskeyCheckbox.UseVisualStyleBackColor = true;
            this.showPasskeyCheckbox.CheckedChanged += new System.EventHandler(this.ShowPasskeyCheckbox_CheckedChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.Location = new System.Drawing.Point(219, 288);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(146, 53);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(383, 217);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(126, 25);
            this.copyButton.TabIndex = 2;
            this.copyButton.Text = "Copy to clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input.Location = new System.Drawing.Point(75, 130);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(434, 25);
            this.input.TabIndex = 3;
            this.input.UseSystemPasswordChar = true;
            this.input.DoubleClick += new System.EventHandler(this.Input_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Passkey:";
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title1.Location = new System.Drawing.Point(226, 9);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(146, 45);
            this.title1.TabIndex = 6;
            this.title1.Text = "HBSPC-1";
            this.title1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your password:";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(75, 217);
            this.result.MaxLength = 32;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(292, 25);
            this.result.TabIndex = 8;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.result.Click += new System.EventHandler(this.Result_Click);
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Location = new System.Drawing.Point(468, 407);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(104, 15);
            this.copyright.TabIndex = 9;
            this.copyright.Text = "© 2023 Piotr Kniaz";
            this.copyright.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title2.Location = new System.Drawing.Point(121, 54);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(342, 20);
            this.title2.TabIndex = 10;
            this.title2.Text = "(Hash-based Secure Password Calculation 1st Gen)";
            this.title2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(12, 407);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(72, 15);
            this.version.TabIndex = 11;
            this.version.Text = "version 1.0.2";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(219, 358);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(146, 30);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseCompatibleTextRendering = true;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // linkGitHub
            // 
            this.linkGitHub.AutoSize = true;
            this.linkGitHub.Location = new System.Drawing.Point(12, 392);
            this.linkGitHub.Name = "linkGitHub";
            this.linkGitHub.Size = new System.Drawing.Size(45, 15);
            this.linkGitHub.TabIndex = 13;
            this.linkGitHub.TabStop = true;
            this.linkGitHub.Text = "GitHub";
            this.linkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkGitHub_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(584, 431);
            this.Controls.Add(this.linkGitHub);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.version);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.showPasskeyCheckbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pers HBSPC-1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox showPasskeyCheckbox;
        private Button calculateButton;
        private Button copyButton;
        private TextBox input;
        private Label label1;
        private Label title1;
        private Label label2;
        private TextBox result;
        private Label copyright;
        private Label title2;
        private Label version;
        private Button clearButton;
        private LinkLabel linkGitHub;
    }
}
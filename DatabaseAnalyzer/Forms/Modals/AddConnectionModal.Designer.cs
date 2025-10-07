namespace DatabaseAnalyzer.Forms
{
    partial class AddConnectionModal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new Panel();
            tableLayoutPanel = new TableLayoutPanel();
            passwordLabel = new Label();
            usernameLabel = new Label();
            label1 = new Label();
            hostnameLabel = new Label();
            portLabel = new Label();
            serviceNameRadioButton = new RadioButton();
            sidRadioButton = new RadioButton();
            conNamePanel = new Panel();
            conNameTextBox = new TextBox();
            hostnamePanel = new Panel();
            hostnameTextBox = new TextBox();
            portPanel = new Panel();
            portTextBox = new TextBox();
            usernamePanel = new Panel();
            usernameTextBox = new TextBox();
            passwordPanel = new Panel();
            passwordTextBox = new TextBox();
            sidPanel = new Panel();
            sidTextBox = new TextBox();
            serviceNamePanel = new Panel();
            serviceNameTextBox = new TextBox();
            customActionBar = new DatabaseAnalyzer.Components.CustomActionBar();
            mainPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            conNamePanel.SuspendLayout();
            hostnamePanel.SuspendLayout();
            portPanel.SuspendLayout();
            usernamePanel.SuspendLayout();
            passwordPanel.SuspendLayout();
            sidPanel.SuspendLayout();
            serviceNamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Controls.Add(tableLayoutPanel);
            mainPanel.Controls.Add(customActionBar);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(356, 410);
            mainPanel.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.46154F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.53846F));
            tableLayoutPanel.Controls.Add(passwordLabel, 1, 6);
            tableLayoutPanel.Controls.Add(usernameLabel, 0, 6);
            tableLayoutPanel.Controls.Add(label1, 0, 0);
            tableLayoutPanel.Controls.Add(hostnameLabel, 0, 3);
            tableLayoutPanel.Controls.Add(portLabel, 1, 3);
            tableLayoutPanel.Controls.Add(serviceNameRadioButton, 0, 10);
            tableLayoutPanel.Controls.Add(sidRadioButton, 0, 9);
            tableLayoutPanel.Controls.Add(conNamePanel, 0, 1);
            tableLayoutPanel.Controls.Add(hostnamePanel, 0, 4);
            tableLayoutPanel.Controls.Add(portPanel, 1, 4);
            tableLayoutPanel.Controls.Add(usernamePanel, 0, 7);
            tableLayoutPanel.Controls.Add(passwordPanel, 1, 7);
            tableLayoutPanel.Controls.Add(sidPanel, 1, 9);
            tableLayoutPanel.Controls.Add(serviceNamePanel, 1, 10);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(20);
            tableLayoutPanel.RowCount = 12;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 225F));
            tableLayoutPanel.Size = new Size(354, 369);
            tableLayoutPanel.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Dock = DockStyle.Fill;
            passwordLabel.Font = new Font("Segoe UI", 12F);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(188, 186);
            passwordLabel.Margin = new Padding(10, 0, 3, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(143, 25);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Dock = DockStyle.Fill;
            usernameLabel.Font = new Font("Segoe UI", 12F);
            usernameLabel.ForeColor = Color.White;
            usernameLabel.Location = new Point(23, 186);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(152, 25);
            usernameLabel.TabIndex = 8;
            usernameLabel.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 20);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(314, 25);
            label1.TabIndex = 0;
            label1.Text = "Connection name";
            // 
            // hostnameLabel
            // 
            hostnameLabel.AutoSize = true;
            hostnameLabel.Dock = DockStyle.Fill;
            hostnameLabel.Font = new Font("Segoe UI", 12F);
            hostnameLabel.ForeColor = Color.White;
            hostnameLabel.Location = new Point(23, 103);
            hostnameLabel.Name = "hostnameLabel";
            hostnameLabel.Size = new Size(152, 25);
            hostnameLabel.TabIndex = 2;
            hostnameLabel.Text = "Hostname";
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Dock = DockStyle.Fill;
            portLabel.Font = new Font("Segoe UI", 12F);
            portLabel.ForeColor = Color.White;
            portLabel.Location = new Point(188, 103);
            portLabel.Margin = new Padding(10, 0, 3, 0);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(143, 25);
            portLabel.TabIndex = 5;
            portLabel.Text = "Port";
            // 
            // serviceNameRadioButton
            // 
            serviceNameRadioButton.AutoSize = true;
            serviceNameRadioButton.Dock = DockStyle.Fill;
            serviceNameRadioButton.Font = new Font("Segoe UI", 12F);
            serviceNameRadioButton.ForeColor = Color.White;
            serviceNameRadioButton.Location = new Point(23, 310);
            serviceNameRadioButton.Name = "serviceNameRadioButton";
            serviceNameRadioButton.Size = new Size(152, 32);
            serviceNameRadioButton.TabIndex = 12;
            serviceNameRadioButton.Text = "Service name";
            serviceNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // sidRadioButton
            // 
            sidRadioButton.AutoSize = true;
            sidRadioButton.Checked = true;
            sidRadioButton.Dock = DockStyle.Fill;
            sidRadioButton.Font = new Font("Segoe UI", 12F);
            sidRadioButton.ForeColor = Color.White;
            sidRadioButton.Location = new Point(23, 272);
            sidRadioButton.Name = "sidRadioButton";
            sidRadioButton.Size = new Size(152, 32);
            sidRadioButton.TabIndex = 13;
            sidRadioButton.TabStop = true;
            sidRadioButton.Text = "SID";
            sidRadioButton.UseVisualStyleBackColor = true;
            // 
            // conNamePanel
            // 
            conNamePanel.BackColor = Color.DarkSlateGray;
            tableLayoutPanel.SetColumnSpan(conNamePanel, 2);
            conNamePanel.Controls.Add(conNameTextBox);
            conNamePanel.Dock = DockStyle.Fill;
            conNamePanel.Location = new Point(20, 50);
            conNamePanel.Margin = new Padding(0, 5, 0, 5);
            conNamePanel.Name = "conNamePanel";
            conNamePanel.Padding = new Padding(3);
            conNamePanel.Size = new Size(314, 28);
            conNamePanel.TabIndex = 16;
            // 
            // conNameTextBox
            // 
            conNameTextBox.BackColor = Color.FromArgb(35, 36, 42);
            conNameTextBox.BorderStyle = BorderStyle.None;
            conNameTextBox.Dock = DockStyle.Fill;
            conNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            conNameTextBox.ForeColor = Color.White;
            conNameTextBox.Location = new Point(3, 3);
            conNameTextBox.Margin = new Padding(0);
            conNameTextBox.Name = "conNameTextBox";
            conNameTextBox.Size = new Size(308, 22);
            conNameTextBox.TabIndex = 3;
            // 
            // hostnamePanel
            // 
            hostnamePanel.BackColor = Color.DarkSlateGray;
            hostnamePanel.Controls.Add(hostnameTextBox);
            hostnamePanel.Dock = DockStyle.Fill;
            hostnamePanel.Location = new Point(20, 133);
            hostnamePanel.Margin = new Padding(0, 5, 0, 5);
            hostnamePanel.Name = "hostnamePanel";
            hostnamePanel.Padding = new Padding(3);
            hostnamePanel.Size = new Size(158, 28);
            hostnamePanel.TabIndex = 17;
            // 
            // hostnameTextBox
            // 
            hostnameTextBox.BackColor = Color.FromArgb(35, 36, 42);
            hostnameTextBox.BorderStyle = BorderStyle.None;
            hostnameTextBox.Dock = DockStyle.Fill;
            hostnameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hostnameTextBox.ForeColor = Color.White;
            hostnameTextBox.Location = new Point(3, 3);
            hostnameTextBox.Name = "hostnameTextBox";
            hostnameTextBox.Size = new Size(152, 22);
            hostnameTextBox.TabIndex = 7;
            // 
            // portPanel
            // 
            portPanel.BackColor = Color.DarkSlateGray;
            portPanel.Controls.Add(portTextBox);
            portPanel.Dock = DockStyle.Fill;
            portPanel.Location = new Point(188, 133);
            portPanel.Margin = new Padding(10, 5, 0, 5);
            portPanel.Name = "portPanel";
            portPanel.Padding = new Padding(3);
            portPanel.Size = new Size(146, 28);
            portPanel.TabIndex = 18;
            // 
            // portTextBox
            // 
            portTextBox.BackColor = Color.FromArgb(35, 36, 42);
            portTextBox.BorderStyle = BorderStyle.None;
            portTextBox.Dock = DockStyle.Fill;
            portTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            portTextBox.ForeColor = Color.White;
            portTextBox.Location = new Point(3, 3);
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(140, 22);
            portTextBox.TabIndex = 8;
            // 
            // usernamePanel
            // 
            usernamePanel.BackColor = Color.DarkSlateGray;
            usernamePanel.Controls.Add(usernameTextBox);
            usernamePanel.Dock = DockStyle.Fill;
            usernamePanel.Location = new Point(20, 216);
            usernamePanel.Margin = new Padding(0, 5, 0, 5);
            usernamePanel.Name = "usernamePanel";
            usernamePanel.Padding = new Padding(3);
            usernamePanel.Size = new Size(158, 28);
            usernamePanel.TabIndex = 19;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.FromArgb(35, 36, 42);
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Dock = DockStyle.Fill;
            usernameTextBox.Font = new Font("Segoe UI", 12F);
            usernameTextBox.ForeColor = Color.White;
            usernameTextBox.Location = new Point(3, 3);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(152, 22);
            usernameTextBox.TabIndex = 11;
            // 
            // passwordPanel
            // 
            passwordPanel.BackColor = Color.DarkSlateGray;
            passwordPanel.Controls.Add(passwordTextBox);
            passwordPanel.Dock = DockStyle.Fill;
            passwordPanel.Location = new Point(188, 216);
            passwordPanel.Margin = new Padding(10, 5, 0, 5);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Padding = new Padding(3);
            passwordPanel.Size = new Size(146, 28);
            passwordPanel.TabIndex = 20;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(35, 36, 42);
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Dock = DockStyle.Fill;
            passwordTextBox.Font = new Font("Segoe UI", 12F);
            passwordTextBox.ForeColor = Color.White;
            passwordTextBox.Location = new Point(3, 3);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(140, 22);
            passwordTextBox.TabIndex = 12;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // sidPanel
            // 
            sidPanel.BackColor = Color.DarkSlateGray;
            sidPanel.Controls.Add(sidTextBox);
            sidPanel.Dock = DockStyle.Fill;
            sidPanel.Location = new Point(188, 274);
            sidPanel.Margin = new Padding(10, 5, 0, 5);
            sidPanel.Name = "sidPanel";
            sidPanel.Padding = new Padding(3);
            sidPanel.Size = new Size(146, 28);
            sidPanel.TabIndex = 21;
            // 
            // sidTextBox
            // 
            sidTextBox.BackColor = Color.FromArgb(35, 36, 42);
            sidTextBox.BorderStyle = BorderStyle.None;
            sidTextBox.Dock = DockStyle.Fill;
            sidTextBox.Font = new Font("Segoe UI", 12F);
            sidTextBox.ForeColor = Color.White;
            sidTextBox.Location = new Point(3, 3);
            sidTextBox.Name = "sidTextBox";
            sidTextBox.Size = new Size(140, 22);
            sidTextBox.TabIndex = 15;
            // 
            // serviceNamePanel
            // 
            serviceNamePanel.BackColor = Color.FromArgb(45, 46, 55);
            serviceNamePanel.Controls.Add(serviceNameTextBox);
            serviceNamePanel.Dock = DockStyle.Fill;
            serviceNamePanel.Location = new Point(188, 312);
            serviceNamePanel.Margin = new Padding(10, 5, 0, 5);
            serviceNamePanel.Name = "serviceNamePanel";
            serviceNamePanel.Padding = new Padding(3);
            serviceNamePanel.Size = new Size(146, 28);
            serviceNamePanel.TabIndex = 22;
            // 
            // serviceNameTextBox
            // 
            serviceNameTextBox.BackColor = Color.FromArgb(35, 36, 42);
            serviceNameTextBox.BorderStyle = BorderStyle.None;
            serviceNameTextBox.Dock = DockStyle.Fill;
            serviceNameTextBox.Enabled = false;
            serviceNameTextBox.Font = new Font("Segoe UI", 12F);
            serviceNameTextBox.ForeColor = Color.White;
            serviceNameTextBox.Location = new Point(3, 3);
            serviceNameTextBox.Name = "serviceNameTextBox";
            serviceNameTextBox.Size = new Size(140, 22);
            serviceNameTextBox.TabIndex = 16;
            // 
            // customActionBar
            // 
            customActionBar.BackColor = Color.FromArgb(35, 36, 42);
            customActionBar.Dock = DockStyle.Bottom;
            customActionBar.ForeColor = Color.White;
            customActionBar.Location = new Point(0, 369);
            customActionBar.MaximumSize = new Size(0, 39);
            customActionBar.MinimumSize = new Size(203, 39);
            customActionBar.Name = "customActionBar";
            customActionBar.Size = new Size(354, 39);
            customActionBar.TabIndex = 2;
            // 
            // AddConnectionModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 42);
            ClientSize = new Size(356, 410);
            ControlBox = false;
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(356, 410);
            MinimumSize = new Size(356, 410);
            Name = "AddConnectionModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddConnectionModal";
            mainPanel.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            conNamePanel.ResumeLayout(false);
            conNamePanel.PerformLayout();
            hostnamePanel.ResumeLayout(false);
            hostnamePanel.PerformLayout();
            portPanel.ResumeLayout(false);
            portPanel.PerformLayout();
            usernamePanel.ResumeLayout(false);
            usernamePanel.PerformLayout();
            passwordPanel.ResumeLayout(false);
            passwordPanel.PerformLayout();
            sidPanel.ResumeLayout(false);
            sidPanel.PerformLayout();
            serviceNamePanel.ResumeLayout(false);
            serviceNamePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private TableLayoutPanel tableLayoutPanel;
        private Label passwordLabel;
        private Label usernameLabel;
        private Label label1;
        private Label hostnameLabel;
        private Label portLabel;
        private Components.CustomActionBar customActionBar;
        private RadioButton serviceNameRadioButton;
        private RadioButton sidRadioButton;
        private Panel conNamePanel;
        private Panel hostnamePanel;
        private TextBox hostnameTextBox;
        private Panel portPanel;
        private TextBox portTextBox;
        private Panel usernamePanel;
        private TextBox usernameTextBox;
        private Panel passwordPanel;
        private TextBox passwordTextBox;
        private Panel sidPanel;
        private TextBox sidTextBox;
        private Panel serviceNamePanel;
        private TextBox serviceNameTextBox;
        private TextBox conNameTextBox;
    }
}
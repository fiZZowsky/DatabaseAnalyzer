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
            conNameTextBox = new TextBox();
            hostnameLabel = new Label();
            portLabel = new Label();
            hostnameTextBox = new TextBox();
            portTextBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            serviceNameRadioButton = new RadioButton();
            sidRadioButton = new RadioButton();
            sidTextBox = new TextBox();
            serviceNameTextBox = new TextBox();
            customActionBar = new DatabaseAnalyzer.Components.CustomActionBar();
            mainPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
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
            mainPanel.Size = new Size(356, 409);
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
            tableLayoutPanel.Controls.Add(conNameTextBox, 0, 1);
            tableLayoutPanel.Controls.Add(hostnameLabel, 0, 3);
            tableLayoutPanel.Controls.Add(portLabel, 1, 3);
            tableLayoutPanel.Controls.Add(hostnameTextBox, 0, 4);
            tableLayoutPanel.Controls.Add(portTextBox, 1, 4);
            tableLayoutPanel.Controls.Add(usernameTextBox, 0, 7);
            tableLayoutPanel.Controls.Add(passwordTextBox, 1, 7);
            tableLayoutPanel.Controls.Add(serviceNameRadioButton, 0, 10);
            tableLayoutPanel.Controls.Add(sidRadioButton, 0, 9);
            tableLayoutPanel.Controls.Add(sidTextBox, 1, 9);
            tableLayoutPanel.Controls.Add(serviceNameTextBox, 1, 10);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(20);
            tableLayoutPanel.RowCount = 12;
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(354, 368);
            tableLayoutPanel.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Dock = DockStyle.Fill;
            passwordLabel.Font = new Font("Segoe UI", 12F);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(181, 192);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(150, 21);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Dock = DockStyle.Fill;
            usernameLabel.Font = new Font("Segoe UI", 12F);
            usernameLabel.ForeColor = Color.White;
            usernameLabel.Location = new Point(23, 192);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(152, 21);
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
            label1.Size = new Size(314, 21);
            label1.TabIndex = 0;
            label1.Text = "Connection name";
            // 
            // conNameTextBox
            // 
            conNameTextBox.BackColor = Color.FromArgb(35, 36, 42);
            conNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel.SetColumnSpan(conNameTextBox, 2);
            conNameTextBox.Dock = DockStyle.Fill;
            conNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            conNameTextBox.ForeColor = Color.White;
            conNameTextBox.Location = new Point(23, 44);
            conNameTextBox.Name = "conNameTextBox";
            conNameTextBox.Size = new Size(308, 29);
            conNameTextBox.TabIndex = 1;
            // 
            // hostnameLabel
            // 
            hostnameLabel.AutoSize = true;
            hostnameLabel.Dock = DockStyle.Fill;
            hostnameLabel.Font = new Font("Segoe UI", 12F);
            hostnameLabel.ForeColor = Color.White;
            hostnameLabel.Location = new Point(23, 106);
            hostnameLabel.Name = "hostnameLabel";
            hostnameLabel.Size = new Size(152, 21);
            hostnameLabel.TabIndex = 2;
            hostnameLabel.Text = "Hostname";
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Dock = DockStyle.Fill;
            portLabel.Font = new Font("Segoe UI", 12F);
            portLabel.ForeColor = Color.White;
            portLabel.Location = new Point(181, 106);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(150, 21);
            portLabel.TabIndex = 5;
            portLabel.Text = "Port";
            // 
            // hostnameTextBox
            // 
            hostnameTextBox.BackColor = Color.FromArgb(35, 36, 42);
            hostnameTextBox.BorderStyle = BorderStyle.FixedSingle;
            hostnameTextBox.Dock = DockStyle.Fill;
            hostnameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hostnameTextBox.ForeColor = Color.White;
            hostnameTextBox.Location = new Point(23, 130);
            hostnameTextBox.Name = "hostnameTextBox";
            hostnameTextBox.Size = new Size(152, 29);
            hostnameTextBox.TabIndex = 6;
            // 
            // portTextBox
            // 
            portTextBox.BackColor = Color.FromArgb(35, 36, 42);
            portTextBox.BorderStyle = BorderStyle.FixedSingle;
            portTextBox.Dock = DockStyle.Fill;
            portTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            portTextBox.ForeColor = Color.White;
            portTextBox.Location = new Point(181, 130);
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(150, 29);
            portTextBox.TabIndex = 7;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.FromArgb(35, 36, 42);
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Dock = DockStyle.Fill;
            usernameTextBox.Font = new Font("Segoe UI", 12F);
            usernameTextBox.ForeColor = Color.White;
            usernameTextBox.Location = new Point(23, 216);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(152, 29);
            usernameTextBox.TabIndex = 10;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(35, 36, 42);
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Dock = DockStyle.Fill;
            passwordTextBox.Font = new Font("Segoe UI", 12F);
            passwordTextBox.ForeColor = Color.White;
            passwordTextBox.Location = new Point(181, 216);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(150, 29);
            passwordTextBox.TabIndex = 11;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // serviceNameRadioButton
            // 
            serviceNameRadioButton.AutoSize = true;
            serviceNameRadioButton.Dock = DockStyle.Fill;
            serviceNameRadioButton.Font = new Font("Segoe UI", 12F);
            serviceNameRadioButton.ForeColor = Color.White;
            serviceNameRadioButton.Location = new Point(23, 316);
            serviceNameRadioButton.Name = "serviceNameRadioButton";
            serviceNameRadioButton.Size = new Size(152, 29);
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
            sidRadioButton.Location = new Point(23, 281);
            sidRadioButton.Name = "sidRadioButton";
            sidRadioButton.Size = new Size(152, 29);
            sidRadioButton.TabIndex = 13;
            sidRadioButton.TabStop = true;
            sidRadioButton.Text = "SID";
            sidRadioButton.UseVisualStyleBackColor = true;
            // 
            // sidTextBox
            // 
            sidTextBox.BackColor = Color.FromArgb(35, 36, 42);
            sidTextBox.BorderStyle = BorderStyle.FixedSingle;
            sidTextBox.Dock = DockStyle.Fill;
            sidTextBox.Font = new Font("Segoe UI", 12F);
            sidTextBox.ForeColor = Color.White;
            sidTextBox.Location = new Point(181, 281);
            sidTextBox.Name = "sidTextBox";
            sidTextBox.Size = new Size(150, 29);
            sidTextBox.TabIndex = 14;
            // 
            // serviceNameTextBox
            // 
            serviceNameTextBox.BackColor = Color.FromArgb(35, 36, 42);
            serviceNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            serviceNameTextBox.Dock = DockStyle.Fill;
            serviceNameTextBox.Enabled = false;
            serviceNameTextBox.Font = new Font("Segoe UI", 12F);
            serviceNameTextBox.ForeColor = Color.White;
            serviceNameTextBox.Location = new Point(181, 316);
            serviceNameTextBox.Name = "serviceNameTextBox";
            serviceNameTextBox.Size = new Size(150, 29);
            serviceNameTextBox.TabIndex = 15;
            // 
            // customActionBar
            // 
            customActionBar.BackColor = Color.FromArgb(35, 36, 42);
            customActionBar.Dock = DockStyle.Bottom;
            customActionBar.ForeColor = Color.White;
            customActionBar.Location = new Point(0, 368);
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
            ClientSize = new Size(356, 409);
            ControlBox = false;
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddConnectionModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddConnectionModal";
            mainPanel.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private TableLayoutPanel tableLayoutPanel;
        private Label passwordLabel;
        private Label usernameLabel;
        private Label label1;
        private TextBox conNameTextBox;
        private Label hostnameLabel;
        private Label portLabel;
        private TextBox hostnameTextBox;
        private TextBox portTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Components.CustomActionBar customActionBar;
        private RadioButton serviceNameRadioButton;
        private RadioButton sidRadioButton;
        private TextBox sidTextBox;
        private TextBox serviceNameTextBox;
    }
}
namespace DatabaseAnalyzer.Forms
{
    partial class ConnectPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            titlePanel = new Panel();
            customControlsPanel = new DatabaseAnalyzer.Components.CustomControlsPanel();
            connectionsSplitContainer = new SplitContainer();
            connectionsCheckedListBox = new CheckedListBox();
            detailsPanel = new Panel();
            detailsTableLayoutPanel = new TableLayoutPanel();
            portLabel = new Label();
            conNameLabel = new Label();
            conNameTextBox = new TextBox();
            detailsLabel = new Label();
            hostnameLabel = new Label();
            sidServiceNameLabel = new Label();
            hostnameTextBox = new TextBox();
            portTextBox = new TextBox();
            sidServiceNameTextBox = new TextBox();
            titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)connectionsSplitContainer).BeginInit();
            connectionsSplitContainer.Panel1.SuspendLayout();
            connectionsSplitContainer.Panel2.SuspendLayout();
            connectionsSplitContainer.SuspendLayout();
            detailsPanel.SuspendLayout();
            detailsTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("MS Reference Sans Serif", 24F);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(147, 40);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Connect";
            // 
            // titlePanel
            // 
            titlePanel.Controls.Add(titleLabel);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(10, 10);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(807, 43);
            titlePanel.TabIndex = 3;
            // 
            // customControlsPanel
            // 
            customControlsPanel.BackColor = Color.FromArgb(28, 29, 34);
            customControlsPanel.Dock = DockStyle.Top;
            customControlsPanel.EnableAddButton = true;
            customControlsPanel.EnableDeleteButton = true;
            customControlsPanel.EnableEditButton = true;
            customControlsPanel.EnableRefreshButton = true;
            customControlsPanel.Location = new Point(10, 53);
            customControlsPanel.MaximumSize = new Size(0, 60);
            customControlsPanel.MinimumSize = new Size(0, 60);
            customControlsPanel.Name = "customControlsPanel";
            customControlsPanel.ShowAddButton = true;
            customControlsPanel.ShowDeleteButton = true;
            customControlsPanel.ShowEditButton = true;
            customControlsPanel.ShowRefreshButton = false;
            customControlsPanel.Size = new Size(807, 60);
            customControlsPanel.TabIndex = 5;
            // 
            // connectionsSplitContainer
            // 
            connectionsSplitContainer.Dock = DockStyle.Fill;
            connectionsSplitContainer.Location = new Point(10, 113);
            connectionsSplitContainer.Name = "connectionsSplitContainer";
            // 
            // connectionsSplitContainer.Panel1
            // 
            connectionsSplitContainer.Panel1.Controls.Add(connectionsCheckedListBox);
            // 
            // connectionsSplitContainer.Panel2
            // 
            connectionsSplitContainer.Panel2.Controls.Add(detailsPanel);
            connectionsSplitContainer.Size = new Size(807, 441);
            connectionsSplitContainer.SplitterDistance = 482;
            connectionsSplitContainer.TabIndex = 6;
            // 
            // connectionsCheckedListBox
            // 
            connectionsCheckedListBox.BackColor = Color.FromArgb(28, 29, 34);
            connectionsCheckedListBox.BorderStyle = BorderStyle.None;
            connectionsCheckedListBox.Dock = DockStyle.Fill;
            connectionsCheckedListBox.Font = new Font("MS Reference Sans Serif", 12F);
            connectionsCheckedListBox.ForeColor = Color.White;
            connectionsCheckedListBox.FormattingEnabled = true;
            connectionsCheckedListBox.ItemHeight = 30;
            connectionsCheckedListBox.Location = new Point(0, 0);
            connectionsCheckedListBox.Name = "connectionsCheckedListBox";
            connectionsCheckedListBox.Size = new Size(482, 441);
            connectionsCheckedListBox.TabIndex = 0;
            // 
            // detailsPanel
            // 
            detailsPanel.Controls.Add(detailsTableLayoutPanel);
            detailsPanel.Dock = DockStyle.Fill;
            detailsPanel.Location = new Point(0, 0);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Padding = new Padding(3);
            detailsPanel.Size = new Size(321, 441);
            detailsPanel.TabIndex = 0;
            // 
            // detailsTableLayoutPanel
            // 
            detailsTableLayoutPanel.ColumnCount = 2;
            detailsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            detailsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            detailsTableLayoutPanel.Controls.Add(portLabel, 1, 5);
            detailsTableLayoutPanel.Controls.Add(conNameLabel, 0, 2);
            detailsTableLayoutPanel.Controls.Add(conNameTextBox, 0, 3);
            detailsTableLayoutPanel.Controls.Add(detailsLabel, 0, 0);
            detailsTableLayoutPanel.Controls.Add(hostnameLabel, 0, 5);
            detailsTableLayoutPanel.Controls.Add(sidServiceNameLabel, 0, 8);
            detailsTableLayoutPanel.Controls.Add(hostnameTextBox, 0, 6);
            detailsTableLayoutPanel.Controls.Add(portTextBox, 1, 6);
            detailsTableLayoutPanel.Controls.Add(sidServiceNameTextBox, 0, 9);
            detailsTableLayoutPanel.Dock = DockStyle.Fill;
            detailsTableLayoutPanel.Location = new Point(3, 3);
            detailsTableLayoutPanel.Name = "detailsTableLayoutPanel";
            detailsTableLayoutPanel.RowCount = 10;
            detailsTableLayoutPanel.RowStyles.Add(new RowStyle());
            detailsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            detailsTableLayoutPanel.RowStyles.Add(new RowStyle());
            detailsTableLayoutPanel.RowStyles.Add(new RowStyle());
            detailsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            detailsTableLayoutPanel.RowStyles.Add(new RowStyle());
            detailsTableLayoutPanel.RowStyles.Add(new RowStyle());
            detailsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            detailsTableLayoutPanel.RowStyles.Add(new RowStyle());
            detailsTableLayoutPanel.RowStyles.Add(new RowStyle());
            detailsTableLayoutPanel.Size = new Size(315, 435);
            detailsTableLayoutPanel.TabIndex = 1;
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Dock = DockStyle.Fill;
            portLabel.Font = new Font("Segoe UI", 12F);
            portLabel.ForeColor = Color.White;
            portLabel.Location = new Point(160, 134);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(152, 21);
            portLabel.TabIndex = 4;
            portLabel.Text = "Port";
            // 
            // conNameLabel
            // 
            conNameLabel.AutoSize = true;
            detailsTableLayoutPanel.SetColumnSpan(conNameLabel, 2);
            conNameLabel.Dock = DockStyle.Fill;
            conNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            conNameLabel.ForeColor = Color.White;
            conNameLabel.Location = new Point(3, 55);
            conNameLabel.Name = "conNameLabel";
            conNameLabel.Size = new Size(309, 21);
            conNameLabel.TabIndex = 0;
            conNameLabel.Text = "Connection name";
            // 
            // conNameTextBox
            // 
            conNameTextBox.BackColor = Color.FromArgb(28, 29, 34);
            conNameTextBox.BorderStyle = BorderStyle.None;
            detailsTableLayoutPanel.SetColumnSpan(conNameTextBox, 2);
            conNameTextBox.Dock = DockStyle.Fill;
            conNameTextBox.Enabled = false;
            conNameTextBox.Font = new Font("Segoe UI", 12F);
            conNameTextBox.ForeColor = Color.White;
            conNameTextBox.Location = new Point(9, 79);
            conNameTextBox.Margin = new Padding(9, 3, 3, 3);
            conNameTextBox.Name = "conNameTextBox";
            conNameTextBox.ReadOnly = true;
            conNameTextBox.Size = new Size(303, 22);
            conNameTextBox.TabIndex = 1;
            // 
            // detailsLabel
            // 
            detailsLabel.AutoSize = true;
            detailsLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            detailsLabel.ForeColor = Color.White;
            detailsLabel.Location = new Point(3, 0);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new Size(71, 25);
            detailsLabel.TabIndex = 2;
            detailsLabel.Text = "Details";
            // 
            // hostnameLabel
            // 
            hostnameLabel.AutoSize = true;
            hostnameLabel.Dock = DockStyle.Fill;
            hostnameLabel.Font = new Font("Segoe UI", 12F);
            hostnameLabel.ForeColor = Color.White;
            hostnameLabel.Location = new Point(3, 134);
            hostnameLabel.Name = "hostnameLabel";
            hostnameLabel.Size = new Size(151, 21);
            hostnameLabel.TabIndex = 3;
            hostnameLabel.Text = "Hostname";
            // 
            // sidServiceNameLabel
            // 
            sidServiceNameLabel.AutoSize = true;
            sidServiceNameLabel.Dock = DockStyle.Fill;
            sidServiceNameLabel.Font = new Font("Segoe UI", 12F);
            sidServiceNameLabel.ForeColor = Color.White;
            sidServiceNameLabel.Location = new Point(3, 213);
            sidServiceNameLabel.Name = "sidServiceNameLabel";
            sidServiceNameLabel.Size = new Size(151, 21);
            sidServiceNameLabel.TabIndex = 5;
            sidServiceNameLabel.Text = "SID";
            // 
            // hostnameTextBox
            // 
            hostnameTextBox.BackColor = Color.FromArgb(28, 29, 34);
            hostnameTextBox.BorderStyle = BorderStyle.None;
            hostnameTextBox.Dock = DockStyle.Fill;
            hostnameTextBox.Enabled = false;
            hostnameTextBox.Font = new Font("Segoe UI", 12F);
            hostnameTextBox.ForeColor = Color.White;
            hostnameTextBox.Location = new Point(9, 158);
            hostnameTextBox.Margin = new Padding(9, 3, 3, 3);
            hostnameTextBox.Name = "hostnameTextBox";
            hostnameTextBox.ReadOnly = true;
            hostnameTextBox.Size = new Size(145, 22);
            hostnameTextBox.TabIndex = 6;
            // 
            // portTextBox
            // 
            portTextBox.BackColor = Color.FromArgb(28, 29, 34);
            portTextBox.BorderStyle = BorderStyle.None;
            portTextBox.Dock = DockStyle.Fill;
            portTextBox.Enabled = false;
            portTextBox.Font = new Font("Segoe UI", 12F);
            portTextBox.ForeColor = Color.White;
            portTextBox.Location = new Point(166, 158);
            portTextBox.Margin = new Padding(9, 3, 3, 3);
            portTextBox.Name = "portTextBox";
            portTextBox.ReadOnly = true;
            portTextBox.Size = new Size(146, 22);
            portTextBox.TabIndex = 7;
            // 
            // sidServiceNameTextBox
            // 
            sidServiceNameTextBox.BackColor = Color.FromArgb(28, 29, 34);
            sidServiceNameTextBox.BorderStyle = BorderStyle.None;
            sidServiceNameTextBox.Dock = DockStyle.Fill;
            sidServiceNameTextBox.Enabled = false;
            sidServiceNameTextBox.Font = new Font("Segoe UI", 12F);
            sidServiceNameTextBox.ForeColor = Color.White;
            sidServiceNameTextBox.Location = new Point(9, 237);
            sidServiceNameTextBox.Margin = new Padding(9, 3, 3, 3);
            sidServiceNameTextBox.Name = "sidServiceNameTextBox";
            sidServiceNameTextBox.ReadOnly = true;
            sidServiceNameTextBox.Size = new Size(145, 22);
            sidServiceNameTextBox.TabIndex = 8;
            // 
            // ConnectPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 29, 34);
            Controls.Add(connectionsSplitContainer);
            Controls.Add(customControlsPanel);
            Controls.Add(titlePanel);
            Name = "ConnectPage";
            Padding = new Padding(10);
            Size = new Size(827, 564);
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            connectionsSplitContainer.Panel1.ResumeLayout(false);
            connectionsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)connectionsSplitContainer).EndInit();
            connectionsSplitContainer.ResumeLayout(false);
            detailsPanel.ResumeLayout(false);
            detailsTableLayoutPanel.ResumeLayout(false);
            detailsTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private Panel titlePanel;
        private Components.CustomControlsPanel customControlsPanel;
        private SplitContainer connectionsSplitContainer;
        private CheckedListBox connectionsCheckedListBox;
        private Panel detailsPanel;
        private TableLayoutPanel detailsTableLayoutPanel;
        private Label portLabel;
        private Label conNameLabel;
        private TextBox conNameTextBox;
        private Label detailsLabel;
        private Label hostnameLabel;
        private Label sidServiceNameLabel;
        private TextBox hostnameTextBox;
        private TextBox portTextBox;
        private TextBox sidServiceNameTextBox;
    }
}
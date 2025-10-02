namespace DatabaseAnalyzer.Forms
{
    partial class MainForm
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
            tiltleBar1 = new DatabaseAnalyzer.Components.TiltleBar();
            splitContainer = new DatabaseAnalyzer.Components.CustomSplitContainer();
            viewDifferencesButton = new Button();
            compareWithSnapshotButton = new Button();
            snapshotButton = new Button();
            titleLabel = new Label();
            reportButton = new Button();
            syncButton = new Button();
            compareButton = new Button();
            connectButton = new Button();
            homeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // tiltleBar1
            // 
            tiltleBar1.BackColor = Color.FromArgb(28, 29, 34);
            tiltleBar1.Dock = DockStyle.Top;
            tiltleBar1.Location = new Point(1, 1);
            tiltleBar1.Name = "tiltleBar1";
            tiltleBar1.Padding = new Padding(0, 0, 10, 0);
            tiltleBar1.Size = new Size(1170, 39);
            tiltleBar1.TabIndex = 1;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.IsSplitterFixed = true;
            splitContainer.Location = new Point(1, 40);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(viewDifferencesButton);
            splitContainer.Panel1.Controls.Add(compareWithSnapshotButton);
            splitContainer.Panel1.Controls.Add(snapshotButton);
            splitContainer.Panel1.Controls.Add(titleLabel);
            splitContainer.Panel1.Controls.Add(reportButton);
            splitContainer.Panel1.Controls.Add(syncButton);
            splitContainer.Panel1.Controls.Add(compareButton);
            splitContainer.Panel1.Controls.Add(connectButton);
            splitContainer.Panel1.Controls.Add(homeButton);
            splitContainer.Size = new Size(1170, 689);
            splitContainer.SplitterDistance = 290;
            splitContainer.TabIndex = 3;
            // 
            // viewDifferencesButton
            // 
            viewDifferencesButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            viewDifferencesButton.BackColor = Color.FromArgb(28, 29, 34);
            viewDifferencesButton.FlatAppearance.BorderSize = 0;
            viewDifferencesButton.FlatStyle = FlatStyle.Flat;
            viewDifferencesButton.Font = new Font("Bahnschrift SemiLight", 14F);
            viewDifferencesButton.ForeColor = Color.White;
            viewDifferencesButton.Image = Properties.Resources.differences;
            viewDifferencesButton.ImageAlign = ContentAlignment.MiddleLeft;
            viewDifferencesButton.Location = new Point(20, 616);
            viewDifferencesButton.Name = "viewDifferencesButton";
            viewDifferencesButton.Size = new Size(247, 39);
            viewDifferencesButton.TabIndex = 32;
            viewDifferencesButton.Text = "View Differences";
            viewDifferencesButton.TextAlign = ContentAlignment.MiddleLeft;
            viewDifferencesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            viewDifferencesButton.UseVisualStyleBackColor = false;
            // 
            // compareWithSnapshotButton
            // 
            compareWithSnapshotButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            compareWithSnapshotButton.BackColor = Color.FromArgb(28, 29, 34);
            compareWithSnapshotButton.FlatAppearance.BorderSize = 0;
            compareWithSnapshotButton.FlatStyle = FlatStyle.Flat;
            compareWithSnapshotButton.Font = new Font("Bahnschrift SemiLight", 14F);
            compareWithSnapshotButton.ForeColor = Color.White;
            compareWithSnapshotButton.Image = Properties.Resources.compare_snapshot;
            compareWithSnapshotButton.ImageAlign = ContentAlignment.MiddleLeft;
            compareWithSnapshotButton.Location = new Point(20, 571);
            compareWithSnapshotButton.Name = "compareWithSnapshotButton";
            compareWithSnapshotButton.Size = new Size(247, 39);
            compareWithSnapshotButton.TabIndex = 31;
            compareWithSnapshotButton.Text = "Compare with Snapshot";
            compareWithSnapshotButton.TextAlign = ContentAlignment.MiddleLeft;
            compareWithSnapshotButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            compareWithSnapshotButton.UseVisualStyleBackColor = false;
            // 
            // snapshotButton
            // 
            snapshotButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            snapshotButton.BackColor = Color.FromArgb(28, 29, 34);
            snapshotButton.FlatAppearance.BorderSize = 0;
            snapshotButton.FlatStyle = FlatStyle.Flat;
            snapshotButton.Font = new Font("Bahnschrift SemiLight", 14F);
            snapshotButton.ForeColor = Color.White;
            snapshotButton.Image = Properties.Resources.snapshot;
            snapshotButton.ImageAlign = ContentAlignment.MiddleLeft;
            snapshotButton.Location = new Point(20, 526);
            snapshotButton.Name = "snapshotButton";
            snapshotButton.Size = new Size(247, 39);
            snapshotButton.TabIndex = 30;
            snapshotButton.Text = "Snapshot";
            snapshotButton.TextAlign = ContentAlignment.MiddleLeft;
            snapshotButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            snapshotButton.UseVisualStyleBackColor = false;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(19, 29);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(215, 46);
            titleLabel.TabIndex = 29;
            titleLabel.Text = "DB Analyzer";
            // 
            // reportButton
            // 
            reportButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            reportButton.BackColor = Color.FromArgb(28, 29, 34);
            reportButton.FlatAppearance.BorderSize = 0;
            reportButton.FlatStyle = FlatStyle.Flat;
            reportButton.Font = new Font("Bahnschrift SemiLight", 14F);
            reportButton.ForeColor = Color.White;
            reportButton.Image = Properties.Resources.report;
            reportButton.ImageAlign = ContentAlignment.MiddleLeft;
            reportButton.Location = new Point(20, 286);
            reportButton.Name = "reportButton";
            reportButton.Size = new Size(247, 39);
            reportButton.TabIndex = 28;
            reportButton.Text = "Report";
            reportButton.TextAlign = ContentAlignment.MiddleLeft;
            reportButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            reportButton.UseVisualStyleBackColor = false;
            // 
            // syncButton
            // 
            syncButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            syncButton.BackColor = Color.FromArgb(28, 29, 34);
            syncButton.FlatAppearance.BorderSize = 0;
            syncButton.FlatStyle = FlatStyle.Flat;
            syncButton.Font = new Font("Bahnschrift SemiLight", 14F);
            syncButton.ForeColor = Color.White;
            syncButton.Image = Properties.Resources.sync;
            syncButton.ImageAlign = ContentAlignment.MiddleLeft;
            syncButton.Location = new Point(20, 241);
            syncButton.Name = "syncButton";
            syncButton.Size = new Size(247, 39);
            syncButton.TabIndex = 27;
            syncButton.Text = "Sync";
            syncButton.TextAlign = ContentAlignment.MiddleLeft;
            syncButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            syncButton.UseVisualStyleBackColor = false;
            // 
            // compareButton
            // 
            compareButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            compareButton.BackColor = Color.FromArgb(28, 29, 34);
            compareButton.FlatAppearance.BorderSize = 0;
            compareButton.FlatStyle = FlatStyle.Flat;
            compareButton.Font = new Font("Bahnschrift SemiLight", 14F);
            compareButton.ForeColor = Color.White;
            compareButton.Image = Properties.Resources.compare;
            compareButton.ImageAlign = ContentAlignment.MiddleLeft;
            compareButton.Location = new Point(20, 196);
            compareButton.Name = "compareButton";
            compareButton.Size = new Size(247, 39);
            compareButton.TabIndex = 26;
            compareButton.Text = "Compare";
            compareButton.TextAlign = ContentAlignment.MiddleLeft;
            compareButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            compareButton.UseVisualStyleBackColor = false;
            // 
            // connectButton
            // 
            connectButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            connectButton.BackColor = Color.FromArgb(28, 29, 34);
            connectButton.FlatAppearance.BorderSize = 0;
            connectButton.FlatStyle = FlatStyle.Flat;
            connectButton.Font = new Font("Bahnschrift SemiLight", 14F);
            connectButton.ForeColor = Color.White;
            connectButton.Image = Properties.Resources.connect;
            connectButton.ImageAlign = ContentAlignment.MiddleLeft;
            connectButton.Location = new Point(20, 151);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(247, 39);
            connectButton.TabIndex = 25;
            connectButton.Text = "Connect";
            connectButton.TextAlign = ContentAlignment.MiddleLeft;
            connectButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            connectButton.UseVisualStyleBackColor = false;
            // 
            // homeButton
            // 
            homeButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            homeButton.BackColor = Color.FromArgb(28, 29, 34);
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Font = new Font("Bahnschrift SemiLight", 14F);
            homeButton.ForeColor = Color.White;
            homeButton.Image = Properties.Resources.home;
            homeButton.ImageAlign = ContentAlignment.MiddleLeft;
            homeButton.Location = new Point(20, 106);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(247, 39);
            homeButton.TabIndex = 24;
            homeButton.Text = "Home";
            homeButton.TextAlign = ContentAlignment.MiddleLeft;
            homeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            homeButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 29, 34);
            ClientSize = new Size(1172, 730);
            Controls.Add(splitContainer);
            Controls.Add(tiltleBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Components.TiltleBar tiltleBar1;
        private Components.CustomSplitContainer splitContainer;
        private Button viewDifferencesButton;
        private Button compareWithSnapshotButton;
        private Button snapshotButton;
        private Label titleLabel;
        private Button reportButton;
        private Button syncButton;
        private Button compareButton;
        private Button connectButton;
        private Button homeButton;
    }
}
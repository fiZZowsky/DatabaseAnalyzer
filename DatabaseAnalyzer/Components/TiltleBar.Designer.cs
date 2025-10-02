namespace DatabaseAnalyzer.Components
{
    partial class TiltleBar
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
            mainPanel = new Panel();
            label1 = new Label();
            minimizeButton = new Button();
            maximizeButton = new Button();
            closeButton = new Button();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(minimizeButton);
            mainPanel.Controls.Add(maximizeButton);
            mainPanel.Controls.Add(closeButton);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(393, 39);
            mainPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(28, 29, 34);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 3;
            label1.Text = "Database Analyzer";
            label1.Visible = false;
            // 
            // minimizeButton
            // 
            minimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            minimizeButton.BackColor = Color.FromArgb(28, 29, 34);
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Font = new Font("Segoe UI", 12F);
            minimizeButton.ForeColor = Color.White;
            minimizeButton.Image = Properties.Resources.minimize;
            minimizeButton.Location = new Point(324, 8);
            minimizeButton.Margin = new Padding(0);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(23, 23);
            minimizeButton.TabIndex = 2;
            minimizeButton.UseVisualStyleBackColor = false;
            // 
            // maximizeButton
            // 
            maximizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            maximizeButton.BackColor = Color.FromArgb(28, 29, 34);
            maximizeButton.FlatAppearance.BorderSize = 0;
            maximizeButton.FlatStyle = FlatStyle.Flat;
            maximizeButton.Font = new Font("Segoe UI", 12F);
            maximizeButton.ForeColor = Color.White;
            maximizeButton.Image = Properties.Resources.fullscreen;
            maximizeButton.Location = new Point(347, 8);
            maximizeButton.Margin = new Padding(0);
            maximizeButton.Name = "maximizeButton";
            maximizeButton.Size = new Size(23, 23);
            maximizeButton.TabIndex = 1;
            maximizeButton.UseVisualStyleBackColor = false;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            closeButton.BackColor = Color.FromArgb(28, 29, 34);
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe UI", 12F);
            closeButton.ForeColor = Color.White;
            closeButton.Image = Properties.Resources.close;
            closeButton.Location = new Point(370, 8);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(23, 23);
            closeButton.TabIndex = 0;
            closeButton.UseVisualStyleBackColor = false;
            // 
            // TiltleBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 29, 34);
            Controls.Add(mainPanel);
            Name = "TiltleBar";
            Size = new Size(393, 39);
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label label1;
        private Button minimizeButton;
        private Button maximizeButton;
        private Button closeButton;
    }
}

namespace DatabaseAnalyzer.Components
{
    partial class CustomActionBar
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
            flowLayoutPanel = new FlowLayoutPanel();
            cancelButton = new Button();
            acceptButton = new Button();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(cancelButton);
            flowLayoutPanel.Controls.Add(acceptButton);
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(426, 39);
            flowLayoutPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Right;
            cancelButton.BackColor = Color.FromArgb(36, 60, 104);
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cancelButton.Image = Properties.Resources.close;
            cancelButton.Location = new Point(324, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(99, 33);
            cancelButton.TabIndex = 0;
            cancelButton.Text = "Cancel";
            cancelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // acceptButton
            // 
            acceptButton.Anchor = AnchorStyles.Right;
            acceptButton.BackColor = Color.FromArgb(36, 60, 104);
            acceptButton.FlatAppearance.BorderSize = 0;
            acceptButton.FlatStyle = FlatStyle.Flat;
            acceptButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            acceptButton.Image = Properties.Resources.accept;
            acceptButton.Location = new Point(212, 3);
            acceptButton.Margin = new Padding(3, 3, 10, 3);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(99, 33);
            acceptButton.TabIndex = 1;
            acceptButton.Text = "OK";
            acceptButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            acceptButton.UseVisualStyleBackColor = false;
            // 
            // CustomActionBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 42);
            Controls.Add(flowLayoutPanel);
            ForeColor = Color.White;
            MaximumSize = new Size(0, 39);
            MinimumSize = new Size(203, 39);
            Name = "CustomActionBar";
            Size = new Size(426, 39);
            flowLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private Button cancelButton;
        private Button acceptButton;
    }
}

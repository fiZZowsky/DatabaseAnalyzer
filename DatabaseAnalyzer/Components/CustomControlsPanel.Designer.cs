namespace DatabaseAnalyzer.Components
{
    partial class CustomControlsPanel
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
            refreshButton = new Button();
            addButton = new SimpleButton();
            editButton = new SimpleButton();
            deleteButton = new SimpleButton();
            SuspendLayout();
            // 
            // refreshButton
            // 
            refreshButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            refreshButton.BackColor = Color.FromArgb(36, 60, 104);
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Segoe UI", 11F);
            refreshButton.ForeColor = Color.White;
            refreshButton.Image = Properties.Resources.refresh;
            refreshButton.Location = new Point(834, 13);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(90, 33);
            refreshButton.TabIndex = 3;
            refreshButton.Text = "Refresh";
            refreshButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            refreshButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Left;
            addButton.BackColor = Color.FromArgb(36, 60, 104);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 11F);
            addButton.ForeColor = Color.White;
            addButton.Image = Properties.Resources.add;
            addButton.Location = new Point(3, 12);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(85, 33);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            editButton.BackColor = Color.FromArgb(36, 60, 104);
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Segoe UI", 11F);
            editButton.ForeColor = Color.White;
            editButton.Image = Properties.Resources.edit;
            editButton.Location = new Point(106, 13);
            editButton.Margin = new Padding(3, 4, 3, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(85, 33);
            editButton.TabIndex = 5;
            editButton.Text = "Edit";
            editButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            editButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(36, 60, 104);
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 11F);
            deleteButton.ForeColor = Color.White;
            deleteButton.Image = Properties.Resources.delete;
            deleteButton.Location = new Point(209, 13);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(85, 33);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // CustomControlsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 29, 34);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(refreshButton);
            MaximumSize = new Size(0, 60);
            MinimumSize = new Size(0, 60);
            Name = "CustomControlsPanel";
            Size = new Size(927, 60);
            ResumeLayout(false);
        }

        #endregion
        private Button refreshButton;
        private SimpleButton addButton;
        private SimpleButton editButton;
        private SimpleButton deleteButton;
    }
}

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
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            refreshButton = new Button();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            addButton.BackColor = Color.FromArgb(36, 60, 104);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 11F);
            addButton.ForeColor = Color.White;
            addButton.Image = Properties.Resources.add;
            addButton.Location = new Point(3, 13);
            addButton.Name = "addButton";
            addButton.Size = new Size(85, 33);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            editButton.BackColor = Color.FromArgb(36, 60, 104);
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Segoe UI", 11F);
            editButton.ForeColor = Color.White;
            editButton.Image = Properties.Resources.edit;
            editButton.Location = new Point(103, 13);
            editButton.Name = "editButton";
            editButton.Size = new Size(85, 33);
            editButton.TabIndex = 1;
            editButton.Text = "Edit";
            editButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            editButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            deleteButton.BackColor = Color.FromArgb(36, 60, 104);
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 11F);
            deleteButton.ForeColor = Color.White;
            deleteButton.Image = Properties.Resources.delete;
            deleteButton.Location = new Point(204, 13);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(85, 33);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteButton.UseVisualStyleBackColor = false;
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
            // CustomControlsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 29, 34);
            Controls.Add(refreshButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            MaximumSize = new Size(0, 60);
            MinimumSize = new Size(0, 60);
            Name = "CustomControlsPanel";
            Size = new Size(927, 60);
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button refreshButton;
    }
}

namespace DatabaseAnalyzer
{
    partial class ComparePage
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
            lblTitle = new Label();
            lblConnections = new Label();
            lblCompareSection = new Label();
            btnCompare = new Button();
            pnlCompare = new Panel();
            tlpCompareOptions = new TableLayoutPanel();
            chkTables = new CheckBox();
            chkDataTypes = new CheckBox();
            chkIndexes = new CheckBox();
            chkColumns = new CheckBox();
            chkTriggers1 = new CheckBox();
            chkSequences = new CheckBox();
            chkForeignKeys1 = new CheckBox();
            chkViews = new CheckBox();
            chkProcedures = new CheckBox();
            chkFunctions = new CheckBox();
            chkPackages = new CheckBox();
            chkTriggers2 = new CheckBox();
            chkForeignKeys2 = new CheckBox();
            chkPrimaryKeys = new CheckBox();
            tlpConnections = new TableLayoutPanel();
            cmbDb1 = new ComboBox();
            cmbDb2 = new ComboBox();
            pnlCompare.SuspendLayout();
            tlpCompareOptions.SuspendLayout();
            tlpConnections.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(273, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Compare Databases";
            // 
            // lblConnections
            // 
            lblConnections.AutoSize = true;
            lblConnections.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblConnections.ForeColor = Color.White;
            lblConnections.Location = new Point(28, 80);
            lblConnections.Name = "lblConnections";
            lblConnections.Size = new Size(105, 21);
            lblConnections.TabIndex = 1;
            lblConnections.Text = "Connections";
            // 
            // lblCompareSection
            // 
            lblCompareSection.AutoSize = true;
            lblCompareSection.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCompareSection.ForeColor = Color.White;
            lblCompareSection.Location = new Point(28, 175);
            lblCompareSection.Name = "lblCompareSection";
            lblCompareSection.Size = new Size(79, 21);
            lblCompareSection.TabIndex = 3;
            lblCompareSection.Text = "Compare";
            // 
            // btnCompare
            // 
            btnCompare.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCompare.BackColor = Color.FromArgb(45, 85, 155);
            btnCompare.FlatAppearance.BorderSize = 0;
            btnCompare.FlatStyle = FlatStyle.Flat;
            btnCompare.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCompare.ForeColor = Color.White;
            btnCompare.Location = new Point(32, 502);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(763, 40);
            btnCompare.TabIndex = 5;
            btnCompare.Text = "Compare";
            btnCompare.UseVisualStyleBackColor = false;
            // 
            // pnlCompare
            // 
            pnlCompare.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCompare.BackColor = Color.FromArgb(35, 36, 41);
            pnlCompare.Controls.Add(tlpCompareOptions);
            pnlCompare.Location = new Point(32, 205);
            pnlCompare.Name = "pnlCompare";
            pnlCompare.Padding = new Padding(15);
            pnlCompare.Size = new Size(763, 275);
            pnlCompare.TabIndex = 4;
            // 
            // tlpCompareOptions
            // 
            tlpCompareOptions.ColumnCount = 2;
            tlpCompareOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCompareOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCompareOptions.Controls.Add(chkTables, 0, 0);
            tlpCompareOptions.Controls.Add(chkDataTypes, 0, 1);
            tlpCompareOptions.Controls.Add(chkIndexes, 0, 2);
            tlpCompareOptions.Controls.Add(chkColumns, 0, 3);
            tlpCompareOptions.Controls.Add(chkTriggers1, 0, 4);
            tlpCompareOptions.Controls.Add(chkSequences, 0, 5);
            tlpCompareOptions.Controls.Add(chkForeignKeys1, 0, 6);
            tlpCompareOptions.Controls.Add(chkViews, 1, 0);
            tlpCompareOptions.Controls.Add(chkProcedures, 1, 1);
            tlpCompareOptions.Controls.Add(chkFunctions, 1, 2);
            tlpCompareOptions.Controls.Add(chkPackages, 1, 3);
            tlpCompareOptions.Controls.Add(chkTriggers2, 1, 4);
            tlpCompareOptions.Controls.Add(chkForeignKeys2, 1, 5);
            tlpCompareOptions.Controls.Add(chkPrimaryKeys, 1, 6);
            tlpCompareOptions.Dock = DockStyle.Fill;
            tlpCompareOptions.Location = new Point(15, 15);
            tlpCompareOptions.Name = "tlpCompareOptions";
            tlpCompareOptions.RowCount = 7;
            tlpCompareOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tlpCompareOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tlpCompareOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tlpCompareOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tlpCompareOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tlpCompareOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tlpCompareOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tlpCompareOptions.Size = new Size(733, 245);
            tlpCompareOptions.TabIndex = 0;
            // 
            // chkTables
            // 
            chkTables.Checked = true;
            chkTables.CheckState = CheckState.Checked;
            chkTables.Dock = DockStyle.Top;
            chkTables.Font = new Font("Segoe UI", 11.25F);
            chkTables.ForeColor = Color.White;
            chkTables.Location = new Point(3, 3);
            chkTables.Name = "chkTables";
            chkTables.Size = new Size(360, 24);
            chkTables.TabIndex = 0;
            chkTables.Text = "Tables/Schemas";
            chkTables.UseVisualStyleBackColor = true;
            // 
            // chkDataTypes
            // 
            chkDataTypes.Checked = true;
            chkDataTypes.CheckState = CheckState.Checked;
            chkDataTypes.Dock = DockStyle.Top;
            chkDataTypes.Font = new Font("Segoe UI", 11.25F);
            chkDataTypes.ForeColor = Color.White;
            chkDataTypes.Location = new Point(3, 38);
            chkDataTypes.Name = "chkDataTypes";
            chkDataTypes.Size = new Size(360, 24);
            chkDataTypes.TabIndex = 1;
            chkDataTypes.Text = "Data Types";
            chkDataTypes.UseVisualStyleBackColor = true;
            // 
            // chkIndexes
            // 
            chkIndexes.Checked = true;
            chkIndexes.CheckState = CheckState.Checked;
            chkIndexes.Dock = DockStyle.Top;
            chkIndexes.Font = new Font("Segoe UI", 11.25F);
            chkIndexes.ForeColor = Color.White;
            chkIndexes.Location = new Point(3, 73);
            chkIndexes.Name = "chkIndexes";
            chkIndexes.Size = new Size(360, 24);
            chkIndexes.TabIndex = 2;
            chkIndexes.Text = "Indexes";
            chkIndexes.UseVisualStyleBackColor = true;
            // 
            // chkColumns
            // 
            chkColumns.Checked = true;
            chkColumns.CheckState = CheckState.Checked;
            chkColumns.Dock = DockStyle.Top;
            chkColumns.Font = new Font("Segoe UI", 11.25F);
            chkColumns.ForeColor = Color.White;
            chkColumns.Location = new Point(3, 108);
            chkColumns.Name = "chkColumns";
            chkColumns.Size = new Size(360, 24);
            chkColumns.TabIndex = 3;
            chkColumns.Text = "Columns";
            chkColumns.UseVisualStyleBackColor = true;
            // 
            // chkTriggers1
            // 
            chkTriggers1.Checked = true;
            chkTriggers1.CheckState = CheckState.Checked;
            chkTriggers1.Dock = DockStyle.Top;
            chkTriggers1.Font = new Font("Segoe UI", 11.25F);
            chkTriggers1.ForeColor = Color.White;
            chkTriggers1.Location = new Point(3, 143);
            chkTriggers1.Name = "chkTriggers1";
            chkTriggers1.Size = new Size(360, 24);
            chkTriggers1.TabIndex = 4;
            chkTriggers1.Text = "Triggers";
            chkTriggers1.UseVisualStyleBackColor = true;
            // 
            // chkSequences
            // 
            chkSequences.Checked = true;
            chkSequences.CheckState = CheckState.Checked;
            chkSequences.Dock = DockStyle.Top;
            chkSequences.Font = new Font("Segoe UI", 11.25F);
            chkSequences.ForeColor = Color.White;
            chkSequences.Location = new Point(3, 178);
            chkSequences.Name = "chkSequences";
            chkSequences.Size = new Size(360, 24);
            chkSequences.TabIndex = 5;
            chkSequences.Text = "Sequences";
            chkSequences.UseVisualStyleBackColor = true;
            // 
            // chkForeignKeys1
            // 
            chkForeignKeys1.Checked = true;
            chkForeignKeys1.CheckState = CheckState.Checked;
            chkForeignKeys1.Dock = DockStyle.Top;
            chkForeignKeys1.Font = new Font("Segoe UI", 11.25F);
            chkForeignKeys1.ForeColor = Color.White;
            chkForeignKeys1.Location = new Point(3, 213);
            chkForeignKeys1.Name = "chkForeignKeys1";
            chkForeignKeys1.Size = new Size(360, 24);
            chkForeignKeys1.TabIndex = 6;
            chkForeignKeys1.Text = "Foregin Keys";
            chkForeignKeys1.UseVisualStyleBackColor = true;
            // 
            // chkViews
            // 
            chkViews.Checked = true;
            chkViews.CheckState = CheckState.Checked;
            chkViews.Dock = DockStyle.Top;
            chkViews.Font = new Font("Segoe UI", 11.25F);
            chkViews.ForeColor = Color.White;
            chkViews.Location = new Point(369, 3);
            chkViews.Name = "chkViews";
            chkViews.Size = new Size(361, 24);
            chkViews.TabIndex = 7;
            chkViews.Text = "Views";
            chkViews.UseVisualStyleBackColor = true;
            // 
            // chkProcedures
            // 
            chkProcedures.Checked = true;
            chkProcedures.CheckState = CheckState.Checked;
            chkProcedures.Dock = DockStyle.Top;
            chkProcedures.Font = new Font("Segoe UI", 11.25F);
            chkProcedures.ForeColor = Color.White;
            chkProcedures.Location = new Point(369, 38);
            chkProcedures.Name = "chkProcedures";
            chkProcedures.Size = new Size(361, 24);
            chkProcedures.TabIndex = 8;
            chkProcedures.Text = "Procedures";
            chkProcedures.UseVisualStyleBackColor = true;
            // 
            // chkFunctions
            // 
            chkFunctions.Checked = true;
            chkFunctions.CheckState = CheckState.Checked;
            chkFunctions.Dock = DockStyle.Top;
            chkFunctions.Font = new Font("Segoe UI", 11.25F);
            chkFunctions.ForeColor = Color.White;
            chkFunctions.Location = new Point(369, 73);
            chkFunctions.Name = "chkFunctions";
            chkFunctions.Size = new Size(361, 24);
            chkFunctions.TabIndex = 9;
            chkFunctions.Text = "Functions";
            chkFunctions.UseVisualStyleBackColor = true;
            // 
            // chkPackages
            // 
            chkPackages.Checked = true;
            chkPackages.CheckState = CheckState.Checked;
            chkPackages.Dock = DockStyle.Top;
            chkPackages.Font = new Font("Segoe UI", 11.25F);
            chkPackages.ForeColor = Color.White;
            chkPackages.Location = new Point(369, 108);
            chkPackages.Name = "chkPackages";
            chkPackages.Size = new Size(361, 24);
            chkPackages.TabIndex = 10;
            chkPackages.Text = "Packages";
            chkPackages.UseVisualStyleBackColor = true;
            // 
            // chkTriggers2
            // 
            chkTriggers2.Checked = true;
            chkTriggers2.CheckState = CheckState.Checked;
            chkTriggers2.Dock = DockStyle.Top;
            chkTriggers2.Font = new Font("Segoe UI", 11.25F);
            chkTriggers2.ForeColor = Color.White;
            chkTriggers2.Location = new Point(369, 143);
            chkTriggers2.Name = "chkTriggers2";
            chkTriggers2.Size = new Size(361, 24);
            chkTriggers2.TabIndex = 11;
            chkTriggers2.Text = "Triggers";
            chkTriggers2.UseVisualStyleBackColor = true;
            // 
            // chkForeignKeys2
            // 
            chkForeignKeys2.Checked = true;
            chkForeignKeys2.CheckState = CheckState.Checked;
            chkForeignKeys2.Dock = DockStyle.Top;
            chkForeignKeys2.Font = new Font("Segoe UI", 11.25F);
            chkForeignKeys2.ForeColor = Color.White;
            chkForeignKeys2.Location = new Point(369, 178);
            chkForeignKeys2.Name = "chkForeignKeys2";
            chkForeignKeys2.Size = new Size(361, 24);
            chkForeignKeys2.TabIndex = 12;
            chkForeignKeys2.Text = "Foreign Keys";
            chkForeignKeys2.UseVisualStyleBackColor = true;
            // 
            // chkPrimaryKeys
            // 
            chkPrimaryKeys.Checked = true;
            chkPrimaryKeys.CheckState = CheckState.Checked;
            chkPrimaryKeys.Dock = DockStyle.Top;
            chkPrimaryKeys.Font = new Font("Segoe UI", 11.25F);
            chkPrimaryKeys.ForeColor = Color.White;
            chkPrimaryKeys.Location = new Point(369, 213);
            chkPrimaryKeys.Name = "chkPrimaryKeys";
            chkPrimaryKeys.Size = new Size(361, 24);
            chkPrimaryKeys.TabIndex = 13;
            chkPrimaryKeys.Text = "Primary Keys";
            chkPrimaryKeys.UseVisualStyleBackColor = true;
            // 
            // tlpConnections
            // 
            tlpConnections.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpConnections.ColumnCount = 2;
            tlpConnections.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpConnections.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpConnections.Controls.Add(cmbDb1, 0, 0);
            tlpConnections.Controls.Add(cmbDb2, 1, 0);
            tlpConnections.Location = new Point(32, 110);
            tlpConnections.Name = "tlpConnections";
            tlpConnections.RowCount = 1;
            tlpConnections.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpConnections.Size = new Size(763, 45);
            tlpConnections.TabIndex = 2;
            // 
            // cmbDb1
            // 
            cmbDb1.BackColor = Color.FromArgb(45, 45, 48);
            cmbDb1.Dock = DockStyle.Fill;
            cmbDb1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDb1.FlatStyle = FlatStyle.Flat;
            cmbDb1.Font = new Font("Segoe UI", 12F);
            cmbDb1.ForeColor = Color.White;
            cmbDb1.FormattingEnabled = true;
            cmbDb1.Location = new Point(3, 3);
            cmbDb1.Name = "cmbDb1";
            cmbDb1.Size = new Size(375, 29);
            cmbDb1.TabIndex = 0;
            // 
            // cmbDb2
            // 
            cmbDb2.BackColor = Color.FromArgb(45, 45, 48);
            cmbDb2.Dock = DockStyle.Fill;
            cmbDb2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDb2.FlatStyle = FlatStyle.Flat;
            cmbDb2.Font = new Font("Segoe UI", 12F);
            cmbDb2.ForeColor = Color.White;
            cmbDb2.FormattingEnabled = true;
            cmbDb2.Location = new Point(384, 3);
            cmbDb2.Name = "cmbDb2";
            cmbDb2.Size = new Size(376, 29);
            cmbDb2.TabIndex = 1;
            // 
            // ComparePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 29, 34);
            Controls.Add(tlpConnections);
            Controls.Add(pnlCompare);
            Controls.Add(btnCompare);
            Controls.Add(lblCompareSection);
            Controls.Add(lblConnections);
            Controls.Add(lblTitle);
            Name = "ComparePage";
            Size = new Size(827, 564);
            pnlCompare.ResumeLayout(false);
            tlpCompareOptions.ResumeLayout(false);
            tlpConnections.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblConnections;
        private System.Windows.Forms.Label lblCompareSection;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Panel pnlCompare;
        private System.Windows.Forms.TableLayoutPanel tlpCompareOptions;
        private System.Windows.Forms.CheckBox chkTables;
        private System.Windows.Forms.CheckBox chkDataTypes;
        private System.Windows.Forms.CheckBox chkIndexes;
        private System.Windows.Forms.CheckBox chkColumns;
        private System.Windows.Forms.CheckBox chkTriggers1;
        private System.Windows.Forms.CheckBox chkSequences;
        private System.Windows.Forms.CheckBox chkForeignKeys1;
        private System.Windows.Forms.CheckBox chkViews;
        private System.Windows.Forms.CheckBox chkProcedures;
        private System.Windows.Forms.CheckBox chkFunctions;
        private System.Windows.Forms.CheckBox chkPackages;
        private System.Windows.Forms.CheckBox chkTriggers2;
        private System.Windows.Forms.CheckBox chkForeignKeys2;
        private System.Windows.Forms.CheckBox chkPrimaryKeys;
        private System.Windows.Forms.TableLayoutPanel tlpConnections;
        private System.Windows.Forms.ComboBox cmbDb1;
        private System.Windows.Forms.ComboBox cmbDb2;
    }
}
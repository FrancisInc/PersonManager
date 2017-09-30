namespace PersonManager
{
    partial class PhonebookDisplayForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPhonebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePhonebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personDataGridView = new System.Windows.Forms.DataGridView();
            this.personNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personPhoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBirthdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPersonToolStripMenuItem,
            this.newPhonebookToolStripMenuItem,
            this.savePhonebookToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newPersonToolStripMenuItem
            // 
            this.newPersonToolStripMenuItem.Name = "newPersonToolStripMenuItem";
            this.newPersonToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newPersonToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.newPersonToolStripMenuItem.Text = "New Person...";
            this.newPersonToolStripMenuItem.Click += new System.EventHandler(this.newPersonToolStripMenuItem_Click);
            // 
            // newPhonebookToolStripMenuItem
            // 
            this.newPhonebookToolStripMenuItem.Name = "newPhonebookToolStripMenuItem";
            this.newPhonebookToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newPhonebookToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.newPhonebookToolStripMenuItem.Text = "New Phonebook";
            // 
            // savePhonebookToolStripMenuItem
            // 
            this.savePhonebookToolStripMenuItem.Name = "savePhonebookToolStripMenuItem";
            this.savePhonebookToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.savePhonebookToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.savePhonebookToolStripMenuItem.Text = "Save Phonebook";
            // 
            // personDataGridView
            // 
            this.personDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.personDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.personDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.personDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.personDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personNameColumn,
            this.personPhoneNumberColumn,
            this.personBirthdayColumn});
            this.personDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.personDataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.personDataGridView.Location = new System.Drawing.Point(12, 27);
            this.personDataGridView.Name = "personDataGridView";
            this.personDataGridView.Size = new System.Drawing.Size(630, 351);
            this.personDataGridView.TabIndex = 2;
            // 
            // personNameColumn
            // 
            this.personNameColumn.HeaderText = "Name";
            this.personNameColumn.Name = "personNameColumn";
            // 
            // personPhoneNumberColumn
            // 
            this.personPhoneNumberColumn.HeaderText = "Phone Number";
            this.personPhoneNumberColumn.Name = "personPhoneNumberColumn";
            // 
            // personBirthdayColumn
            // 
            this.personBirthdayColumn.HeaderText = "Birthday";
            this.personBirthdayColumn.Name = "personBirthdayColumn";
            // 
            // PhonebookDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 467);
            this.Controls.Add(this.personDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PhonebookDisplayForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPhonebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePhonebookToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personPhoneNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personBirthdayColumn;
        public System.Windows.Forms.DataGridView personDataGridView;
    }
}


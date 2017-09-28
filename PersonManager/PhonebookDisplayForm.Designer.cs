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
            this.personListView = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
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
            // personListView
            // 
            this.personListView.Location = new System.Drawing.Point(12, 27);
            this.personListView.Name = "personListView";
            this.personListView.Size = new System.Drawing.Size(617, 97);
            this.personListView.TabIndex = 1;
            this.personListView.UseCompatibleStateImageBehavior = false;
            this.personListView.View = System.Windows.Forms.View.List;
            // 
            // PhonebookDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 467);
            this.Controls.Add(this.personListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PhonebookDisplayForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPhonebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePhonebookToolStripMenuItem;
        private System.Windows.Forms.ListView personListView;
    }
}


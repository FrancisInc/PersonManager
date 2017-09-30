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
            this.personDataGridView = new System.Windows.Forms.DataGridView();
            this.personNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personPhoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBirthdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchPhonebookTextbox = new System.Windows.Forms.TextBox();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.removePersonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.personDataGridView.Location = new System.Drawing.Point(12, 38);
            this.personDataGridView.Name = "personDataGridView";
            this.personDataGridView.Size = new System.Drawing.Size(630, 350);
            this.personDataGridView.TabIndex = 2;
            this.personDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personDataGridView_CellDoubleClick);
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
            // searchPhonebookTextbox
            // 
            this.searchPhonebookTextbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.searchPhonebookTextbox.Location = new System.Drawing.Point(12, 12);
            this.searchPhonebookTextbox.Name = "searchPhonebookTextbox";
            this.searchPhonebookTextbox.Size = new System.Drawing.Size(433, 20);
            this.searchPhonebookTextbox.TabIndex = 3;
            this.searchPhonebookTextbox.Text = "Search Phonebook...";
            this.searchPhonebookTextbox.TextChanged += new System.EventHandler(this.searchPhonebookTextbox_TextChanged);
            this.searchPhonebookTextbox.Enter += new System.EventHandler(this.searchPhonebookTextbox_Enter);
            this.searchPhonebookTextbox.Leave += new System.EventHandler(this.searchPhonebookTextbox_Leave);
            // 
            // addPersonButton
            // 
            this.addPersonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addPersonButton.FlatAppearance.BorderSize = 0;
            this.addPersonButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.addPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPersonButton.Location = new System.Drawing.Point(451, 12);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(94, 20);
            this.addPersonButton.TabIndex = 4;
            this.addPersonButton.Text = "New Person";
            this.addPersonButton.UseVisualStyleBackColor = false;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // removePersonButton
            // 
            this.removePersonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.removePersonButton.FlatAppearance.BorderSize = 0;
            this.removePersonButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.removePersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePersonButton.Location = new System.Drawing.Point(551, 12);
            this.removePersonButton.Name = "removePersonButton";
            this.removePersonButton.Size = new System.Drawing.Size(91, 20);
            this.removePersonButton.TabIndex = 5;
            this.removePersonButton.Text = "Remove Person";
            this.removePersonButton.UseVisualStyleBackColor = false;
            this.removePersonButton.Click += new System.EventHandler(this.removePersonButton_Click);
            // 
            // PhonebookDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 467);
            this.Controls.Add(this.removePersonButton);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.searchPhonebookTextbox);
            this.Controls.Add(this.personDataGridView);
            this.Name = "PhonebookDisplayForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn personNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personPhoneNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personBirthdayColumn;
        public System.Windows.Forms.DataGridView personDataGridView;
        private System.Windows.Forms.TextBox searchPhonebookTextbox;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.Button removePersonButton;
    }
}


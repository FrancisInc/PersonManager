namespace PersonManager
{
    partial class AddPersonForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.additionalInformationTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.nameTextBox.Location = new System.Drawing.Point(12, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(268, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "Name";
            this.nameTextBox.Enter += new System.EventHandler(this.nameTextBox_Enter);
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(12, 38);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(268, 20);
            this.phoneNumberTextBox.TabIndex = 1;
            this.phoneNumberTextBox.Text = "Phone Number";
            this.phoneNumberTextBox.Enter += new System.EventHandler(this.phoneNumberTextBox_Enter);
            this.phoneNumberTextBox.Leave += new System.EventHandler(this.phoneNumberTextBox_Leave);
            // 
            // additionalInformationTextBox
            // 
            this.additionalInformationTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.additionalInformationTextBox.Location = new System.Drawing.Point(12, 110);
            this.additionalInformationTextBox.Multiline = true;
            this.additionalInformationTextBox.Name = "additionalInformationTextBox";
            this.additionalInformationTextBox.Size = new System.Drawing.Size(268, 61);
            this.additionalInformationTextBox.TabIndex = 3;
            this.additionalInformationTextBox.Text = "Additional Information";
            this.additionalInformationTextBox.Enter += new System.EventHandler(this.additionalInformationTextBox_Enter);
            this.additionalInformationTextBox.Leave += new System.EventHandler(this.additionalInformationTextBox_Leave);
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(12, 84);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(268, 20);
            this.birthdayDateTimePicker.TabIndex = 4;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(8, 61);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(97, 21);
            this.dateOfBirthLabel.TabIndex = 5;
            this.dateOfBirthLabel.Text = "Date of Birth";
            // 
            // addPersonButton
            // 
            this.addPersonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addPersonButton.FlatAppearance.BorderSize = 0;
            this.addPersonButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.addPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPersonButton.Location = new System.Drawing.Point(12, 177);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(128, 23);
            this.addPersonButton.TabIndex = 6;
            this.addPersonButton.Text = "Add Person";
            this.addPersonButton.UseVisualStyleBackColor = false;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(146, 177);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(134, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 212);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(this.additionalInformationTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "AddPersonForm";
            this.ShowIcon = false;
            this.Text = "AddPersonForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox additionalInformationTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
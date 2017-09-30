using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonManager
{
    public partial class AddPersonForm : Form
    {
        public AddPersonForm()
        {
            InitializeComponent();
        }

        public static PhonebookDisplayForm phonebookDisplayForm;

        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Name")
            {
                nameTextBox.Text = "";
                nameTextBox.ForeColor = Color.Black;
            }
        }

        private void phoneNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (phoneNumberTextBox.Text == "Phone Number")
            {
                phoneNumberTextBox.Text = "";
                phoneNumberTextBox.ForeColor = Color.Black;
            }
        }

        private void additionalInformationTextBox_Enter(object sender, EventArgs e)
        {
            if (additionalInformationTextBox.Text == "Additional Information")
            {
                additionalInformationTextBox.Text = "";
                additionalInformationTextBox.ForeColor = Color.Black;
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                nameTextBox.Text = "Name";
                nameTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void phoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (phoneNumberTextBox.Text == "")
            {
                phoneNumberTextBox.Text = "Phone Number";
                phoneNumberTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void additionalInformationTextBox_Leave(object sender, EventArgs e)
        {
            if (additionalInformationTextBox.Text == "")
            {
                additionalInformationTextBox.Text = "Additional Information";
                additionalInformationTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            Person person = new Person()
            {
                Name = nameTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text,
                Birthday = birthdayDateTimePicker.Value,
                AdditionalInfo = additionalInformationTextBox.Text,
                ID = phonebookDisplayForm.count++
            };
            phonebookDisplayForm.phonebook.Add(person);
            phonebookDisplayForm.AddPersonToGridView(person);
        }
    }
}

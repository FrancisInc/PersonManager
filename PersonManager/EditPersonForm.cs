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
    public partial class EditPersonForm : Form
    {
        Person person;

        public EditPersonForm()
        {
            InitializeComponent();
        }

        public EditPersonForm(Person Person)
        {
            InitializeComponent();
            person = Person;
        }

        public static PhonebookDisplayForm phonebookDisplayForm;

        public void ShowForm()
        {
            Show();
            nameTextBox.Text = person.Name;
            phoneNumberTextBox.Text = person.PhoneNumber;
            birthdayDateTimePicker.Text = person.Birthday.ToString();
            additionalInformationTextBox.Text = person.AdditionalInfo;
        }

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

        private void editPersonButton_Click(object sender, EventArgs e)
        {
            var tempPerson = phonebookDisplayForm.phonebook[person.ID];
            tempPerson.Name = nameTextBox.Text;
            tempPerson.PhoneNumber = phoneNumberTextBox.Text;
            tempPerson.Birthday = birthdayDateTimePicker.Value;
            tempPerson.AdditionalInfo = additionalInformationTextBox.Text;
            phonebookDisplayForm.phonebook[person.ID] = tempPerson;
            phonebookDisplayForm.RefreshDataGridView();
        }
    }
}

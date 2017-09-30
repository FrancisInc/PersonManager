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
    public partial class PhonebookDisplayForm : Form
    {
        public List<Person> phonebook;
        public int count = 0;

        public PhonebookDisplayForm()
        {
            InitializeComponent();
            AddPersonForm.phonebookDisplayForm = this;
            EditPersonForm.phonebookDisplayForm = this;
            phonebook = new List<Person>();
        }
        
        public void AddPersonToGridView(Person person)
        {
            personDataGridView.Rows.Add(person.Name, person.PhoneNumber, person.Birthday, person.ID);
        }

        public void AddPersonToPhonebook(Person person)
        {
            phonebook.Add(person);
        }

        private void samplePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personDataGridView.Rows.Add("Menu Strip", "Sample", "<3 RH");
        }

        private void searchPhonebookTextbox_Enter(object sender, EventArgs e)
        {
            if(searchPhonebookTextbox.Text == "Search Phonebook...")
            {
                searchPhonebookTextbox.Text = "";
                searchPhonebookTextbox.ForeColor = Color.Black;
            }
        }

        private void searchPhonebookTextbox_Leave(object sender, EventArgs e)
        {
            if(searchPhonebookTextbox.Text == "")
            {
                searchPhonebookTextbox.Text = "Search Phonebook...";
                searchPhonebookTextbox.ForeColor = SystemColors.GrayText;
            }
            if (searchPhonebookTextbox.Text == "Search Phonebook...")
            {
                RefreshDataGridView();
            }
        }

        private void searchPhonebookTextbox_TextChanged(object sender, EventArgs e)
        {
            if (searchPhonebookTextbox.Text != "")
            {
                personDataGridView.Rows.Clear();
                SearchDataGridView(searchPhonebookTextbox.Text);
            }
            else
            {
                RefreshDataGridView();
            }
        }

        private void SearchDataGridView(string searchTerm)
        {
            foreach(var person in phonebook.ToList())
            {
                if(person.Name.Contains(searchTerm) || person.PhoneNumber.Contains(searchTerm) || person.Birthday.ToString().Contains(searchTerm))
                {
                    AddPersonToGridView(person);
                }
            }
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            AddPersonForm addPersonForm = new AddPersonForm();
            addPersonForm.Show();
        }

        private void removePersonButton_Click(object sender, EventArgs e)
        {
            phonebook.Remove(phonebook[personDataGridView.CurrentCell.RowIndex]);
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            personDataGridView.Rows.Clear();
            for(int i = 0; i < phonebook.Count; i++)
            {
                AddPersonToGridView(phonebook[i]);
            }
        }

        private void personDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                new EditPersonForm(phonebook[(int)personDataGridView.Rows[e.RowIndex].Cells[3].Value]).ShowForm();
            }
            catch (Exception)
            {

            }
        }
    }
}

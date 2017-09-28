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
        public PhonebookDisplayForm()
        {
            InitializeComponent();
        }

        private void newPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPersonForm addPersonForm = new AddPersonForm();
            addPersonForm.Show();
        }

        public void RefreshListView()
        {
            personListView.Items.Clear();
            foreach(var person in Phonebook.phoneBook)
            {
                personListView.Items.Add(person.ToString());
            }
        }
    }
}

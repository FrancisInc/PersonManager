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
        public List<Person> phonebook = new List<Person>();

        public PhonebookDisplayForm()
        {
            InitializeComponent();
            AddPersonForm.phonebookDisplayForm = this;
        }

        private void newPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPersonForm addPersonForm = new AddPersonForm();
            addPersonForm.Show();
        }

        public void AddPersonToGridView(Person person)
        {
            personDataGridView.Rows.Add(person.Name, person.PhoneNumber, person.Birthday);
        }

        private void samplePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personDataGridView.Rows.Add("Menu Strip", "Sample", "<3 RH");
        }
    }
}

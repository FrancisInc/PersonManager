using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManager
{
    public class Phonebook
    {
        public static List<Person> phoneBook = new List<Person>();

        public object this[int i]
        {
            get { return phoneBook[i]; }
        }

        public void AddPerson(Person person)
        {
            phoneBook.Add(person);
        }
    }
}

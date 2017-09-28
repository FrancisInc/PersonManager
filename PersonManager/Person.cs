using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManager
{
    public class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public string AdditionalInfo { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

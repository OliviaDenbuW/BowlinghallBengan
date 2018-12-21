using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    class Person
    {
        public string Name { get; set; }
        public string StreetAddress { get; set; }

        public Person(string name, string streetAddress)
        {
            Name = name;
            StreetAddress = streetAddress;
        }
    }
}

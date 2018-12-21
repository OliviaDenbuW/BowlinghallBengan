using BowlinghallBengan.Bowling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan
{
    class Program
    {
        static void Main(string[] args)
        {
            Visitor visitor = new Visitor()
            {
                FirstName = "Olivia",
                LastName = "Denbu",
                StreetAddress = "Rudsjövägen 51",
                PostalCode = "131 47"
            };

            Member newMember = visitor.BecomeMember(visitor);

            
            BowlingAlley.Instance.Welcome(newMember.FirstName);

            Console.ReadLine();
        }
    }
}

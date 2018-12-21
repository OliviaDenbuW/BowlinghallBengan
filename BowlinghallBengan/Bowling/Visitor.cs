using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    class Visitor : Person
    {
        public bool WantsMembership { get; set; }

        public Visitor(string name, string streetAddress) : base(name, streetAddress)
        {

        }

        public Member BecomeMember(Visitor currentVisitor)
        {
            string name = currentVisitor.Name;
            string streetAddress = currentVisitor.StreetAddress;

            Membership newMembership = new Membership(1, DateTime.Today);

            Member newMember = new Member(name, streetAddress, newMembership);

            return newMember;
        }
    }
}

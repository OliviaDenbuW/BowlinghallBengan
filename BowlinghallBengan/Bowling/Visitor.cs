using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    class Visitor : Person
    {
        public Member BecomeMember(Visitor currentVisitor)
        {
            string firstName = currentVisitor.FirstName;
            string lastName = currentVisitor.LastName;
            string streetAddress = currentVisitor.StreetAddress;
            string postalCode = currentVisitor.PostalCode;

            Membership newMembership = new Membership(1, DateTime.Today);

            Member newMember = new Member(firstName, lastName, streetAddress, postalCode, newMembership);

            return newMember;
        }
    }
}

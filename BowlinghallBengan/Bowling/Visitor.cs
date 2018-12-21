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
        public bool HasPayedStartFee { get; set; }

        public Visitor(string name, string streetAddress) : base(name, streetAddress)
        {

        }

        public Member BecomeMember(Visitor currentVisitor)
        {
            bool hasPayedStartFee = false;
            int memberNo = 1;
            DateTime startDateMembership = DateTime.Today;
            string name = currentVisitor.Name;
            string streetAddress = currentVisitor.StreetAddress;

            Membership newMembership = new Membership(memberNo, startDateMembership);
            Member newMember = new Member(name, streetAddress, newMembership);

            if (!hasPayedStartFee)
            {
                newMember.MakeTransaction(FeeType.StartFee);
                hasPayedStartFee = true;
                Console.WriteLine("Startavgiften har betalats!");
            }

            return newMember;
        }
    }
}

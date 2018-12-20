using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    class Membership
    {
        public Member CurrentMember { get; set; }
        public DateTime StartDate { get; set; }

        public Membership(Member currentMember, DateTime startDate)
        {
            this.CurrentMember = currentMember;
            this.StartDate = startDate;
        }
    }
}

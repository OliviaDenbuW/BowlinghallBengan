using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    class Admin : Person
    {
        public Admin(string name) : base(name)
        {

        }

        public Cup CreateCup(string name, DateTime startDate, DateTime endDate)
        {
            Cup currentCup = new Cup(name, startDate, endDate);

            return currentCup;
        }
    }
}

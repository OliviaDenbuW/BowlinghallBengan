using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinghallBengan.Bowling
{
    //SINGELTON PATTERN
    class BowlingAlley
    {
        private static BowlingAlley instance = null;

        private string Name { get; set; }

        private List<Membership> AllMemberships { get; set; }

        private BowlingAlley()
        {
            Name = "Bengans Bowlinghall";
        }

        public static BowlingAlley Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BowlingAlley();
                }
                return instance;
            }
        }

        public void Welcome(string newMember)
        {
            string message = "Välkommen " + newMember + " till " + this.Name;
            Console.WriteLine(message);
        }

        public List<Membership> GetAllMemberships()
        {
            return AllMemberships;
        }
    }
}

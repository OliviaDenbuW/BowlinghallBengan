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
            for (int i = 0; i < 11; i++)
            {
                Visitor currentVisitor = BowlingAlley.Instance.CreateVisitor("TestMember" + (i+1), "TestAddress" + (i+1), true);

                if (currentVisitor.WantsMembership)
                {
                    Member newMember = currentVisitor.BecomeMember(currentVisitor);
                    BowlingAlley.Instance.Confirmation(newMember.Name);
                }
            }

            Admin admin = new Admin("Bengan");
            Cup testCup = admin.CreateCup("TestCup", DateTime.Now, DateTime.Now.AddDays(7));

            for (int i = 0; i < 11; i++)
            {
                Member testMember = new Member("Olvia", "addess", new Membership(2, DateTime.Now));
                testCup.RegisterParticipant(testMember);
            }

            var bowlingAlley = BowlingAlley.Instance;
            for (int i = 0; i < bowlingAlley.AllMembers.Count; i++)
            {
                string name = bowlingAlley.AllMembers[i].Name;
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}

﻿using BowlinghallBengan.Bowling;
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
            BowlingAlley.Instance.Welcome("Olivia");
            Console.ReadLine();
        }
    }
}

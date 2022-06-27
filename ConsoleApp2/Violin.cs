using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Violin : Instrument
    {
        public int NumStrings { get; set; }

        public Violin(string maker, decimal price, int numStrings) : base(maker, price)
        {
        }
    }
}

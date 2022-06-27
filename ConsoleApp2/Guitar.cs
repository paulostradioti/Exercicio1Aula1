using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Guitar : Instrument
    {
        public int NumFret { get; set; }
        public int NumStrings { get; set; }

        public Guitar(string maker, decimal price, int numFret, int numStrings) : base(maker, price)
        {
        }
    }
}

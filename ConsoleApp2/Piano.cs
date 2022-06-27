using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Piano : Instrument
    {
        public string Type { get; set ; }
        public string Model { get; set ; }

        public Piano(string maker, decimal price, string type, string model ) : base(maker, price)
        {
        }
    }
}

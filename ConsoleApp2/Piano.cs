using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Piano : Instrument
    {
        public int numberOfPedals { get; set; }
        public int numberOfOctaves { get; set; }
        public bool tail { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Piano : Instrument
    {
        public int KeysCount { get; set; }
        public bool IsAcoustic { get; set; }
        public bool HasPedal { get; set; }
    }
}

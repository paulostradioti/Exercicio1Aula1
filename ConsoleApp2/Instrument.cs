using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal abstract class Instrument
    {
        public int NumStrings { get; set; }
        public decimal Price { get; set; }
        public string Maker { get; set; }
    }
}

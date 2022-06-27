using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal abstract class Instrument
    {
        public string Maker { get; set; }
        public decimal Price { get; set; }

        protected Instrument(string maker, decimal price)
        {
            Maker = maker;
            Price = price;
        }
    }
}

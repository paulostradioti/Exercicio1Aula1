using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory.Load();


            Console.WriteLine(Inventory.Count);


            Inventory.Save();
        }
    }
}

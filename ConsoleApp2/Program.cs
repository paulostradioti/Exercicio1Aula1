using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Guitar guitar = new Guitar("Fender",12000,22,6);
            Violin violin = new Violin("Stradvarius", 20000, 4);
            Piano piano = new Piano("Kawai", 25000, "Cauda", "Cauda EX");

            Inventory.Include(guitar);
            Inventory.Include(violin);
            Inventory.Include(piano);

            Console.WriteLine(Inventory.Count);

            Inventory.Save();
            Inventory.Load();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    internal static class Inventory
    {
        private static List<Instrument> inventory = new List<Instrument>();
        private static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.json");
        public static int Count { get => inventory.Count;  }

        internal static void Include(Guitar guitar)
        {
            inventory.Add(guitar);
        }

        internal static void Include(Piano piano)
        {
            inventory.Add(piano);
        }

        internal static void Save()
        {
           var content = JsonSerializer.Serialize(inventory);
            File.WriteAllText(dbPath, content);
        }

        internal static void Load()
        {
            if (!File.Exists(dbPath))
                Save();

            var content = File.ReadAllText(dbPath);
            inventory = JsonSerializer.Deserialize<List<Instrument>>(content);
        }
    }
}

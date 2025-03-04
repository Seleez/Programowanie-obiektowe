using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Wynalazki.model;

namespace Wynalazki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                BadDataFound = null,
                Delimiter = ";",
            };
            var path = "./resources/Lista wynalazków.csv";

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader,config))
            {
                var inventions = csv.GetRecords<Wynalazek>().ToList();

                Console.WriteLine(inventions.Count());
            }
        }
    }
}

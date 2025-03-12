using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Refleksja
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
    }
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwe kalsy");
            var className = Console.ReadLine();

            var classType = Type.GetType(className);
            var obj = Activator.CreateInstance(classType);

            foreach (var propety in classType.GetProperties())
            {
                Console.Write($"{propety.Name}:");
                string value = Console.ReadLine();  
                propety.SetValue( obj, Convert.ChangeType(value, propety.PropertyType), null);


            }

            foreach (var propety in classType.GetProperties())
            {
                Console.Write($"{propety.Name}: {propety.GetValue(obj)}:");
                string JSON = JsonSerializer.Serialize(obj);
                Console.WriteLine(JSON);

            }
            
        }
    }
}

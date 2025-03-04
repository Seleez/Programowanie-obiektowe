using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace JSON
{
    public class Person
    {
        public int id { get; set;}
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string ip_address { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp;
            string text = File.ReadAllText(@"Resources/Dane.json");
            var persons = JsonSerializer.Deserialize<List<Person>>(text);

            foreach (var person in persons)
            {

                //Console.WriteLine($"ID: {person.id}");
                //Console.WriteLine($"NAME: {person.first_name}");
                //Console.WriteLine($"SURENAME: {person.last_name}");
                //Console.WriteLine($"EMAIL: {person.email}");
                //Console.WriteLine($"GENDER: {person.gender}");
                //Console.WriteLine($"IP: {person.ip_address}");
                Console.WriteLine("______________________________");
                temp = JsonSerializer.Serialize(person);
                File.WriteAllText($"Dane{person.id}.txt", temp);
                Console.WriteLine("Stworzono");
            }
            //var dane1 = persons.Where(x => x.id%2 ==0);
            //    foreach (var d in dane1)
            //    {
            //        Console.WriteLine($"ID: {d.id}");
            //        Console.WriteLine($"NAME: {d.first_name}");
            //        Console.WriteLine($"SURENAME: {d.last_name}");
            //        Console.WriteLine($"EMAIL: {d.email}");
            //        Console.WriteLine($"GENDER: {d.gender}");
            //        Console.WriteLine($"IP: {d.ip_address}");
            //        Console.WriteLine("______________________________");
            //    }
            //    var dane2 = persons.Where(x => x.gender == "Male");
            //foreach (var d in dane2)
            //{
            //    Console.WriteLine($"ID: {d.id}");
            //    Console.WriteLine($"NAME: {d.first_name}");
            //    Console.WriteLine($"SURENAME: {d.last_name}");
            //    Console.WriteLine($"EMAIL: {d.email}");
            //    Console.WriteLine($"GENDER: {d.gender}");
            //    Console.WriteLine($"IP: {d.ip_address}");
            //    Console.WriteLine("______________________________");
            //}
            //var dane3 = persons.Where(x => x.id == 100);
            //foreach (var d in dane3)
            //{
            //    Console.WriteLine($"ID: {d.id}");
            //    Console.WriteLine($"NAME: {d.first_name}");
            //    Console.WriteLine($"SURENAME: {d.last_name}");
            //    Console.WriteLine($"EMAIL: {d.email}");
            //    Console.WriteLine($"GENDER: {d.gender}");
            //    Console.WriteLine($"IP: {d.ip_address}");
            //    Console.WriteLine("______________________________");
            //}
        }
    }
}

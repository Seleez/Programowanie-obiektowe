using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Warehouse<T>
    {
        private List<T> products = new List<T>();

        public void addItem(T item)
        {
            products.Add(item);
        }
        public void removeItem(T item)
        {
            products.Remove(item);
        }
        public List<T> GetAllProducts() => products;

    }
    public class Computer
    {
        public string producer { get; set; }
        public double CPU { get; set; }
        public int RAM { get; set; }
    };
        internal class Program
        {

            static void Zamien<T>(ref T a, ref T b)
            {
                T bufor = a;
                a = b;
                b = bufor;
            }
        
        static void Main(string[] args)
        {
            //double liczba1 = 10, liczba2 = 20;
            //Console.WriteLine($"{liczba1}\t{liczba2}");
            //Zamien(ref liczba1 , ref liczba2); 
            //Console.WriteLine($"{liczba1}\t{liczba2}");

            //bool l1 = true, l2 = false;
            //Console.WriteLine($"{l1}\t{l2}");
            //Zamien(ref l1, ref l2);
            //Console.WriteLine($"{l1}\t{l2}");

            var warehouse = new Warehouse<Computer>();

            warehouse.addItem(new Computer
            {
                producer = "Dell",
                CPU = 4.5,
                RAM = 32
            });
            warehouse.addItem(new Computer
            {
                producer = "Hp",
                CPU = 3.0,
                RAM = 20
            });
            warehouse.addItem(new Computer
            {
                producer = "GG",
                CPU = 4.5,
                RAM = 32
            });

            foreach (var computer in warehouse.GetAllProducts())
            {
                Console.WriteLine($"Producer: {computer.producer}");
                Console.WriteLine($"CPU: {computer.CPU}");
                Console.WriteLine($"RAM: {computer.RAM}");
            }

        }
    }
}

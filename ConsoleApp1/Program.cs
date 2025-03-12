using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{   
    public interface IProducts
    {
        //string Name { get; set; }
        //decimal Price { get; set; }

        void DisplayInfo();
    }
    public class Warehouse<T>
    {
        private List<T> products = new List<T>();

        public void addItem(T item)
        {
            products.Add(item);
        }
        public void removeItem(int id)
        {
            products.RemoveAt(id);
        }
        public List<T> GetAllProducts() => products;

    }
    public class Computer : IProducts
    {
        public string producer { get; set; }
        public double CPU { get; set; }
        public int RAM { get; set; }
    };

    public class Electronics : IProducts
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int WarrantyMonths { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Nazwa: {this.Name} Cena: {this.Price} Gwarancja: {this.WarrantyMonths}");
        }
    }

    public class Furniture : IProducts
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Material { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Nazwa: {this.Name} Cena: {this.Price} materiał: {this.Material}");
        }
    }
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

            var warehouse = new Warehouse<IProducts>();

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
            warehouse.addItem(new Electronics
            {
                Name = "Czajnik",
                Price = 150,
                WarrantyMonths = 24
            });
            warehouse.addItem(new Electronics
            {
                Name = "Żelazko",
                Price = 300,
                WarrantyMonths = 36
            });
            warehouse.addItem(new Electronics
            {
                Name = "Blender",
                Price = 100,
                WarrantyMonths = 6
            });
            warehouse.addItem(new Furniture
            {
                Name = "Stół",
                Price = 1000,
                Material = "drewno"
            });
            warehouse.addItem(new Furniture
            {
                Name = "Sofa",
                Price = 2500,
                Material = "drewno, materiał"
            });
            warehouse.addItem(new Furniture
            {
                Name = "krzesło",
                Price = 100,
                Material = "drewno"
            });
            foreach (var product in warehouse.GetAllProducts())
            {
                if(product is Computer)
                {
                    var computer = product as Computer;
                    Console.WriteLine($"Producer: {computer.producer}");
                    Console.WriteLine($"CPU: {computer.CPU}");
                    Console.WriteLine($"RAM: {computer.RAM}");
                }
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    class Vehicle
    {
        public string Name { get; set; }

        public void setName(string name)
        {
            Name = name;
        }
        public virtual void Description()
        {
            Console.WriteLine($"To jest pojazd o imieniu: {Name}");
        }
    }

    class Car : Vehicle
    {
        public override void Description()
        {
            Console.WriteLine($"Samochód osobowy o nazwie {Name}");
        }
    }

    class Truck : Vehicle
    {
        public override void Description()
        {
            Console.WriteLine($"Ciężarówka o nazwie {Name}, przeznaczona do transportu.");
        }
    }

    class Bicycle : Vehicle
    {
        public override void Description()
        {
            Console.WriteLine($"Rower o nazwie {Name}, ekologiczny środek transportu.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var listaPojazdów = new List<Vehicle>
            {
                new Car {Name="Auto"},
                new Truck {Name = "Cienżarówka"},
                new Bicycle {Name ="Rower"}
            };

            foreach(Vehicle vehicle in listaPojazdów)
            {
                vehicle.Description();
            }
        }
    }
}

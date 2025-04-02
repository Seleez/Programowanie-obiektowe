using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Posrednik
{

    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Engine { get; set; }
        public string Power { get; set; }

        public Car(int id, string brand, string model, int year, string engine, string power)
        {
            this.Id = id;
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Engine = engine;
            this.Power = power;
        }

    }
    public interface IDatabase
    {
        Car GetCarById(int id);
        List<Car> GetAll();
        void Create(int id, string brand, string model, int year, string engine, string power);
        void Delete(int id);

    }
    public class RealDatabase: IDatabase
    {
       List<Car> cars = new List<Car> { 
            new Car(1, "BMW", "A1", 2020, "V16", "1200HP"),
            new Car(2, "toyota", "yaris", 2013, "V16", "600HP"),
            new Car(3, "Audi", "X69", 1969, "V69", "6969HP"),
            new Car(4, "BMW", "A2137", 2137, "V2137", "21137HP"),
       };

        Car GetCarById(int id)
        {
            return cars[id];
        }
        List<Car> GetAll()
        {
            return cars;
        }
        void Create(int id, string brand, string model, int year, string engine, string power)
        {
            var auto = new Car(id, brand, model, year, engine, power);
            cars.Add(auto);
        }
        void Delete(int id) { 
            cars.RemoveAt(id);
        }

    }

    public class DatabaseProxy
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

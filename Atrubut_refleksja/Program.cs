using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Atrubut_refleksja
{
    internal class Program
    {
        class Car
        {
            [DisplayPropName("Marka pozajdu", Order = 1)]
            public string Brand { get; set; }
            [DisplayPropName("Model pozajdu")]
            public string Model { get; set; }
            [DisplayPropName("pojemność silnika")]
            public int EngineCapacity { get; set; }

        }
        public class DisplayPropNameAttribute: Attribute {
            public string DisplayName { get; set; }
            public int Order { get; set; }
            public DisplayPropNameAttribute(string displayName)
            {
                DisplayName = displayName;
            }
        }
        static void Main(string[] args)
        {
            var car = new Car
            {
                Brand = "Toyota",
                Model = "Yaris",
                EngineCapacity = 1
            };

            Console.WriteLine($"{DisplayNameFor<Car>(nameof(car.Brand))} = {car.Brand}");
            Console.WriteLine($"{DisplayNameFor<Car>(nameof(car.Model))} = {car.Model}");
            Console.WriteLine($"{DisplayNameFor<Car>(nameof(car.EngineCapacity))} = {car.EngineCapacity}");
        }

        private static string DisplayNameFor<T>(string propertyName)
        {
            var type = typeof(T);
            var property = type.GetProperty(propertyName);
            if (property != null)
            {
                var attribute = property.GetCustomAttribute<DisplayPropNameAttribute>();
                if (attribute != null)
                {
                    return attribute.DisplayName;
                }
            }
            return propertyName;
        }
    }
}

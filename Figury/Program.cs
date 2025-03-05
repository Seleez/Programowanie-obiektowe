using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Figury{
    interface IDisplay{
        void Display();
    }
    abstract class Figury : IDisplay
    {
        public abstract double Area();
        public abstract double Volume();

        public void Display()
        {
            Console.WriteLine("Pole: " + Area());
            Console.WriteLine("Objętość: " + Volume());
            Console.WriteLine("___________________________________");
        }
    }
    class Cuboid : Figury
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Cuboid(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area()
        {
            return 2 * (a + b) + 2 * (a * c) + 2 * (b * c);
        }
        public override double Volume()
        {
            return a * b * c;
        }
        public new void Display()
        {
            Console.WriteLine($"a: {a} b: {b} c: {c}");
            base.Display();
            
        }
    }
    class Cone : Figury
    {
        public double r { get; set; }
        public double h { get; set; }
        public double l { get; set; }
        public Cone(double r, double h, double l)
        {
            this.r = r;
            this.h = h;
            this.l = l;
        }

        public override double Area()
        {
            return (Math.PI * (r * r) * h) / 3;
        }
        public override double Volume()
        {
            return (Math.PI * r) * (r + l);
        }
        public new void Display()
        {
            Console.WriteLine($"Radius: {this.r} Height: {this.h} Length: {this.l}");
            base.Display();
        }
    }

    class Cilinder : Figury
    {
        public double r { get; set; }
        public double h { get; set; }
        

        public Cilinder(double r, double h)
        {
            this.r = r;
            this.h = h;
        }

        public override double Area()
        {
            return 2 * (Math.PI * (r * r)) + 2 * (Math.PI * r * h);
        }
        public override double Volume()
        {
            return (Math.PI * (r * r)) * h;
        }
        public new void Display()
        {

            Console.WriteLine($"Radius: {r} Height: {h}");
            base.Display();
        }
    }

    class Sphere : Figury
    {
        public double r { get; set; }

        public Sphere(double r)
        {
            this.r = r;
        }

        public override double Area()
        {
            return 4 * (Math.PI * (r * r));
        }
        public override double Volume()
        {
            return (4 * (Math.PI * (r * r * r))) / 3;
        }

        public new void Display()
        {
            Console.WriteLine($"Radius: {r}");
            base.Display();
            
        }
    }

    internal class Program{
        static void Main(string[] args){
            Cuboid figura1 = new Cuboid(2, 2, 2);
            figura1.Display();
            Cone figura2 = new Cone(2, 2, 2);
            figura2.Display();
            Cilinder figura3 = new Cilinder(2, 2);
            figura3.Display();
            Sphere figura4 = new Sphere(2);
            figura4.Display();
        }
    }
}

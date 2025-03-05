using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program{

        static void Zamien<T>(ref T a, ref T b)
        {
            T bufor = a;
            a = b;
            b = bufor;
        }
  
        static void Main(string[] args)
        {
            double liczba1 = 10, liczba2 = 20;
            Console.WriteLine($"{liczba1}\t{liczba2}");
            Zamien(ref liczba1 , ref liczba2); 
            Console.WriteLine($"{liczba1}\t{liczba2}");

            bool l1 = true, l2 = false;
            Console.WriteLine($"{l1}\t{l2}");
            Zamien(ref l1, ref l2);
            Console.WriteLine($"{l1}\t{l2}");

        }
    }
}

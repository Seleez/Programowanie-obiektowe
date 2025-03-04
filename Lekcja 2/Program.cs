
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;



/*
double a, b;


Console.WriteLine("Podaj a: ");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Podaj b: ");
b = double.Parse(Console.ReadLine());


if(a < 0 && b < 0){
    Console.WriteLine("Funkcja przechodzi prez ćwiartki nr II, III, IV");
}else if(a > 0 && b < 0){
    Console.WriteLine("Funkcja przechodzi prez ćwiartki nr I, III, IV");
}else if (a == 0 && b < 0){
    Console.WriteLine("Funkcja przechodzi prez ćwiartki nr III, IV");
}else if (a < 0 && b == 0){
    Console.WriteLine("Funkcja przechodzi prez ćwiartki nr I, III");
}else if (a > 0 && b > 0){
    Console.WriteLine("Funkcja przechodzi prez ćwiartki nr I, II, III");
}else if(a < 0 && b > 0){
    Console.WriteLine("Funkcja przechodzi prez ćwiartki nr I, II, IV");
}else if (a == 0 && b > 0){
    Console.WriteLine("Funkcja przechodzi prez ćwiartki nr I, II");
}else if (a == 0 && b == 0){
    Console.WriteLine("Funkcja nieprzechodzi prez ćwiartki");
}
*/


/*char litera;
try{
    Console.WriteLine("Podaj literę: ");

    litera = char.Parse(Console.ReadLine().ToLower());
}catch (FormatException exception){
    Console.WriteLine("Wpisałeś Zadużo znaków");
    Console.WriteLine("Twój Komputer ulegnie samozniszczeniu");
    Console.WriteLine("Bajo");
    return;
}


if (!char.IsLetter(litera)){
    throw new ArgumentOutOfRangeException("To Nie Jest Litera");
}

switch (litera){
    case 'a':
    case 'ą':
    case 'e':
    case 'ę':
    case 'o':
    case 'ó':
    case 'i':
    case 'u':
    case 'y':
        Console.WriteLine($"Litera {litera}  jest samogłoską");
        break;
    default: 
        Console.WriteLine($"Litera {litera}  jest samogłoską");
        break;
}

enum Planety { Merkury, Wenus, Ziemia, Mars}
*/
/*
static void Rand(out int suma, out int max, out int min){
    suma = 0;
    max = 0;
    min = 51;
    while (true){
        var random = new Random();
        var a = random.Next(0, 50);
        if (a == 0)
        {
            return;
        }
        else if (a % 2 == 0)
        {
            suma += a;
            if (a > max)
            {
                max = a;
            }
            if (a < min)
            {
                min = a;
            }
        }
        //Console.WriteLine($"Liczba = {a} Suma = {suma} min = {min} max = {max}");
    }
}
Rand(out int suma, out int max,out int min);
Console.WriteLine($"Suma = {suma} Min = {min} Max = {max} ");*/

/*static void Gierka()
{
    var random = new Random();
    var szukana = random.Next(0, 100);
    //Console.WriteLine(szukana);
    var podana = 101;
    var koniec = false;
    var ile = 0;
    while(koniec != true)
    {
        Console.WriteLine("Podaj liczbe:");
        podana = int.Parse(Console.ReadLine());
        if(podana > szukana)
        {
            Console.WriteLine("Ta liczba jest większa");
        }else if (podana < szukana)
        {
            Console.WriteLine("Ta liczba jest mniejsza");
        }else if (podana == szukana)
        {
            Console.WriteLine($"Zgadłeś trwało to {ile} rund ");
            koniec = true;
        }
        ile++;
    }
}

Gierka();*/


internal class Program
{
    /*enum Order
    {
        Desc,
        Asc
    }
    public static void swap(ref int x, ref int y) {
        var temp = 0;
        temp = x;
        x = y;
        y = temp;
    }
    static void Sortuje(ref int a, ref int b, ref int c, Order order)
    {
        if (order == Order.Asc)
        {
            if (a > b)
            {
                swap(ref a, ref b);
            }
            if (b > c)
            {
                swap(ref b, ref c);
            }
            if (a > b)
            {
                swap(ref a, ref b);
            }
        }
        else if (order == Order.Desc)
        {
            if (a < b)
            {
                swap(ref a, ref b);
            }
            if (b < c)
            {
                swap(ref b, ref c);
            }
            if (a < b)
            {
                swap(ref a, ref b);
            }
        }
        Console.WriteLine($"{a}, {b}, {c}");

    }

//NApisz funkcje która działą w sposób następujący:;
//  jeśli x < 0 to return x ^2;
//  jeśli x = 0 to return 3;
//  jeśli x > 0 to return 2 ^x;


static double funkcja(double x){
    double wynik = 0;

    if(x < 0)
    {
        wynik = Math.Pow(x,2);
    }else if(x == 0)
    {
        wynik = 3;
    }else if(x > 0)
    {
        wynik = Math.Pow(2,x);
    }
    return wynik;
}*/



    static double Linear(double x)
    {
        return 2 * x + 3;
    }

    static double Squere(double x) => x * x;

    static double ParabolidFunc(double x, double y) => Squere(x) * Squere(y);

    static void Welcome(string[] name)
    {
        Console.WriteLine($"Hello {name}!");
    }

    static double Funkcja(double x)
    {
        double wynik = 0;
        if (x > 10)
        {
            wynik = Math.Sqrt(x +10);
        }else if(5 < x && x <= 10)
        {
            wynik = Math.Pow(2,x);
        }else if(x <= 5)
        {
            wynik = Math.Pow(x, 3);
        }
        return  wynik;
    }

    public static void zamien(ref double x, ref double y) {
        var temp = x;
        x = y; 
        y = temp;    
    }

    static void Sort(ref double a, ref double b, ref double c,ref double d)
    {
        for(int i = 0; i < 4; i++) { 
            if(a > b)
            {
                zamien(ref a, ref b);
            }
            if(b > c) { 
                zamien(ref b, ref c);
            }

            if(c > d) { 
                zamien(ref c, ref d);
            }
            Console.WriteLine($"{a}, {b}, {c}, {d}");
        }
    }

    static int Silnia(int n){
        if(n == 0)
        {
            return 1;
        }
        else
        {
            return Silnia(n - 1) * n;
        }
    }


    static double Sinus(double x, int n)
    {
        double wynik = 0;
        int znak = 1;
        
        for(int i = 1, potenga = 1; i < n ; i++, potenga+=2)
        {
            
            wynik += znak * Math.Pow(x, potenga) / Silnia(potenga);
            znak *= -1;
        }
        return wynik;
    }

    static double Cosinus(double x, int n)
    {
        double wynik = 0;
        int znak = 1;

        for (int i = 1, potenga = 0; i < n; i++, potenga += 2)
        {

            wynik += znak * Math.Pow(x, potenga) / Silnia(potenga);
            znak *= -1;
        }
        return wynik;
    }

    public static int[] generateArray(int n){
        
        int[] array = new int[n];
        Random rand = new Random();
        for (int i = 0; i < n; i++){

            array[i] = rand.Next(1, 11);
        }
        return array;
    }

    public static void showArray(int[] array){
        
        for(int i = 0; i < array.Length; i++){
            Console.Write($"{array[i]}, ");
        }
        Console.WriteLine(" ");
    }

    public static int[] sumOfArrays(int[] arr1, int[] arr2){
        
        if ( arr1.Length != arr2.Length){
            throw new ArgumentException("Podaj tablice o tej samej długości");
        }
        int[] arr3 = new int[arr1.Length];

        for (int i = 0;i < arr1.Length; i++){
           arr3[i] = arr1[i] + arr2[i];
        }
        return arr3;
    }

    public static int multiplyArrays(int[] arr1, int[] arr2){
        

        if (arr1.Length != arr2.Length){
            throw new ArgumentException("Podaj tablice o tej samej długości");
        }
        int suma = 0;
        for(int i = 0; i<arr1.Length; i++){
           suma += arr1[i] * arr2[i];
        }         
        return suma;

    }

    public static int Max(int[] arr){
        int max = arr[0];
        for(int i = 0; i < arr.Length; i++){
            if (arr[i] > max){
                max = arr[i];
            }
        }
        return max;
    }

    public class hotel{
        [Index(0)]
        public int Id { get; set; }
        [Index(1)]
        public string name { get; set; }
        [Index(2)]
        public string email { get; set; }
        [Index(3)]
        public string allYear { get; set; }
        [Index(4)]
        public string stars { get; set; }
        [Index(5)]
        public string type { get; set; }
        [Index(6)]
        public string adres { get; set; }
        [Index(7)]




    }


    static void Main(string[] args){
        /*var a = 1;
        var b = 2;
        var c = 3;

        //Sortuje(ref a, ref b, ref c, Order.Desc);

        Console.WriteLine(funkcja(-3));
        Console.WriteLine(funkcja(0));
        Console.WriteLine(funkcja(5));*/

        /*        Console.WriteLine(Linear(2));
                Console.WriteLine(Squere(2));
                Console.WriteLine(ParabolidFunc(2,3));

                Console.WriteLine(Funkcja(11));
                Console.WriteLine(Funkcja(6));
                Console.WriteLine(Funkcja(5));

                double a = 4;
                double b = 3;
                double c = 2;
                double d = 1;
                Sort(ref a, ref b, ref c, ref d);
                double x = 5;
                Console.WriteLine(Silnia(15));
                */


        /*Console.WriteLine("Podaj ilość do zsumowania");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Sinus(Math.PI / 6,n));
        Console.WriteLine(Math.Sin(Math.PI / 6));
        Console.WriteLine(Cosinus(Math.PI / 6, n));
        Console.WriteLine(Math.Cos(Math.PI / 6));*/

        //Console.WriteLine(Silnia(10));

        /*napis funkcjegenerującą tablice n elementową z liczbami z przedziału 1 - 10*/


        // napisz funkcje która wyświetli elementy przesłanej tablicy jedno wymiarowej

        /*generateArray(10);

        showArray(generateArray(10));*/

        /*        int[] arr1 = generateArray(10);
                int[] arr2 = generateArray(10);

                Console.WriteLine(Max(arr1));

                showArray(arr1);
                showArray(arr2);
                sumOfArrays(arr1, arr2);
                showArray(sumOfArrays(generateArray(10), generateArray(10)));
                Console.WriteLine(multiplyArrays(generateArray(10), generateArray(10)));
        */

        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = false,
            Delimiter = ";",
        };
        using (var reader = new StreamReader("C:\\Users\\Dell\\Downloads\\hotele.csv"))
        using (var csv = new CsvReader(reader, config))
        {
            var records = csv.GetRecords<hotel>();
            Console.WriteLine(records.Count());
        }
        





    }
    

}

using System;

Console.WriteLine("<========================================>");
Console.WriteLine("Imie i Nazwisko: Bartłomiej Czerenk");
Console.WriteLine("Miejscowość: Bielsko - Biała");
Console.WriteLine("Wiek: 17 Lat");
Console.WriteLine("Szkoła: ZSEEIM");
Console.WriteLine("<========================================>");

//<=========================Zmienne===================>


//Byte
byte liczba = 1;
Console.WriteLine("<============BYTE==========>");
Console.WriteLine(byte.MinValue);
Console.WriteLine(byte.MaxValue);
Console.WriteLine(byte.Parse("123"));
Console.WriteLine(byte.IsEvenInteger(2));
Console.WriteLine(byte.IsOddInteger(2));
Console.WriteLine(byte.Min(4, 1));



Console.WriteLine("<============SHORT==========>");
Console.WriteLine(short.MinValue);
Console.WriteLine(short.MaxValue);
Console.WriteLine(short.Parse("123"));
Console.WriteLine(short.IsEvenInteger(2));
Console.WriteLine(short.IsOddInteger(2));
Console.WriteLine(short.Min(4, 1));

Console.WriteLine("<============INT==========>");
Console.WriteLine(int.MinValue);
Console.WriteLine(int.MaxValue);
Console.WriteLine(int.Parse("123"));
Console.WriteLine(int.IsEvenInteger(2));
Console.WriteLine(int.IsOddInteger(2));
Console.WriteLine(int.Min(4, 1));


Console.WriteLine("<============LONG==========>");
Console.WriteLine(long.MinValue);
Console.WriteLine(long.MaxValue);
Console.WriteLine(long.Parse("123"));
Console.WriteLine(long.IsEvenInteger(2));
Console.WriteLine(long.IsOddInteger(2));
Console.WriteLine(long.Min(4, 1));

Console.WriteLine("<============LONG==========>");
Console.WriteLine(nint.MinValue);
Console.WriteLine(nint.MaxValue);
Console.WriteLine(nint.Parse("123"));
Console.WriteLine(nint.IsEvenInteger(2));
Console.WriteLine(nint.IsOddInteger(2));
Console.WriteLine(nint.Min(4, 1));


Console.WriteLine("<============FLOAT==========>");
Console.WriteLine(float.MinValue);
Console.WriteLine(float.MaxValue);
Console.WriteLine(float.Parse("123"));
Console.WriteLine(float.IsEvenInteger(2));
Console.WriteLine(float.IsOddInteger(2));
Console.WriteLine(float.Min(4, 1));

Console.WriteLine("<============Double==========>");
Console.WriteLine(double.MinValue);
Console.WriteLine(double.MaxValue);
Console.WriteLine(double.Parse("123"));
Console.WriteLine(double.IsEvenInteger(2));
Console.WriteLine(double.IsOddInteger(2));
Console.WriteLine(double.Min(4, 1));


Console.WriteLine("<============DECIMAL==========>");
Console.WriteLine(decimal.MinValue);
Console.WriteLine(decimal.MaxValue);
Console.WriteLine(decimal.Parse("123"));
Console.WriteLine(decimal.IsEvenInteger(2));
Console.WriteLine(decimal.IsOddInteger(2));
Console.WriteLine(decimal.Min(4, 1));




STRING PATH @"C:/.../....";


Console.WriteLine("Podaj Dzień dla daty 1: ");
int day1 = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj Miesiąc dla daty 1: ");
int month1 = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj Rok dla daty 1: ");
int year1 = int.Parse(Console.ReadLine());





Console.WriteLine("Podaj Dzień dla daty 2: ");
int day2 = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj Miesiąc dla daty 2: ");
int month2 = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj Rok dla daty 2: ");
int year2 = int.Parse(Console.ReadLine());



if (year1 < year2)
{
    Console.WriteLine("Data 2 jest starsza");
}
else if (year1 > year2)
{
    Console.WriteLine("Data 1 jest starsza");
}
else if (year1 == year2)
{
    if (month1 > month2)
    {
        Console.WriteLine("Data 1 jest starsza");
    }
    else if (month1 < month2)
    {
        Console.WriteLine("Data 2 jest starsza");
    }
    else if (month1 == month2)
    {
        Console.WriteLine("");
    }
}
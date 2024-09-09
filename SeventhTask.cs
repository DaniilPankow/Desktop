//Task 7 complete:
using System;
class Program
{   
    static void Main()
    {
        Console.Write("Введіть температуру в градусах Цельсія: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"Температура в градусах Фаренгейта: {fahrenheit}");
    }
}
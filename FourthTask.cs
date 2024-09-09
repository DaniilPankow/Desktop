// See https://aka.ms/new-console-template for more information
using System;
class Program
{   static void Main()
    {
        Console.Write("Введіть перше число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введіть третє число: ");
        int c = int.Parse(Console.ReadLine());

        int max = Math.Max(Math.Max(a, b), c);
        int min = Math.Min(Math.Min(a, b), c);

        Console.WriteLine($"Максимальне значення: {max}");
        Console.WriteLine($"Мінімальне значення: {min}");
    }
}
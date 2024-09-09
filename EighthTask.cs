//Task 8 complete:
using System;
class Program
{   
    static void Main()
    {
        Console.Write("Введіть число n (кількість натуральних чисел): ");
        int n = int.Parse(Console.ReadLine());

        int sum = (n * (n + 1)) / 2;

        Console.WriteLine($"Сума перших {n} натуральних чисел: {sum}");
    }
}
//Task 5 complete:
using System;
class Program
{   
    static void Main()
    {
        Console.Write("Введіть довжину прямокутника: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Введіть ширину прямокутника: ");
        double width = double.Parse(Console.ReadLine());

        double area = length * width;

        Console.WriteLine($"Площа прямокутника: {area}");
    }
}
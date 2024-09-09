//Task 3 complete:
using System;
    class Program
{   
    static void Main()
    {
        Console.Write("Введіть годину (0-23): ");
        int h = int.Parse(Console.ReadLine());

        if (h >= 5 && h < 12)
        {
            Console.WriteLine("Доброго ранку!");
        }
        else if (h >= 12 && h < 18)
        {
            Console.WriteLine("Добрий день!");
        }
        else if (h >= 18 && h < 22)
        {
            Console.WriteLine("Добрий вечір!");
        }
        else if ((h >= 22 && h < 24) || (h >= 0 && h < 5))
        {
            Console.WriteLine("Доброї ночі!");
        }
        else
        {
            Console.WriteLine("Введено некоректне значення години.");
        }
    }
}
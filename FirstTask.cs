//Task 1 complete:
using System;
class Program
{
    static void Main()
    {
        Console.Write("Введіть перше число (можливий день): ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Введіть друге число (можливий місяць): ");
        int number2 = int.Parse(Console.ReadLine());

        bool isDay = number1 >= 1 && number1 <= 31;    
        bool isMonth = number2 >= 1 && number2 <= 12;  

        if (isDay && isMonth)
        {
            Console.WriteLine("Числа можуть бути днем та місяцем.");
        }
        else
        {
            Console.WriteLine("Числа не можуть бути днем та місяцем.");
        }
    }
}
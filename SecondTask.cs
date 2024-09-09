//Task 2 complete:
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть дійсне число: ");
        double number = double.Parse(Console.ReadLine());

        double fractionalPart = number * 100; 
        int digits = (int)(fractionalPart % 100);

        int firstDigit = digits / 10;
        int secondDigit = digits % 10;

        Console.WriteLine($"{firstDigit} + {secondDigit} = {firstDigit + secondDigit}");
    }
}

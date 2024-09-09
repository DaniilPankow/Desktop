//Task 6 complete:
using System;
class Program
{
     static void Main()
    {
        Console.Write("Введіть ціле число: ");
        int number = int.Parse(Console.ReadLine());

        string result = (number % 2 == 0) ? "Число є парним." : "Число є непарним.";

        Console.WriteLine(result);
    }
}
using System;

namespace MultiplicationTables
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number that you want and this console app will generate the times table until 12.");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            GenerateTimesTable(inputNumber);
            Console.ReadLine();
        }

        private static void GenerateTimesTable(int number)
        {
            Console.WriteLine($"{number} * 1 = {number * 1}");
            Console.WriteLine($"{number} * 2 = {number * 2}");
            Console.WriteLine($"{number} * 3 = {number * 3}");
            Console.WriteLine($"{number} * 4 = {number * 4}");
            Console.WriteLine($"{number} * 5 = {number * 5}");
            Console.WriteLine($"{number} * 6 = {number * 6}");
            Console.WriteLine($"{number} * 7 = {number * 7}");
            Console.WriteLine($"{number} * 8 = {number * 8}");
            Console.WriteLine($"{number} * 9 = {number * 9}");
            Console.WriteLine($"{number} * 10 = {number * 10}");
            Console.WriteLine($"{number} * 11 = {number * 11}");
            Console.WriteLine($"{number} * 12 = {number * 12}");
        }

    }
}

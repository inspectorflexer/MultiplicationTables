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
            Console.WriteLine("These your generated times table!!!");
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }

    }
}

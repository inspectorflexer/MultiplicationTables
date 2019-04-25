using System;

namespace MultiplicationTables
{
    internal static class Program
    {
        private static int? _multiplyNumber;
        private static int? _numberOfSets;

        private static void Main(string[] args)
        {
            do
            {
                Console.WriteLine(
                    "Please enter the number that you want and this console app will generate the times table until a given point");
                _multiplyNumber = Console.ReadLine().ValidateNumber();
            } while (_multiplyNumber == null);

            do
            {
                Console.WriteLine("Please enter the number of sets you'd like to go up to");
                _numberOfSets = Console.ReadLine().ValidateNumber();
            } while (_numberOfSets == null);

            GenerateTimesTable((int)_multiplyNumber, (int)_numberOfSets);

            Console.ReadLine();
        }

        private static void GenerateTimesTable(int multiplyNumber, int numberOfSets)
        {
            Console.WriteLine("These your generated times table!!!");
            for (int i = 0; i <= numberOfSets; i++)
            {
                Console.WriteLine($"{multiplyNumber} * {i} = {multiplyNumber * i}");
            }
        }

        public static int? ValidateNumber(this string str)
        {
            bool success = int.TryParse(str, out int number);
            if (success)
                return number;

            Console.WriteLine("Valid number not provided");
            return null;
        }

    }
}

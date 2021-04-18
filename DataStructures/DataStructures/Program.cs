using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("Choose your data structure by typing the corresponding number: \n");
            Console.WriteLine("1 - Stack");
            Console.WriteLine("2 - Queue");
            bool isValidOption = int.TryParse(Console.ReadLine(), out result);

            if (isValidOption)
            {
                var exec = new StrategyRouter(result);
                Console.WriteLine("Please, type a word:\n");
                exec.ExecuteStructureType(Console.ReadLine());
            }
        }
    }
}
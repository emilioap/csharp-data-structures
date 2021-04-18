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
            Console.WriteLine("2- Queue");
            bool validOption = int.TryParse(Console.ReadLine(), out result);

            if (validOption)
            {
                var exec = new StrategyRouter(result);
                exec.ExecuteStructureType();
            }
        }
    }
}
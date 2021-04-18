using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class StrategyRouter
    {
        private readonly Dictionary<DataStructureEnum, Func<bool>> _dataStruct;
        private readonly int _result;

        public StrategyRouter(int result)
        {
            _result = result;
            _dataStruct = new Dictionary<DataStructureEnum, Func<bool>>();
            _dataStruct.Add(DataStructureEnum.Stack, StackFunc);
            _dataStruct.Add(DataStructureEnum.Queue, QueueFunc);
        }

        public bool ExecuteStructureType()
        {
            return _dataStruct[(DataStructureEnum)_result].Invoke();
        }

        private readonly Func<bool> StackFunc = () =>
        {
            char ch;
            bool isPalindrome = false;
            int position = 0;
            Stack stack = new Stack(-1, new List<char>(), 100);

            Console.WriteLine("Please, type a word:\n");
            string word = Console.ReadLine();

            Console.WriteLine("\nAdding letters...\n");

            for (int i = 0; i < word.Length; i++)
            {
                stack.push(word.Substring(i, 1)[0]);
                stack.print();
            }

            Console.WriteLine("\nRemoving letters...\n");

            while (!stack.isEmpty())
            {
                ch = stack.pop();

                if (position < word.Length)
                    isPalindrome = stack.isPalindrome(ch, word, position);

                stack.print();
                position++;
            }

            Console.WriteLine($"\nThe word {word} is {(isPalindrome == true ? "palindrome" : "not palindrome")} !");
            return true;
        };

        private readonly Func<bool> QueueFunc = () =>
        {
            return true;
        };
    }
}

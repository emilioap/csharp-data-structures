using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class StrategyRouter
    {
        private readonly Dictionary<DataStructureEnum, Func<string, bool>> _dataStruct;
        private readonly int _result;

        public StrategyRouter(int result)
        {
            _result = result;
            _dataStruct = new Dictionary<DataStructureEnum, Func<string, bool>>();
            _dataStruct.Add(DataStructureEnum.Stack, StackFunc);
            _dataStruct.Add(DataStructureEnum.Queue, QueueFunc);
        }

        public bool ExecuteStructureType(string word)
        {
            return _dataStruct[(DataStructureEnum)_result].Invoke(word);
        }

        private readonly Func<string, bool> StackFunc = (string word) =>
        {
            int position = 0;
            bool isPalindrome = false;
            Stack stack = new Stack(-1, new List<char>(), 100);

            Console.WriteLine("\nAdding letters...\n");
            for (int i = 0; i < word.Length; i++)
            {
                if(!stack.isFull())
                    stack.push(word.Substring(i, 1)[0]);

                stack.print();
            }

            Console.WriteLine("\nRemoving letters...\n");
            while (!stack.isEmpty())
            {
                isPalindrome = stack.isPalindrome(stack.pop(), word, position);
                position++;
                stack.print();
            }

            Console.WriteLine($"\nThe word {word} is {(isPalindrome != true ? "not palindrome" : "palindrome")}!");
            return true;
        };

        private readonly Func<string, bool> QueueFunc = (string word) =>
        {
            QueueStruct.QueueStruct queue = new QueueStruct.QueueStruct(0, 100);

            Console.WriteLine("\nAdding letters...\n");
            for (int i = 0; i < word.Length; i++)
            {
                if (!queue.isFull())
                    queue.enqueue(word.Substring(i, 1)[0]);

                queue.print();
            }

            Console.WriteLine("\nRemoving letters...\n");
            while (!queue.isEmpty())
            {
                queue.dequeue();

                if(!queue.isEmpty())
                    queue.print();
            }

            Console.WriteLine("\nEnd of program");
            return true;
        };
    }
}

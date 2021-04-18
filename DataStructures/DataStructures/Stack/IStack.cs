using System.Collections.Generic;

namespace DataStructures
{
    public interface IStack
    {
        int Length { get; set; }
        List<char> Structure { get; set; }
        int MaxItems { get; set; }
        bool isEmpty();
        bool isFull();
        void push(char item);
        char pop();
        void print();
        bool isPalindrome(char ch, string word, int position);
    }
}

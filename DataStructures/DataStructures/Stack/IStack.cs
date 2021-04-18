using System.Collections.Generic;

namespace DataStructures
{
    public interface IStack
    {
        int Length { get; set; }
        List<char> Structure { get; set; }
        int MaxItems { get; set; }
        void push(char item);
        char pop();
        bool isEmpty();
        bool isFull();
        void print();
        bool isPalindrome(char ch, string word, int position);
    }
}

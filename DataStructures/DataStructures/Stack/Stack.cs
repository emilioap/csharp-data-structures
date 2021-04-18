using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Stack : IStack
    {
        public Stack(int length, List<char> structure, int maxItems)
        {
            _length = length;
            _structure = structure;
            _maxItems = maxItems;
        }

        private int _length { get; set; }
        
        private List<char> _structure { get; set; }

        private int _maxItems { get; set; }

        public int Length {
            get {return _length; }
            set { _length = value; }
        }

        public List<char> Structure {
            get { return _structure; }
            set { _structure = value; }
        }

        public int MaxItems
        {
            get { return _maxItems; }
            set { _maxItems = value; }
        }

        public bool isEmpty()
        {
            return _length == 0;
        }

        public bool isFull()
        {
            return Length == _maxItems;
        }

        public void push(char item)
        {
            this._structure.Add(item);
            _length++;
        }

        public char pop()
        {
            char item = _structure[_length];
            _structure.RemoveAt(_length);
            _length--;
            return item;
        }

        public void print()
        {
            string word = "-> ";
            foreach (var item in _structure)
                word += " " + item;
            Console.WriteLine(word);
        }

        public bool isPalindrome(char ch, string word, int position)
        {
            if (ch != word.Substring(position, 1)[0])
                return false;
            else
                return true;
        }
    }
}

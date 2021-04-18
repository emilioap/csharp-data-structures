using System;
using System.Collections.Generic;

namespace DataStructures.QueueStruct
{
    public class QueueStruct : IQueueStruct
    {
        public QueueStruct(int length, int maxItems)
        {
            _length = length;
            _maxItems = maxItems;
            _structure = new Queue<char>();
        }

        private int _length { get; set; }

        private Queue<char> _structure { get; set;}

        private int _maxItems { get; set; }

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public Queue<char> Structure
        {
            get { return _structure; }
            set { _structure = value; }
        }

        public int MaxItems
        {
            get { return _maxItems; }
            set { _maxItems = value; }
        }

        public char dequeue()
        {
            char item = _structure.Peek();
            _structure.Dequeue();
            _length--;
            return item;
        }

        public void enqueue(char item)
        {
            _structure.Enqueue(item);
            _length++;
        }

        public bool isEmpty()
        {
            return _length == 0;
        }

        public bool isFull()
        {
            return Length == _maxItems;
        }

        public void print()
        {
            string word = "-> ";
            foreach (var item in _structure)
                word += " " + item;
            Console.WriteLine(word);
        }
    }
}

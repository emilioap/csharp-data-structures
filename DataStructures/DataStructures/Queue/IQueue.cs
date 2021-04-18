using System.Collections.Generic;

namespace DataStructures.QueueStruct
{
    public interface IQueueStruct
    {
        Queue<char> Structure { get; set; }
        void enqueue(char item);
        char dequeue();
        bool isEmpty();
        bool isFull();
        void print();
    }
}
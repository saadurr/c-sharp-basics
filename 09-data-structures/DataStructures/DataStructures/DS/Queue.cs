using System;
using System.Collections.Generic;
using System.Text;
/*
 * A queue is a sequential data structure that maintains the order of elements 
 * as they were inserted into the Queue. 
 * It maintains a First In First Out (FIFO) order, which means that the elements 
 * can only be accessed in the same order as they were inserted into the queue.  
 * 
 * Access Complexity is O(n) - requires to traverse through entire queue
 * Search Complexity is O(n) - requires to traverse through entire queue and compare values
 * Insert and Delete complexity is O(1) - adds the element to the front and removes from the end
*/
namespace DataStructures
{
    public class QueueWithList<T>
    {
        private List<T> _queue { get; set; }
        private int _front { get; set; }
        private int _end { get; set; }

        public QueueWithList()
        {
            _queue = new List<T>();
            _front = 0;
            _end = 0;
        }

        public void Enqueue(T value)
        {
            _queue.Add(value);
            _front++;
        }

        public T Dequeue()
        {
            if (isEmpty())
                return default(T);
            else
            {
                T firstElement = _queue[_end];
                _queue.RemoveAt(_end);
                //AdjustQueue();
                return firstElement;
            }
        }

        private void AdjustQueue()
        {
            for (int i = 1; i < _front; i++)
                _queue[i - 1] = _queue[i];

            if (_front > 0)
                _front--;
        }

        public bool isEmpty()
        {
            if (_front <= 0)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("  ---\n");

            if (_front > 0)
            {
                foreach (var x in _queue)
                {
                    sb.Append(x);
                    sb.Append("\n");
                }

            }
            else
            {
                sb.Append("Empty Queue");
            }
            sb.Append("\n  ---\n");

            return sb.ToString();

        }
    }

    class QueueWithArray<T>
    {
        private T[] _queue { get; set; }
        private int _front { get; set; }
        private int _end { get; set; }
        private const int MAX_SIZE = 10;

        public QueueWithArray()
        {
            _queue = new T[10];
            _front = 0;
            _end = 0;
        }
        public void Enqueue(T value)
        {
            if (isFull())
                return;
            else
            {
                _queue[_front] = value;
                _front++;
            }
        }

        public T Dequeue()
        {
            if (isEmpty())
                return default(T);
            else
            {
                T firstElement = _queue[_end];
                AdjustQueue();
                return firstElement;
            }
        }
        private void AdjustQueue()
        {
            for (int i = 1; i < _front; i++)
                _queue[i - 1] = _queue[i];

            _queue[_front] = default(T);
            if (_front > 0)
                _front--;
        }

        public bool isFull()
        {
            if (_front >= MAX_SIZE - 1)
                return true;
            else
                return false;
        }
        public bool isEmpty()
        {
            if (_front <= 0)
                return true;
            else
                return false;
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("  ---\n");

            if (_front > 0)
            {
                for (int i=0; i <_front; i++)
                {
                    sb.Append(_queue[i]);
                    sb.Append("\n");
                }

            }
            else
            {
                sb.Append("Empty Queue");
            }
            sb.Append("\n  ---\n");

            return sb.ToString();

        }
    }

}

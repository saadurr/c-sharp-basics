using System;
using System.Collections.Generic;
using System.Text;
/*
 * Stacks are also sequential structures that follow LIFO (Last In First Out) order.
 * 
 * Access complexity of Stack is O(n) - need to pop all elements one by one.
 * Search complexity of Stack is O(n) - need to pop one by one and then compare.
 * Insert and delete complexity of Stack is O(1) - pop and push are done at the top and are in constant time.
 * 
 * Disadvantages include lack of scalability and random data access is not possible.
*/

namespace DataStructures
{
    class StackWithList<T>
    {
        private List<T> stack { get; set; }
        private int _count { get; set; }
        public StackWithList()
        {
            stack = new List<T>();
            _count = 0;

        }

        public void Push(T value)
        {
            stack.Add(value);
            _count++;
        }

        public T Pop()
        {
            if (_count > 0)
            {
                int lastIndex = _count - 1;
                T lastElement = stack[lastIndex];
                stack.RemoveAt(lastIndex);
                _count--;
                return lastElement;
            }
            else
            {
                _count = 0;
                return default(T);
            }
        }

        public int Count()
        {
            if (_count > 0)
                return _count;
            else
                return 0;
        }

        public T Peek(int index)
        {
            if (index < _count)
                return stack[index];
            else
                return default(T);
        }
        public bool IsEmpty()
        {
            if (_count <= 0)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("  ---\n");

            if (_count > 0)
            {
                foreach (var x in stack)
                {
                    sb.Append(x);
                    sb.Append("\n");
                }
               
            }
            else
            {
                sb.Append("Empty Stack");
            }
            sb.Append("\n  ---\n");

            return sb.ToString();

        }
        // push, pop, count, display
    }

    class StackWithArray<T>
    {
        T[] stack { get; set; }
        private int _count { get; set; }
        private const int MAX_SIZE = 10;
        public StackWithArray()
        {
            stack = new T[10];
            _count = 0;
        }

        public bool Push(T value)
        {
            if (_count < MAX_SIZE)
            {
                stack[_count] = value;
                _count++;
                return true;
            }
            else
                return false;

        }

        public T Pop()
        {
            if (_count > 0)
            {
                int lastIndex = _count;
                _count--;
                return stack[lastIndex];
            }
            else
            {
                _count = 0;
                return default(T);
            }
        }

        public int Count()
        {
            if (_count > 0)
                return _count;
            else
                return 0;
        }

        public T Peek(int index)
        {
            if (index < _count)
                return stack[index];
            else
                return default(T);
        }

        public bool IsEmpty()
        {
            if (_count <= 0)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("  ---\n");

            if (_count > 0)
            {
                for (int x = 0; x < _count; x++)
                {
                    sb.Append(stack[x]);
                    sb.Append("\n");
                }

            }
            else
            {
                sb.Append("Empty Stack");
            }
            sb.Append("\n  ---\n");

            return sb.ToString();

        }
    }

}

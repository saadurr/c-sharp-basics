using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class StackTest
    {
        public static void TestStackWithList()
        {
            StackWithList<int> stack = new StackWithList<int>();
            Console.WriteLine(stack);

            // Test Push
            stack.Push(10);
            stack.Push(8);
            stack.Push(18);
            stack.Push(7);
            Console.WriteLine(stack);

            // Test Pop
            stack.Pop();
            Console.WriteLine(stack);

            // Test count function
            Console.WriteLine(stack.Count());
        }

        public static void TestStackWithArray()
        {
            StackWithArray<int> stack = new StackWithArray<int>();

            // Test push function
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack);

            // Test Pop function
            stack.Pop();
            Console.WriteLine(stack);

            // Test count function
            Console.Write(stack.Count());
        }
    }
}

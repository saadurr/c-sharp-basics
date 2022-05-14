using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class LinkedListTest
    {
        public static void Test()
        {
            LinkedList<int> list = new LinkedList<int>();
            Console.WriteLine(list);

            // Testing AddAtEnd
            list.AddAtEnd(10);
            list.AddAtEnd(11);
            list.AddAtEnd(15);
            list.AddAtEnd(20);
            Console.WriteLine(list);

            // Testing Find fundtion
            var (previous, node) = list.FindFirst(11);
            Console.WriteLine(node.Value);
            Console.WriteLine(node.Next.Value);

            // Testing delete function
            list.DeleteAfter(previous);
            Console.WriteLine(list);

            // Testing AddAfter function
            list.AddAfter(previous, 120);
            Console.WriteLine(list);

        }
    }
}

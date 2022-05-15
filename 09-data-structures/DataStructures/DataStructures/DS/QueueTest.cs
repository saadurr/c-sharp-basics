using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class QueueTest
    {
        public static void TestQueueWithList()
        {
            QueueWithList<int> testQueue = new QueueWithList<int>();
            Console.WriteLine(testQueue);
            
            // Test enqueue function
            testQueue.Enqueue(10);
            testQueue.Enqueue(11);
            testQueue.Enqueue(15);
            testQueue.Enqueue(16);
            Console.WriteLine(testQueue);

            // Test dequeue function
            testQueue.Dequeue();
            Console.WriteLine(testQueue);

        }

        public static void TestQueueWithArray()
        {
            QueueWithArray<int> tQueue = new QueueWithArray<int>();
            Console.WriteLine(tQueue);

            // Test Enqueue
            tQueue.Enqueue(1);
            tQueue.Enqueue(2);
            tQueue.Enqueue(3);
            tQueue.Enqueue(4);
            Console.WriteLine(tQueue);

            // Test Dequeue
            tQueue.Dequeue();
            Console.WriteLine(tQueue);
        }
        
    }
}

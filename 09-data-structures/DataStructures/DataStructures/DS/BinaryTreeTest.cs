using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class BinaryTreeTest
    {
        private static TreeNode CreateTestTree()
        {
            return new TreeNode(60,
                    new TreeNode(30,
                        new TreeNode(10,
                            new TreeNode(1), new TreeNode(20)),
                        new TreeNode(40,
                            new TreeNode(35), new TreeNode(50))),
                    new TreeNode(100,
                        new TreeNode(80,
                            new TreeNode(70), new TreeNode(90)),
                        new TreeNode(120,
                            left: new TreeNode(110))
                                )
                            );
        }
        public static void Test()
        {
            // Loads sample data for testing
            TreeNode testTree = CreateTestTree();

            BinaryTree bTree = new BinaryTree(testTree);

            Console.WriteLine("--------");
            Console.WriteLine("Searching value of 50 in Tree:");
            Console.WriteLine(bTree.Search(50) == null ? "Not Found" : "Found!");

            Console.WriteLine("\n\nTesting Post-Order Traversal");
            bTree.TraversePostOrder(testTree);

            Console.WriteLine("\n\nTesting Pre-Order Traversal");
            bTree.TraversePreOrder(testTree);

            Console.WriteLine("\n\nTesting In-Order Traversal");
            bTree.TraverseInOrder(testTree);

            Console.WriteLine("\n\nTesting Bread First Traversal");
            bTree.TraverseLevelOrder(testTree);

            Console.WriteLine("\n\nTesting BFS Traversal with Queue:");
            bTree.TraverseOrderQueue(testTree);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
/*
 * Trees is a hierarchical in structure, has a base node called root node.
 * The root can have zero or more children and each child node can further have zero or more children.
 * 
 * Leaf is the node with no children. Root is the node with no parents.
 * 
 * In Binary trees, a node can only have a maximum of two children.
 * 
 * Complete Binary Tree: where all levels are filled, except the last one which must be filled from left to right.
 * Full Binary Tree: where each node has either zero or two children.
 * Perfect Binary Tree: which is both full and complete.
 * Balanced Binary Tree: which ensures that insertion / search operations run in O(log(n)) time.
 * 
 * In Binary Search Tree (BST), nodes are ordered as:
 * left nodes <= root <= right nodes
 * 
 * Search time is usually O(log(N)).
 * The element is compared with the root, if smaller than the root then go left otherwise go right.
 * 
 * Pre-order Traversal: visiting the root node, then left node, then right node.
 * Post-order Traversal: visiting the left and right nodes, and then the root node.
 * In-order traversal: visiting the left childs, then the root, and then the right nodes.
 * (In-order traversal leads to nodes being visited in ascending order)
*/
namespace DataStructures
{
    class TreeNode
    { 
        public int Value { get; }
        public TreeNode Left { get; }
        public TreeNode Right { get; }

        public TreeNode(int value, TreeNode left = null, TreeNode right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }

    class BinaryTree
    {
        TreeNode _tree { get; set; }
        public BinaryTree(TreeNode tree = null)
        {
            _tree = tree;
        }
        
        public TreeNode Search(int value, TreeNode t = null)
        {
            if (null == t)
                t = _tree;

            // Tree is empty
            if (null == t) return null;

            // Value found at root node
            if (value == t.Value) return t;

            // value is smaller, look left
            if (value <= t.Value) return Search(value, t.Left);

            // value is larger, look right
            return Search(value, t.Right);

        }

        public void TraversePostOrder(TreeNode node, int level = 0)
        {
            if (null == node) return;

            // Traverse Left Node
            TraversePostOrder(node.Left, level + 1);

            //Traverse Right Node
            TraversePostOrder(node.Right, level + 1);

            string separator = new string('-', level);
            Console.WriteLine($"{separator}{node.Value}");
        }

        public void TraversePreOrder(TreeNode node, int level = 0)
        {
            if (node == null) return;

            // Current Node - root
            string separator = new string('-', level);
            Console.WriteLine($"{separator}{node.Value}");

            // Go left
            TraversePreOrder(node.Left, level + 1);

            // Go Right
            TraversePreOrder(node.Right, level + 1);
        }

        public void TraverseInOrder(TreeNode node, int level = 0)
        {
            if (node == null) return;

            // Left first
            TraverseInOrder(node.Left, level + 1);

            
            string separator = new string('-', level);
            Console.WriteLine($"{separator}{node.Value}");
            
            // Right
            TraverseInOrder(node.Right, level + 1);
        }
    }
}

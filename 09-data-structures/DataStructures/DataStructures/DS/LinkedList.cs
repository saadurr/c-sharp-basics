using System;
using System.Collections.Generic;
using System.Text;

/*
 * Linked List is a linear collection of multiple elements
 * where each memebr of the linked list points to the next member.
 * 
 * Access complexity is O(n) - the entire list needs to be traversed
 * Search complexity is O(n) - searching requires traversing the entire list
 * Insert complexity is O(1) (if a node is given) because the next node is just to be added.
 * Delete complexity at a specific index i is O(i) because the list will need to be traversed until that point
 * Delete complexity if you need to search the element as well is O(n)
*/

namespace DataStructures
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Value { get; set; }
    }

    public class LinkedList<T>
    {
        public Node<T> Head { get; private set; }

        public LinkedList()
        {
            Head = new Node<T>();
            Head = null;
        }

        public (Node<T> previous, Node<T> found) FindFirst(T value)
        {
            Node<T> previous = null;
            Node<T> current = Head;

            // Linked List is empty because head is null
            if (null == current) return (null, null);

            // We cannot use == because structures do not support them by default
            // Search term found at head
            if (current.Value.Equals(value)) return (null, Head);

            do
            {
                previous = current;
                current = current.Next;

                if (current.Value.Equals(value))
                    return (previous, current);

            } while (null != current.Next);

            // Value not found and returns null in default case
            return (null, null);

        }
        public Node<T> AddAfter(Node<T> node, T value)
        {
            // New Node to be added
            Node<T> newNode = new Node<T>()
            {
                Next = node.Next,
                Value = value
            };

            // Setting the new created node as the next node to the current node
            node.Next = newNode;


            return newNode;
        }
        public Node<T> AddAtEnd(T value)
        {
            Node<T> newNode = new Node<T>() { Next = null, Value = value};

            // Linked List is empty, adding at head
            if (null == Head)
            {
                Head = newNode;

                return newNode;
            }
            else
            {
                Node<T> current = Head;
                // Traverse list until end
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;

                return newNode;
            }
        }
        public bool DeleteAfter(Node<T> node)
        {
            Node<T> nextNode = node.Next;
            
            // There is nothing to delete
            if (null == nextNode) return false;

            node.Next = nextNode.Next;
            return true;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node<T> current = Head;
            sb.Append("[ ");
            if (null == current)
            {
                sb.Append("Empty");
            }
            else
            {
                while (current != null)
                {
                    sb.Append(current.Value);
                    sb.Append(", ");
                    current = current.Next;
                }
            }
            sb.Append(" ]");

            return sb.ToString();
        }
    }
}

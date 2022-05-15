using System;
using System.Collections.Generic;
using System.Text;

/*
 * Hash tables try to map one data type to another data type, creating paired assignments.
 * To have a search complexity of O(1), hash tables rely heavily on hashing.
 * 
 * Hash collisions are also very common and one of the simplest (and least efficient) collision resolution strategy
 * is separate chaining with linked lists.
 * This will work with creating buckets or (array of items) where each item will have a reference to a linked list
 * containing keys with the same hash.
 * This method is inefficient since reference will hold a lot of memory. A bad hash distribution will make the search operation O(n).
 * 
 * Each object in C# has its hashcode which can be accessed by GetHashCode. Writing a custom hash function is complicated.
 * 
 * Load Factor (n/k) is the ratio of number of entries (n) in the hash table and the number of buckets.
 * Based on load factor, we can know when to increase the size of internal array.
 * 
 * Search Complexity is O(1) - on average, it requires constant time.
 * Insert and Delete complexity is O(1) - constant time is required, regardless of the size of hash table.
*/
namespace DataStructures
{
    public class HashNode<T>
    {
        public HashNode<T> Next { get; set; }
        public string Key { get; set; }
        public T Value { get; set; }
    }

    class Hashtable<T>
    {
        private readonly HashNode<T>[] _buckets;
        public Hashtable(int size)
        {
            _buckets = new HashNode<T>[size];
        }

        public void Add(string key, T item)
        {
            ValidateKey(key);

            var valueNode = new HashNode<T> { Key = key, Value = item, Next = null };
            int position = GetBucketByKey(key);

            HashNode<T> listNode = _buckets[position];

            // If that bucket doesnt have anything then just add a new node
            if (null == listNode)
            {
                _buckets[position] = valueNode;
            }
            else
            {
                while(null != listNode.Next)
                {
                    listNode = listNode.Next;
                }
                listNode.Next = listNode;
            }
        }

        public T Get(string key)
        {
            ValidateKey(key);

            var (_, node) = GetNodeByKey(key);

            if (node == null) throw
                     new ArgumentOutOfRangeException(nameof(key), $"The key {key} is not found!");

            return node.Value;
        }

        public bool Remove(string key)
        {
            ValidateKey(key);

            int position = GetBucketByKey(key);

            var (previous, current) = GetNodeByKey(key);

            // If current is null, the node does not exist
            if (null == current) return false;

            // If previous is null, the node is the first element in the bucket
            if(null == previous)
            {
                _buckets[position] = null;
                return true;
            }

            // Simply remove the reference to current
            previous.Next = current.Next;
            return true;
        }

        public bool ContainsKey(string key)
        {
            ValidateKey(key);

            var (_, node) = GetNodeByKey(key);

            // Not equal is true when node exists
            return (null != node);
        }

        public int GetBucketByKey(string key)
        {
            return Math.Abs(key.GetHashCode() % _buckets.Length);
        }

        protected (HashNode<T> previous, HashNode<T> current) GetNodeByKey(string key)
        {
            int position = GetBucketByKey(key);

            HashNode<T> listNode = _buckets[position];
            HashNode<T> previous = null;
            
            // Iterate through the bucket until the key matches
            while (null != listNode)
            {
                if (listNode.Key == key)
                    return (previous, listNode);

                previous = listNode;
                listNode = listNode.Next;
            }

            // Not found in the bucket, return null
            return (null, null);
        }
        protected void ValidateKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));
        }
    }
}

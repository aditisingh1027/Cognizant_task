using System;
using System.Collections.Generic;

namespace DSA.LinkedList
{
    // Node of a singly linked list
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    // Simple singly linked list implementation
    public class SinglyLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public void Add(T value)
        {
            var node = new Node<T>(value);
            if (head == null)
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }

        public IEnumerable<T> Traverse()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }

    // Demo class exposing a static Run method
    public static class LinkedListDemo
    {
        public static void Run()
        {
            var list = new SinglyLinkedList<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            Console.WriteLine("Linked list contents:");
            foreach (var item in list.Traverse())
            {
                Console.WriteLine(item);
            }
        }
    }
}

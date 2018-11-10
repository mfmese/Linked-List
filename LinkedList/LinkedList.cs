using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedList : ILinkedList
    {
        Node head;

        public void Append(object data)
        {
            if (head == null)
            {
                head = new Node(data);
                return;
            }

            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new Node(data);
        }

        public void Prepend(object data)
        {
            var newHead = new Node(data);
            newHead.Next = head;
            head = newHead;
        }

        public void InsertBeforeValue(object data, object value)
        {
            var current = head;

            if (current.Data.ToString() == value.ToString())
            {
                Prepend(data);
                return;
            }

            while (current.Next != null)
            {
                if (current.Next.Data.ToString() == value.ToString())
                    break;
                current = current.Next;
            }

            var newNode = new Node(data);
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void InsertAfterValue(object data, object value)
        {
            var current = head;
            while (current.Next != null)
            {
                if (current.Data.ToString() == value.ToString())
                    break;
                current = current.Next;
            }

            var newNode = new Node(data);
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void InsertBeforePosition(object data, int position)
        {
            var current = head;

            if (position == 1)
            {
                Prepend(data);
                return;
            }

            for (int i = 1; i < position - 1 && current != null; i++)
            {
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine(position + " not set in the list");
            }
            var newNode = new Node(data);
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void InsertAfterPosition(object data, int position)
        {

        }

        public void Delete(object data)
        {
            if (head == null)
                return;

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            var current = head;
            while (current.Next != null)
            {

                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                }

                current = current.Next;
            }
        }

        public void DeleteAtPosition(int position)
        {
            var current = head;

            if (position == 1)
            {
                head = current.Next;
                return;
            }

            for (int i = 1; i < position - 1 && current.Next != null; i++)
            {
                current = current.Next;
            }

            current.Next = current.Next.Next;

        }

        public void DeleteFirst()
        {
            head = head.Next;
        }

        public void DeleteLast()
        {

            var current = head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }

            current.Next = null;
        }

        public int Length()
        {
            var current = head;
            int count = 1;

            while(current.Next != null)
            {
                count++;
                current = current.Next;
            }

            Console.WriteLine("There are " + count + " Nodes in the list");
            return count;
        }

        public bool Search(object data)
        {
            var current = head;

            while(current.Next != null)
            {

                if(current.Data.ToString() == data.ToString())
                {
                    Console.WriteLine(data.ToString() + " has found in the list");
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("There is no Node in the list");
                return;
            }

            Console.Write("List is : ");
            var current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}

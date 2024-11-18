using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA45.LinkedLists
{
    internal class DLL
    {
        private Node head;
        private Node tail;
        private Node Prev;
        private int size = 0;
        public DLL()
        {
            this.size = 0;
        }

        public void insertFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            if(head != null)
            {
                head.prev = newNode;
            }
            head = newNode;
            if (tail == null) //if the added node is the first one, head and tail will be the same
            {
                tail = head;
            }
            size++;
        }

        public void insertLast(int data)  //without tail we'd need to traverse the ll to insert and it takes o(n) time
        {
            if (tail == null || size == 0)
            {
                insertFirst(data);
                return;
            }
            Node newNode = new Node(data);
            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
            size++;
        }

        public void insertAtIndex(int index, int data)
        {
            if (index == 0)
            {
                insertFirst(data);
                return;
            }
            if (index == size)
            {
                insertLast(data);
                return;
            }

            Node temp = head;
            for (int i = 1; i < index; i++)
            {
                temp = temp.next;
            }
            Node Newnode = new Node(data);
            Newnode.next = temp.next;
            temp.next.prev = Newnode;
            temp.next = Newnode;
            Newnode.prev = temp;
            size++;

        }

        public void DisplayAll()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write($"{temp.data} -> ");
                temp = temp.next;
            }
            Console.WriteLine("END");
            Console.WriteLine($"{head.data} -> head");
            Console.WriteLine($"{tail.data} -> tail");
        }

        public void DeleteFirst()
        {
            if (head != null)
            {
                head = head.next;
                head.prev = null;
            }
            size--;
        }

        public void DeleteLast()
        {
            if (size <= 1)
            {
                head = null;
                tail = null;
                size = 0;
                return;
            }
            tail = tail.prev;
            tail.next = null;
            size--;
        }
        public Node getNodeIndex(int index)
        {
            Node node = head;
            for (int i = 0; i < index; i++)
            {
                node = node.next;
            }
            return node;
        }
        public void DeleteIndex(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
            if (index == 0)
            {
                DeleteFirst();
                return;
            }
            if(index == size - 1)
            {
                DeleteLast();
                return;
            }
            Node temp = getNodeIndex(index);
            temp.prev.next = temp.next;
            temp.next.prev = temp.prev;

            size--;
        }
        public class Node
        {
            public int data;
            public Node next;
            public Node prev;
            public Node(int d)
            {
                data = d;
                next = null;
                prev = null;
            }
        }
    }
}

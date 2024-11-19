using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA45.LinkedLists
{
    internal class CLL
    {
        private Node head;
        private Node tail;
        private int size = 0;
        public CLL()
        {
            this.head = null;
            this.tail = null;
        }

        public void insert(int val)
        {
            Node newNode = new Node(val);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                size++;
                return;
            }
            tail.next = newNode;
            newNode.next = head;
            tail = newNode;
        }

        public void display()
        {
            Node temp = head;
            if(head != null)
            {
                do
                {
                    Console.Write($"{temp.data} -> ");
                    temp = temp.next;
                } while (temp != head);
            }
            Console.WriteLine("HEAD");
        }

        public void delete(int val)
        {
            Node node = head;
            if (node == null)
            {
                Console.WriteLine("No data to delete");
            }
            if (node.data == val)
            {
                head = head.next;
                tail.next = head;
                return;
            }
            do
            {
                if (node.next.data == val)
                {
                    node.next = node.next.next;
                    return;
                }
                node = node.next;
            } while (node != head);
        }
        public class Node 
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
            }
        }
    }
}

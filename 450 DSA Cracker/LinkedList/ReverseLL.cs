using System;
 
namespace DSA45
{
    public class LinkedListt
    {
 
        private Node head;
        private Node tail;
        private int size = 0;
        public LinkedListt()
        {
            this.size = 0;
        }
 
        public void insertFirst(int data)
        {
            Node node = new Node(data);
            node.Next = head;
            head = node;
 
            if (tail == null) //if the added node is the first one, head and tail will be the same
            {
                tail = head;
            }
            size++;
        }
        public void DisplayAll()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write($"{temp.Data} -> ");
                temp = temp.Next;
            }
            Console.WriteLine("END");
            Console.WriteLine($"{head.Data} -> head");
            Console.WriteLine($"{tail.Data} -> tail");
        }
 
        public void reverse()
        {
            Node prev = null;
            Node current = head;
            Node next = null;
            while(current != null)
            {
                next = current.Next;
                current.Next = prev; //to break the loop
                prev = current;
                current = next;
            }
            head = tail; //once done we need to update the head and tail
            prev = head;
        }
 
 
        public class Node
        {
            public int Data;
            public Node Next;
 
            public Node(int data)
            {
                this.Data = data;
                this.Next = null;
            }
 
            public Node(int data, Node next)
            {
                this.Data = data;
                this.Next = next;
            }
        }
 
    }
}

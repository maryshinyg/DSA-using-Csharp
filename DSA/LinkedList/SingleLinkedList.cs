using System;

namespace LinkedLists
{
    public class LL
    {

        private Node head;
        private Node tail;
        private int size = 0;
        public LL()
        {
            this.size = 0;
        }

        public void insertFirst(int data)
        {
            Node node = new Node(data);
            node.Next = head;
            head = node;

            if(tail == null) //if the added node is the first one, head and tail will be the same
            {
                tail = head;
            }
            size++;
        }

        public void insertLast(int data)  //without tail we'd need to traverse the ll to insert and it takes o(n) time
        {
            if(tail == null || size == 0)
            {
                insertFirst(data);
                return;
            }
            Node node = new Node(data);
            tail.Next = node;
            tail = node;
            size++;
        }

        public void insertAtIndex(int index, int data)
        {
            if(index == 0)
            {
                insertFirst(data);
                return;
            }
            if(index == size)
            {
                insertLast(data);
                return;
            }

            Node temp = head;
            for(int i=1; i<index; i++)
            {
                temp = temp.Next;
            }
            Node Newnode = new Node(data);
            Newnode.Next = temp.Next;
            temp.Next = Newnode;   

            size++;
            
        }

        public void DeleteFirst()
        {
            if(head != null)
            {
                head = head.Next;
            }
            size--;
        }

        public Node getNodeIndex(int index)
        {
            Node node = head;
            for(int i=0; i<index; i++)
            {
                node = node.Next;
            }
            return node;
        }
        public void DeleteLast()
        {
            if (size <= 1)
            {
                DeleteFirst();
                return;
            }
            Node node = getNodeIndex(size-2);
            tail = node;
            tail.Next = null;
            size--;
            
        }

        public void DeleteAtIndex(int index) {
            if (index < 0 || index >= size)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
            if (index == 0)
            {
                DeleteFirst() ;
                return;
            }
            if(index == size-1)
            {
                DeleteLast();
                return;
            }
            Node prev = getNodeIndex(index-1);
            prev.Next = prev.Next.Next;

            size--;
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

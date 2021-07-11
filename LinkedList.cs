using System;
namespace LinkedList
{
    public class LinkedList
    {
        Node head;
        public void AddLast(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }

        }

        public void InsertBeginning(int val)
        {
            Node node = new Node(val);
            if (head == null)
            {
                this.head = node;
            }
            else
            {

                node.next = this.head;
                this.head = node;
            }
        }
        public void InsertMiddle(int val,int pos)
        {
            int count = 1;
            Node temp = this.head;
            Node prev = null;
            Node node = new Node(val);

            while (count != pos)
            {
                prev = temp;
                temp = temp.next;
                count++;
            }
           
            prev.next = node;
            node.next = temp.next;
        }

        public void DeleteBeginning()
        {
            if (this.head != null)
            {
                Console.WriteLine("\nAfter Deletion:");
                this.head = this.head.next;
            }
            else
            {
                Console.WriteLine("No elements in the linked list");
            }
        }

        public void Display()
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.next != null)
                {
                    Console.Write($"{temp.data} -->");
                }
                else
                {
                    Console.Write(temp.data);
                }

                temp = temp.next;
            }
        }

    }
}

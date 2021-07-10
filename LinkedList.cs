using System;
namespace LinkedList
{
    public class LinkedList
    {
        Node head;
        public void InsertAtLast(int data)
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

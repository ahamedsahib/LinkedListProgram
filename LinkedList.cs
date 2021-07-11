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

        public void DeleteLast()
        {
            if (this.head == null)
            {
                this.head = null;
            }
            if(head.next==null)
            {
                this.head = null;
            }
            Node temp = this.head;
            while (temp.next.next != null)
            {
                 temp = temp.next;
            }
            temp.next = null;
        }
        public void Search(int val)
        {
            int flag = 1;
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == val)
                {
                    flag = 1;
                    break;
                }
                temp = temp.next;
            }
            Console.WriteLine((flag==1)?$"\n{val} found":$"{val}Not Found" );
        }

        public void SearchInsert(int val,int data)
        {
            Node temp = this.head;
            Node prev = null;
            Node node = new Node(val);
            while (temp != null)
            {
                if (temp.data == data)
                {
                    prev = temp;
                    temp = temp.next;
                    break;
                }
                temp = temp.next;

            }
            prev.next = node;
            node.next = temp;
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

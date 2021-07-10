using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program");
            LinkedList linkedList = new LinkedList();
            //Adding Elements to linked list
            linkedList.AddLast(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);

            linkedList.Display();
        }
    }
}

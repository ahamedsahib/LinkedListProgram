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
            linkedList.InsertBeginning(56);
            linkedList.InsertBeginning(30);
            linkedList.InsertBeginning(70);

            linkedList.Display();
        }
    }
}

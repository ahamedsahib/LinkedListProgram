using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program");
            LinkedList linkedList = new LinkedList();
            
            linkedList.InsertBeginning(56);
            linkedList.InsertBeginning(30);
            linkedList.InsertBeginning(70);
            linkedList.InsertBeginning(40);
            linkedList.InsertBeginning(80);

            linkedList.Display();
            //linkedList.InsertMiddle(23, 4);

            linkedList.Search(70);

            linkedList.SearchInsert(49, 40);
            linkedList.Display();

            linkedList.DeleteMiddle(49);
            //linkedList.DeleteBeginning();
            //linkedList.DeleteLast();
            linkedList.Sort();
            Console.WriteLine("Sorted List");
            linkedList.Display();
        }
    }
}

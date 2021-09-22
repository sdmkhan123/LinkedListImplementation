using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Welcome to LinkedList implementation World!\n");
            Console.WriteLine("****************************************************************\n");
            LinkedListDetails<int> list = new LinkedListDetails<int>();
            list.addNode(56);
            list.addNode(1);
            list.addNode(2);
            list.addNode(9);
            list.addNode(8);
            list.addNode(7);
            list.addNode(6);
            list.addNode(3);
            list.addNode(30);
            list.addNode(70);
            Console.WriteLine("After adding some node in LL");
            list.displayLL();
            Console.WriteLine("****************************************************************\n");
            //Inserting a node at begning of the LL
            list.InsertNodeAtBegin(80);
            list.displayLL();
            Console.WriteLine("****************************************************************\n");
            Console.WriteLine("\nEND OF APPLICATION\n****************************************************************");
        }
    }
}

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
            //pending a node in the last of a LL
            list.appendNode(2);
            list.displayLL();
            Console.WriteLine("****************************************************************\n");
            //Adding a new node 90 between two node 30 and 70
            list.addNodeBetween(30, 70, 90);
            list.displayLL();
            Console.WriteLine("****************************************************************\n");
            //Deletinng first node of the LinkedList
            list.deleteFirstNode();
            list.displayLL();
            Console.WriteLine("****************************************************************\n");
            //Deletinng last node of the LinkedList
            list.deleteLastNode();
            list.displayLL();
            Console.WriteLine("****************************************************************\n");
            //Search a node in given LL
            list.searchNode(3);
            //insert a node 15 after a given node 7 in LL
            list.insertAfterNode(7, 15);
            list.displayLL();
            Console.WriteLine("****************************************************************\n");
            //Deletinng Random node of the LinkedList
            list.deleteRandomNode(30);
            list.displayLL();
            Console.WriteLine("****************************************************************\n");
            LinkedListDetails<int> orderedList = new LinkedListDetails<int>();
            orderedList.addInSortedLinkedList(56);
            orderedList.addInSortedLinkedList(30);
            orderedList.addInSortedLinkedList(40);
            orderedList.addInSortedLinkedList(80);
            orderedList.addInSortedLinkedList(57);
            orderedList.addInSortedLinkedList(72);
            Console.WriteLine("After adding some node in a sorted LL");
            orderedList.displaySortedLL();
            Console.WriteLine("****************************************************************\n");
            Console.WriteLine("\nEND OF APPLICATION\n****************************************************************");
        }
    }
}
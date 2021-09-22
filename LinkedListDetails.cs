using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListImplementation
{
    public class LinkedListDetails<Gtype>
    {
        //initialize the head of the LL
        public NodeCreation<Gtype> head;
        /// <summary>
        /// add new node to LL in last
        /// </summary>
        /// <param name="value"></param>
        public void addNode(Gtype value)
        {
            //Create a new Node of LL and add to LL
            NodeCreation<Gtype> node = new NodeCreation<Gtype>(value);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                NodeCreation<Gtype> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        /// <summary>
        /// display the all node data in Current LL
        /// </summary>
        public void displayLL()
        {
            NodeCreation<Gtype> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Given LL is empty");
            }
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Display all node value of LL");
            Console.WriteLine("****************************************************************");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }
    }
}

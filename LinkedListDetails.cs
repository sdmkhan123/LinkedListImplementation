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
            if (this.head == null)
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
        ///Method for Inserting a node at begning of the LL
        /// </summary>
        /// <param name="value"></param>
        public void InsertNodeAtBegin(Gtype value)
        {
            //Create a new Node of LL and add to LL
            NodeCreation<Gtype> node = new NodeCreation<Gtype>(value);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                node.next = head;
                this.head = node;
            }
            Console.WriteLine("After Inserting a node "+ value +" at begning of the LL");
        }
        /// <summary>
        /// Appending a node in last node of LL
        /// </summary>
        /// <param name="value"></param>
        public void appendNode(Gtype appnedValue)
        {
            //Create a new Node of LL and add to LL
            NodeCreation<Gtype> appnedNode = new NodeCreation<Gtype>(appnedValue);
            if (head == null)
            {
                this.head = appnedNode;
            }
            else
            {
                NodeCreation<Gtype> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = appnedNode;
            }
            Console.WriteLine("\nAfter Appending node value " + appnedValue + " in last node of LL");
        }
        /// <summary>
        /// display the all node data in Current LL
        /// </summary>
        public void displayLL()
        {
            NodeCreation<Gtype> temp = head;
            if (temp == null)
            {
                Console.WriteLine("Given LL is empty");
            }
            Console.WriteLine("-->Display all node value of LL");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }
    }
}

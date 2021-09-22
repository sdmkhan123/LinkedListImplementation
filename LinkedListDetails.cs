using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListImplementation
{
    public class LinkedListDetails<Gtype> where Gtype : IComparable
    {
        //initialize the head of the LL
        public NodeCreation<Gtype> head;
        public NodeCreation<Gtype> sortedHead;
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
        /// Insert a new node between two given value node
        /// </summary>
        /// <param name="valueOne"></param>
        /// <param name="valueTwo"></param>
        internal void addNodeBetween(Gtype valueOne, Gtype valueTwo, Gtype value)
        {
            NodeCreation<Gtype> node = new NodeCreation<Gtype>(value);
            if (head == null || head.next == null)
            {
                Console.WriteLine("we can't add node between two node");
                return;
            }
            else
            {
                NodeCreation<Gtype> temp = head;
                while (temp.next != null)
                {
                    if (valueOne.Equals(temp.data) && valueTwo.Equals(temp.next.data))
                    {
                        break;
                    }
                    temp = temp.next;
                }
                node.next = temp.next;
                temp.next = node;
            }
            Console.WriteLine("\nAdding node " + value + " between two node " + valueOne + " and " + valueTwo + " of LL");
        }
        /// <summary>
        /// Delete a first node of the given LL
        /// </summary>
        public void deleteFirstNode()
        {
            NodeCreation<Gtype> temp = this.head;
            if (head == null)
            {
                Console.WriteLine("LL is empty");
                return;
            }
            else
            {
                this.head = head.next;
                temp.next = null;
            }
            Console.WriteLine("\nAfter Deleting first node " + temp.data + " of LL");
        }
        /// <summary>
        /// Delete a Last node of the given LL
        /// </summary>
        public void deleteLastNode()
        {
            NodeCreation<Gtype> temp1 = this.head;
            if (head == null)
            {
                Console.WriteLine("LL is empty");
                return;
            }
            else
            {
                NodeCreation<Gtype> temp = this.head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp1 = temp.next;
                temp.next = null;
            }
            Console.WriteLine("\nAfter Deleting last node " + temp1.data + " of LL");
        }
        /// <summary>
        /// Method to search a value in a given LL
        /// </summary>
        /// <param name="searchValue"></param>
        public void searchNode(Gtype searchValue)
        {
            NodeCreation<Gtype> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("No, Given LL is empty, so Data value is not present");
            }
            while (temp != null)
            {
                if (searchValue.Equals(temp.data))
                {
                    Console.WriteLine("Yes, Given search value " + searchValue + " is present in LL");
                    break;
                }
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("No, Given search value " + searchValue + " is not present in LL");
            }
            Console.WriteLine("\n****************************************************************\n");
        }
        /// <summary>
        /// Insert a node after a given node in LL
        /// </summary>
        /// <param name="value"></param>
        public void insertAfterNode(Gtype afterValue, Gtype insertValue)
        {
            NodeCreation<Gtype> node = new NodeCreation<Gtype>(insertValue);
            if (head == null)
            {
                Console.WriteLine("we can't add node");
                return;
            }
            else
            {
                NodeCreation<Gtype> temp = head;
                while (temp != null)
                {
                    if (afterValue.Equals(temp.data))
                    {
                        node.next = temp.next;
                        temp.next = node;
                        Console.WriteLine("\nInserting node " + insertValue + " after node " + afterValue + " of LL");
                        break;
                    }
                    temp = temp.next;
                }
                if (temp == null)
                {
                    Console.WriteLine("\n****************************************************************\n");
                    Console.WriteLine("There is no node present in LL with the node value " + afterValue);
                    Console.WriteLine("\n****************************************************************\n");
                }
            }
        }
        /// <summary>
        /// Deletinng a Random node from the given LL
        /// </summary>
        /// <param name="randomValue"></param>
        public void deleteRandomNode(Gtype randomValue)
        {
            NodeCreation<Gtype> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Given LL is empty, so Data value is not present");
            }
            else if (randomValue.Equals(temp.data))
            {
                temp = null;
            }
            else
            {
                while (temp.next != null)
                {
                    if (randomValue.Equals(temp.next.data))
                    {
                        Console.WriteLine("\nAfter Deleting random node " + temp.next.data + " of the LL");
                        temp.next = temp.next.next;
                        break;
                    }
                    temp = temp.next;
                }
            }
            if (temp == null)
            {
                Console.WriteLine("Given data value " + randomValue + " is not present in LL");
            }
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
        /// <summary>
        /// Method TO create a Ordered LL in assending order
        /// </summary>
        /// <param name="value"></param>
        public void addInSortedLinkedList(Gtype value)
        {
            //Create a new Node of LL and add to LL
            NodeCreation<Gtype> node = new NodeCreation<Gtype>(value);
            if (this.sortedHead == null || (sortedHead.data.CompareTo(value) >= 0))
            {
                node.next = sortedHead;
                this.sortedHead = node;
            }
            else
            {
                NodeCreation<Gtype> temp = sortedHead;
                while (temp.next != null && (temp.next.data.CompareTo(value) < 0))
                {
                        temp = temp.next;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }
        /// <summary>
        /// display the all node data in a assending order of Current LL
        /// </summary>
        public void displaySortedLL()
        {
            NodeCreation<Gtype> temp = sortedHead;
            if (temp == null)
            {
                Console.WriteLine("Given LL is empty");
            }
            Console.WriteLine("-->Display all node value of LL in assending order");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }
    }
}

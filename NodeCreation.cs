using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListImplementation
{
    public class NodeCreation<Gtype>
    {
        //intilize instance variable of class
        public NodeCreation<Gtype> next;
        public Gtype data;
        /// <summary>
        /// constructor to create a node
        /// </summary>
        /// <param name="value"></param>
        public NodeCreation(Gtype value)
        {
            this.data = value;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Node
    {
        public Node Next { get; set; }
        public object Data;

        public Node(object data)
        {
            this.Data = new object();
            this.Data = data;
        }
    }
}

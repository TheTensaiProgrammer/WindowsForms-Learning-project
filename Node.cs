using System;
using System.Collections.Generic;
using System.Text;

namespace shopwithui
{
    class Node
    {
        public Students Data;
        public bool Color; //red - false; black - true
        public Node Left;
        public Node Right;
        public Node Parent;
        public int Count;
        public Node(Node left, Students data, bool color, Node right, Node parent, int count)
        {
            Left = left;
            Data = data;
            Color = color;
            Right = right;
            Parent = parent;
            Count = count;
        }
        public Node()
        {
            Left = null;
            Data = default;
            Color = true;
            Right = null;
            Parent = null;
            Count = 1;
        }
    }
}

using System;
using System.Collections.Generic;

namespace GraphLib
{
    public class Node<CONTENT> where CONTENT : IEquatable<CONTENT>
    {
        public readonly CONTENT Content;
        public readonly List<Node<CONTENT>> Neighbours;

        public Node(CONTENT content)
        {
            Content = content;
            Neighbours = new List<Node<CONTENT>>();
        }
    }
}
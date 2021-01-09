using System;

namespace ReverseALinkedList.App
{
    public class Node
    {
        public int Val { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static int[] _r;

        public static Node GenerateLinkedList(int[] r)
        {
            _r = r;
            return NextNode(0);
        }

        private static Node NextNode(int i)
        {
            if (i >= _r.Length)
            {
                return null;
            }
            var n = new Node();
            n.Val = _r[i];

            i++;
            n.Right = NextNode(i);

            return n;
        }

        private static Node ReversedNode;

        public static Node ReversedTheLinkedList(Node ll)
        {
            ReverseNode(ll);
            return ReversedNode;
        }

        private static Node ReverseNode(Node n)
        {
            if (n.Right != null)
            {
                var rn = new Node();
                rn.Val = n.Val;
                rn.Right = ReversedNode;
                ReversedNode = rn;
                ReverseNode(n.Right);
                return null;
            }
            else
            {
                var rn = new Node();
                rn.Val = n.Val;
                rn.Right = ReversedNode;
                ReversedNode = rn;
                return ReversedNode;
            }
        }
    }
}
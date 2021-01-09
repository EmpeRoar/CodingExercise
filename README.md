# Coding Exercise

### Intersection
``` c#
using System;
using System.Linq;

namespace FindIntersection
{
    internal class Program
    {
        private static int[] Splitter(string str)
        {
            return str.Split(",").Select(Int32.Parse).ToArray();
        }

        public static string FindIntersection(string[] strArr)
        {
            int[] a = Splitter(strArr[0]);
            int[] b = Splitter(strArr[1]);
            var c = new int[a.Length > b.Length ? a.Length : b.Length];
            int i = 0;
            foreach (var ai in a)
            {
                if (b.Contains(ai))
                {
                    c[i] = ai;
                    i++;
                }
            }

            if (c.Count() > 0)
            {
                return String.Join(",", c.Where(x => x != 0).ToArray());
            }
            else
            {
                return "false";
            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine(FindIntersection(new string[] { "1, 2, 3", "3" }));
            Console.ReadLine();
        }
    }
}
```

#### Median
``` c#

public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
        }

        public static decimal GetMedian(int[] r1, int[] r2)
        {
            var l = new List<int>();
            l.AddRange(r1.ToList());
            l.AddRange(r2.ToList());
            var r = l.ToArray();
            

            if((r.Length % 2)== 0)
            {
                var i1 = r.Length / 2;
                var i2 = i1 + 1;

                return (decimal) (r[i1-1] + r[i2-1]) / 2;
            }
            else
            {
                var i = r.Length % 2;
                return r[i+1];
            }
        }
    }
    
```


#### LinkedList
``` c#
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
```

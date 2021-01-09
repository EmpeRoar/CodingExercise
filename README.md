# Coding Exercise


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

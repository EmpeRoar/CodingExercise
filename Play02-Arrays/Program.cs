

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Play02_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1, 2};
            var arrL = new List<int>();
            arrL = arr.ToList();
            arrL.Add(3);
            System.Console.WriteLine(String.Join(",", arrL.ToArray()));
        }
    }
}
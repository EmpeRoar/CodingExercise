﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MedainOfArray
{
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
}
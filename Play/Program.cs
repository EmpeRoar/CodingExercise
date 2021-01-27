using System;
using System.Collections.Generic;
using System.Linq;

namespace Play
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 888;
            var list = new List<string>(){
                $"Hello {i}",
                $"World {i}"    
            };

            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var listOfNumbers = new int[arr.Length - 4];

            // source arr
            // source index
            // dest arr
            // dest index
            // size

            Array.Copy(arr, 4, listOfNumbers, 0, arr.Length - 4);
            

            var strs = "1, 2, 3, 4, 5, 6";
            var strArr = strs.Split(",");

            foreach(var str in strArr){
                Console.WriteLine($"--{str.Trim()}--");
            }

            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}

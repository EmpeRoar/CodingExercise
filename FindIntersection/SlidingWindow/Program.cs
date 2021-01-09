using System;
using System.Collections.Generic;
using System.Linq;

namespace SlidingWindow
{
    class Program
    {
        private static List<double> result = new List<double>();
        private static int[] listOfNumbers { get; set; }
        private static int n = 0;
        private static int sw = 0;
        public static string ArrayChallenge(int[] arr)
        {
            sw = arr[0];
            listOfNumbers = new int[arr.Length - 1];
            Array.Copy(arr,1, listOfNumbers, 0, arr.Length-1);
            int i = 1;           
            while(i < sw)
            {
                result.Add(i);
                i++;
            }           
            var currentWindow = GetSlidingWindow(listOfNumbers);
            result.Add(GetMedianFromCurrentWindow(currentWindow));
            GetNextSlidingWindow();
            return String.Join(", ", result.ToArray());
        }

        private static void GetNextSlidingWindow()
        {
            n++;
            var currentWindow = GetSlidingWindow(listOfNumbers);
            if(currentWindow != null)
            {
                result.Add(GetMedianFromCurrentWindow(currentWindow));
                GetNextSlidingWindow();
            }            
        }

        private static double GetMedianFromCurrentWindow(int[] window)
        {
            Array.Sort(window);
            if ((window.Length % 2) == 0)
            {
                var i1 = window.Length / 2;
                var i2 = i1 + 1;
                return (double)(window[i1 - 1] + window[i2 - 1]) / 2;
            }
            else
            {
                var i = (window.Length - 1) / 2;
                return window[i];
            }
        }

        private static int[] GetSlidingWindow(int[] listOfNumbers)
        {
            try
            {
                var w = new int[sw];
                Array.Copy(listOfNumbers, n, w, 0, sw);
                return w;
            }
            catch
            {
                return null;
            }            
        }

        static void Main(string[] args)
        {
            // Console.WriteLine(ArrayChallenge(new int[] { 5, 2, 4, 6 }));
            Console.WriteLine(ArrayChallenge(new int[] { 3, 1, 3, 5, 10, 6, 4, 3, 1 }));
            // "1,2,3,5,6,6,4,3"
            Console.ReadLine();
        }
    }
}
/*
 
Have the function ArrayChallenge(arr) read the array of numbers stored in arr which will 
contain a sliding window size, N, as the first element in the array and the rest will be a 
list of numbers. 

Your program should return the Moving Median for each element based on the 
element and its N-1 predecessors, where N is the sliding window size. 

The final output should 
be a string with the moving median corresponding to each entry in the original array separated by commas.

Note that for the first few elements (until the window size is reached), the median is computed 
on a smaller number of entries. 
For example: if arr is [3, 1, 3, 5, 10, 6, 4, 3, 1] then your program should output "1,2,3,5,6,6,4,3"


Input: new int[] {5, 2, 4, 6}
Output: 2,3,4

Input: new int[] {3, 0, 0, -2, 0, 2, 0, -2}
Output: 0,0,0,0,0,0,0

 */

/*
                               = 1
                               = 2
1, 3,  5                       = 3
   3,  5,  10                  = 5
       5,  10,  6              = 6  (6 because its sorted)
           10,  6,  4          = 6 
                6,  4,  3      = 4
                    4,  3,  1  = 3
            
---------------------------------------      
              = 2
              = 3,
              = 4
5, 2, 4, 6  

*/



/*
 # 2

Have the function ArrayChallenge(arr) take the array of positive integers stored in arr and return the length of the longest increasing subsequence (LIS). 
A LIS is a subset of the original list where the numbers are in sorted order, from lowest to highest, and are in increasing order. 
The sequence does not need to be contiguous or unique, and there can be several different subsequences. For example: if arr is [4, 3, 5, 1, 6] 
then a possible LIS is [3, 5, 6], and another is [1, 6]. For this input, your program should return 3 because that is the length of the longest increasing subsequence.
 

Input: new int[] {9, 9, 4, 2}
Output: 1

Input: new int[] {10, 22, 9, 33, 21, 50, 41, 60, 22, 68, 90}
Output: 7

 */
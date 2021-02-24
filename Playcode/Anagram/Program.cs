using System;
using System.Linq;

namespace Anagram
{
    /// <summary>
    /// This is the Program!!!
    /// </summary>
    class Program
    {
        /// <summary>
        /// This function is to determine if the 2 strings are Anagram
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        static bool IsAnagram(string str1, string str2)
        {
            var str1R = str1.ToLower().ToArray();
            var str2R = str2.ToLower().ToArray();
            Array.Sort(str1R);
            Array.Sort(str2R);

            return new string(str1R) == new string(str2R);
        }

        /// <summary>
        /// This is the Main Function!!!
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("Jupiter", "rupjite"));
            Console.ReadLine();
        }
    }
}

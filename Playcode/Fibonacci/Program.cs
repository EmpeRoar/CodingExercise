using System;

namespace Fibonacci
{
    class Program
    {
        // 0, 1, 1, 2, 3, 5, 8, 13, 21
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;

            Console.WriteLine($"{a}");
            
            for (int i = 0; i <= 10; i++)
            {
                int temp = a;
                a = b;
                b = temp + a; // next iteration...

                // temp = 1;
                // a = 2;
                // b = 1 + 2 = 3;
                Console.WriteLine($"{a}");
                // 1,1,2
            }


            Console.ReadLine();
        }
    }
}

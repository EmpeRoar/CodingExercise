using System;

namespace Constr
{
    public class BaseClass
    {
        public BaseClass(string val)
        {
            Console.WriteLine($"I am Base!! {val}");
        }

        public int Add(int var1, int var2)
        {
            return var1 + var2;
        }
    }

    public class ChildClass : BaseClass
    {
        public ChildClass(string val) : base(val)
        {
            Console.WriteLine($"I am Child!!! {val}");
        }

        public int Multiply(int var1, int var2)
        {
            return var1 * var2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //BaseClass b = new ChildClass("Hello World!!!");
            //b.Add(1, 1);

            ChildClass c = (ChildClass) new BaseClass("Hello Child Class");
            c.Multiply(2, 2);
            Console.ReadLine();
        }
    }
}

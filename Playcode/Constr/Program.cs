using System;

namespace Constr
{
    public class BaseClass
    {
        protected string _baseVal;
        public BaseClass(string val)
        {
            _baseVal = val;
            Console.WriteLine($"I am Base!! {val}");
        }

        //public int Add(int var1, int var2)
        //{
        //    return var1 + var2;
        //}
    }

    public class ChildClass : BaseClass
    {
        private string _val;
        public ChildClass(string val) : base(val)
        {
            _val = val;
            Console.WriteLine($"I am Child!!! {val}");
        }

        public string Say()
        {
            var v = _baseVal;
            return $"{_val} {v}";
        }

        //public int Multiply(int var1, int var2)
        //{
        //    return var1 * var2;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            //BaseClass b = new ChildClass("Hello World!!!");
            //b.Add(1, 1);

            //ChildClass c = (ChildClass) new BaseClass("Hello Child Class");
            //c.Multiply(2, 2);

            var c = new ChildClass("Hello");
            Console.WriteLine(c.Say());
            Console.ReadLine();
        }
    }
}

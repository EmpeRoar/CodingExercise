using System;
using System.Collections.Generic;
using System.Linq;

namespace Play
{
    public class Dog
    {
        public string Name { get; set; }
        public DateTime DT { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var str = new List<Dog>()
            {
                new Dog(){ Name = "JL", DT = DateTime.Now },
                new Dog(){ Name = "EG", DT = DateTime.Now }
            };

            

            var names = str.Select(x => x.Name).ToList();
            var many = str.SelectMany(x => x, (o, z) => new { o.Name, z  }).ToList();

            Console.WriteLine(String.Join(",", names.ToArray()));
            Console.WriteLine(String.Join(",", many.ToArray()));

            Console.ReadLine();
        }
    }
}

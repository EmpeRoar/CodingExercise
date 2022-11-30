using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictio
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Employee, List<Preference>> preferences = new Dictionary<Employee, List<Preference>>();
            preferences.Add(new Employee() { Name = "Vlad" }, new List<Preference>() { new Preference() { Name = "Milk" } });
            preferences.Add(new Employee() { Name = "Meme" }, new List<Preference>() { new Preference() { Name = "Toothbrush" } });

            Preference memesPreference = preferences.SingleOrDefault(x => x.Key.Name == "Meme").Value.FirstOrDefault();

            Console.WriteLine($"---{memesPreference.Name}---");
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class Preference
    {
        public string Name { get; set; }
    }
}

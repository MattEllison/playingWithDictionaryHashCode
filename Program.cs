using System;
using System.Collections.Generic;
namespace DictionaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var matt = new Person("matt");
            var dictionary = new Dictionary<Person, string>();
            dictionary.Add(matt, "oh yea");

            var anotherMatt = new Person("matt");
            Console.WriteLine(dictionary[matt]);

        }
    }

    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }


        public string Name { get; set; }
        public override bool Equals(object obj)
        {
            if (obj is Person p)
            {
                return p.Name == Name;
            }
            return false;
        }


        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                

                if (person.Age > 30)
                {
                    list.Add(person);
                }
            }
            foreach (var person in list.OrderBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}

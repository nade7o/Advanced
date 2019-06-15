using System;

namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();

                string memberName = data[0];
                int memberAge = int.Parse(data[1]);

                Person member = new Person(memberName, memberAge);

                family.AddMember(member);
            }
            Person oldestFamilyPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestFamilyPerson.Name} {oldestFamilyPerson.Age}");
        }
    }
}

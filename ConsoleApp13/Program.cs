using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Person> personRepository = new Repository<Person>();

            personRepository.Add(new Person("John", 25));
            personRepository.Add(new Person("Alice", 30));
            personRepository.Add(new Person("Bob", 22));

            List<Person> result = personRepository.Find(p => p.Age > 25);

            Console.WriteLine("Persons older than 25:");
            foreach (Person person in result)
            {
                Console.WriteLine($"{person.Name}, {person.Age} years old");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_11_Constants__fields__and_structures_for_reading
{
    internal class Program
    {
        class Person
        {
            public const string type = "Person";
            public string name = "Undefined";
            public void Print() => Console.WriteLine($"{type}: {name}");
        }
        
        class Person2
        {
            public readonly string Male = "Men";
            
        }

        static void Main(string[] args)
        {

            Person tom = new Person();
            tom.name = "Tom";
            tom.Print();    // Person: Tom
            Console.WriteLine(Person.type);
            Person2 j = new Person2();
            
        }
    }
}

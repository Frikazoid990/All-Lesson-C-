using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MT_4_structures
{
    internal class Program
    {

        struct Person
        {
            public string name;
            public int age;

            public Person()
            {
                name = "Tom";
                age = 12;
            }

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public void Print()
            {
                Console.WriteLine($"Имя: {name} | Возраст: {age}");
            }
        }

        static void Main(string[] args)
        {
            Person tom = new Person { name = "Tom", age = 22 };
            Person Tom = new Person("Tom", 19);
            Person Ben = Tom with {name = "Ben" };
            tom.Print();
            Ben.Print();
            Tom.Print();
         
        }
    }
}

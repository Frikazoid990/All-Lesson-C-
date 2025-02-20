using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_10_Static_members_and_modifier_STATIC
{
    internal class Program
    {
        class Person1
        {
            public int age = 25;
            public static int retirementAge = 65;
            public Person1(int age)
            {
                this.age = age;
            }
            public void CheckAge()
            {
                if (age >= retirementAge)
                    Console.WriteLine("Уже на пенсии");
                else
                    Console.WriteLine($"Сколько лет осталось до пенсии: {retirementAge - age}");
            }
        }

        class Person
        {
            public int age = 25;

            static int retirementAge = 65;

            public static int RetriementAge
            {
                get
                {
                    return retirementAge;
                }
                set
                {
                    if(value > 1 && value < 100) 
                        retirementAge = value;
                }
            }
            public void CheckAge()
            {
                if (age >= retirementAge)
                    Console.WriteLine("Уже на пенсии");
                else
                    Console.WriteLine($"Сколько лет осталось до пенсии: {retirementAge - age}");
            }
        }

        static void Main(string[] args)
        {

            Person bob = new();
            bob.age = 15;
            bob.CheckAge();     // Уже на пенсии

            Person tom = new();
            tom.CheckAge();     // Сколько лет осталось до пенсии: 28

            // получение статического поля
            Console.WriteLine(Person.RetriementAge); // 65                                      
            Person.RetriementAge = 69;  // изменение статического поля
            bob.CheckAge();


        }
    }
}

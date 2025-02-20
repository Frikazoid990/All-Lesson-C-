using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1_Class
{
    class Person
    {
        public string name = "Undefined"; // имя
        public int age; //возраст
        public void Print()
        {
            Console.WriteLine($"Имя: {name} | Возраст: {age}");
        }


    }
    internal class Program
    {
        static Person tom = new Person();
        static void Main(string[] args)
        {
            Person person = new Person();
            person.age = 15;
            person.name = "Andrey";
            person.Print();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    class Person
    {
        public string name = "Undefind"; // имя
        public int age; //возраст
        public void Print()
        {
            Console.WriteLine($"Имя: {name} | Возраст: {age}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_OOP_02
{
    public class Person
    {
        public string name { get; set; }

        
        public Person(string name)
        {
            this.name = name;
        }

        public void Print()
        {
            Console.WriteLine(name);
        }
    }
}

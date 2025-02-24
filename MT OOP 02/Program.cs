using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_OOP_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Person("Bob");
            bob.Print();    // Name: Bob

            Employee tom = new Employee("Tom", "Microsoft");
            tom.Print();    // Name: Tom  Company: Microsoft
        }
    }
}

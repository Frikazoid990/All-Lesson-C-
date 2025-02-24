using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_OOP_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee("Bob", "Microsoft");

            //employee1.Print();

            Person person1 = employee1;

            person1.Print();

        }
    }
}

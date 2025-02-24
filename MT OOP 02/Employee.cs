using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_OOP_02
{
    public class Employee : Person
    {
        public string company { get; set; } = "Unknow";
        public Employee(string name, string company) : base(name)
        {
            this.company = company;
        }

        public new void Print()
        {
            Console.WriteLine($"Name: {name}, Company: {company}");
        }
    }
}

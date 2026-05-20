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
            var person1 = new Person();
            person1.Name = "Tom";
            person1.Print();
            person1 = new Employee();
            person1.Print();
        
            var emp =  new Employee();

            emp.position = "Junior backend dev";
            emp.Name = "Tom";
        
            emp.PrintEmployeePositionAndName();
        
            // emp = new Person();
        
            // emp = (Employee)new Person();
        }
    }

    class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Print()
        {
            Console.WriteLine($"Hello! {Name}");
        }
    }

    class Employee : Person
    {
        public string position { get; set; }

        public void PrintEmployeePositionAndName()
        {
            Console.WriteLine($"Employee position {position}\n" +
                              $"Employee name {Name}"); // -- here we can take accessing base class members
        }
    }
    
    //keyword base
    class PersonBase
    {
        public string Name { get; set;}
        public PersonBase(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine(Name);
        }
    }
    
    class EmployeeBase : PersonBase
    {
        public string Company { get; set; }
        public EmployeeBase(string name, string company)
            : base(name)
        {
            Company = company;
        }
    }
}


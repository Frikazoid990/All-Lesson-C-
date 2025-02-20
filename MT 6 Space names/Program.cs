using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base1;


// https://metanit.com/sharp/tutorial/3.25.php

namespace MT_6_Space_names
{
    using global::Base;
    internal class Program
    {

        static void Main(string[] args)
        {
            Person1 Gin = new Person1("Gin");
            Person Tom = new Person("Tom");
            Tom.Print(); 
            Gin.Print();
        } 
    }


}

namespace Base
{
    class Person
    {
        string name;
        public Person(string name) => this.name = name;
        public void Print() => Console.WriteLine($"Имя: {name}");
    }
}


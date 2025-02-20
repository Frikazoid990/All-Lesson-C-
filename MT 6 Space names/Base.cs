using System;

namespace Base1 
{
    class Person1
    {
        string name;
        public Person1(string name) => this.name = name;
        public void Print() => Console.WriteLine($"Имя: {name} ");
    }

}


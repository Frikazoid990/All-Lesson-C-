using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_OOP_03._02_Generic
{
    public class Person<T>
    {
        public T Id { get; }

        public Person(T Id)
        {
            this.Id = Id;
        }
    }

    public class UniversalPerson<T> : Person<T>
    {
        public UniversalPerson(T Id) : base(Id)
        {
        }
    }

    public class StringPerson : Person<string>
    {
        public StringPerson(string Id) : base(Id)
        {
        }
    }

    public class IntPerson<T> : Person<int>
    {
        public T code { get; set; }
        public IntPerson(int Id, T code) : base(Id)
        {
            this.code = code;
        }
    }
}

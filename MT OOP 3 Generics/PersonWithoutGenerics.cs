using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_OOP_3_Generics
{
    public class PersonWithoutGenerics
    {
        public int Id { get; }
        public string Name { get; }
    
        public PersonWithoutGenerics(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}

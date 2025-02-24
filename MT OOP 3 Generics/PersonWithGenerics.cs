using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_OOP_3_Generics
{
    public class PersonWithGenerics
    {
        public object Id { get; }
    
        public string Name { get; }
    
        public PersonWithGenerics(object id, string name)
        {
            Id = id;
            Name = name;
        }


    }

}

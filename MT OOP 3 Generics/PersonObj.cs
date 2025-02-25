using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_OOP_3_Generics
{
    public class PersonObj
    {
        public object Id { get; }
    
        public string Name { get; }
    
        public PersonObj(object id, string name)
        {
            Id = id;
            Name = name;
        }


    }

}

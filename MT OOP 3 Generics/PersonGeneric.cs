using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_OOP_3_Generics
{
    /*
     * В общем говоря T или S - это универсальные типы
     * Т.е при создании объекта
     * PersonGeneric<int, string> Name = new PersonGeneric<int, string>(data, data...);
     * Как можно увидеть вместо T или S стоит определенный тип, так мы получаем, что для нужного нам объекта, мы можем Id иницилизировать как int,string...
     * Так же если мы указываем универсальный тип, то в целом не обязаны его использовать внутри классса
    */
    public class PersonGeneric<T,S>
    {
        public T Id { get; set; }

        //public S Country { get; set; }
        public string Name { get; set; }

        public PersonGeneric(T id, string name )
        {
            Id = id;
            Name = name;
        }
    }
}

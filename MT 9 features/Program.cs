using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_9_Propertys
{
    class Person
    {
        public string FirstName
        {
            get;
            set
            {
                field = value;
            }
        } = "Jane";


        int age = 1;
        public int Age
        {
            set
            {
                if (value < 1 || value > 120)
                    Console.WriteLine("Возраст должен быть в диапазоне от 1 до 120");
                else
                    age = value;
            }
            get { return age; }
        }
    }

    class Person1
    {
        string firstName;
        string lastName;
        public string FullName
        {
            get { return $"{firstName} {lastName}"; }

        }
        public Person1(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
    class Person2
    {
        string name = "";
        public string Name
        {
            get { return name; }

            private set { name = value; }
        }
        public Person2(string name) => Name = name;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine(person.Age);  // 1
                                            // изменяем значение свойства
            person.Age = 37;
            Console.WriteLine(person.Age);  // 37
                                            // пробуем передать недопустимое значение
            person.Age = -23;               // Возраст должен быть в диапазоне от 1 до 120
            Console.WriteLine(person.Age);  // 37 - возраст не изменился

            Person1 Tim = new Person1("Tim", "Smith");
            Console.WriteLine(Tim.FullName);

            Person2 TTT = new Person2("tom");
            //TTT.Name = "Bob"; // Вот тут выдаст ошибку

        }
    }
}

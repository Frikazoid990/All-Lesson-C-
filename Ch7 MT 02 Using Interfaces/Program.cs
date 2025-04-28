using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_MT_02_Using_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IMovable m = new IMovable(); // Ошибка так делать нельзя

            Person person = new Person();
            Car car = new Car();
            DoAction(car);
            DoAction(person);

            IMovable tom = new Person();
            Car tesla = new Car();
            tom.Move();     //Walking
            tesla.Move();   //Driving


            Message hello = new Message("Hello");
            hello.Print();

            // Все объекты Message являются объектами IMessage
            IMessage hello1 = new Message("Hello METANIT.COM");
            Console.WriteLine(hello1.Text); // Hello METANIT.COM

            // Не все объекты IMessage являются объектами Message, необходимо явное приведение
            // Message someMessage = hello; // ! Ошибка
            // Интерфейс IMessage не имеет свойства Print, необходимо явное приведение
            // hello.Print();  // ! Ошибка

            // если hello представляет класс Message, выполняем преобразование
            if (hello1 is Message someMessage) someMessage.Print();

        }

        interface IMessage
        {
            string Text { get; }
        }

        interface IPrintable
        {
            void Print();
        }

        class Message : IPrintable, IMessage
        {
            public string Text { get; }

            public Message(string text)
            {
                Text = text;
            }

            public void Print() => Console.WriteLine(Text);

        }

        static void DoAction(IMovable movable) => movable.Move(); 

        interface IMovable
        {
            void Move() => Console.WriteLine("Walking");
        }
        class Person : IMovable { }
        struct Car : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Driving");
            }
        }
    }
}

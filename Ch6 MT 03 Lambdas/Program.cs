using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_MT_03_Lambdas
{
    //Лямбда-выражения представляют упрощенную запись анонимных методов. Лямбда-выражения позволяют создать емкие лаконичные методы,
    //которые могут возвращать некоторое значение и которые можно передать в качестве параметров в другие методы.
    class Program
    {
        delegate void Message();
        delegate void Operation(int n1, int n2);
        delegate void PrintHandler(string message);
        delegate int Operation1(int x, int y);
        static void Main(string[] args)
        {
            //Лямбды

            Message hello = () => Console.WriteLine("hello");
            hello();
            hello();
            hello();
            //----------------------------------------
            //Параметры лямбды
            Operation sum = (x,y) => Console.WriteLine($"{x} + {y} = {x + y}");
            sum(1, 2);
            sum(3, 4);

            PrintHandler print = message => Console.WriteLine(message);
            print("Hello");         // Hello
            print("Welcome");       // Welcome
            
            var welcome = (string message = "hello") => Console.WriteLine(message); //C# version 12.0
            welcome("hello world"); // hello world
            welcome();              // hello
            //----------------------------------------
            //Возвращение результата
            var sum1 = (int x, int y) => x + y;
            int sumResult = sum1(4, 5);                  // 9
            Console.WriteLine(sumResult);               // 9

            Operation1 multiply = (x, y) => x * y;
            int multiplyResult = multiply(4, 5);        // 20
            Console.WriteLine(multiplyResult);          // 20

            var subtract = (int x, int y) =>
            {
                if (x > y) return x - y;
                else return y - x;
            };
            int result1 = subtract(10, 6);  // 4 
            Console.WriteLine(result1);     // 4

            int result2 = subtract(-10, 6);  // 16
            Console.WriteLine(result2);      // 16

            //Добавление и удаление действий в лямбда-выражении
            var hello1 = () => Console.WriteLine("METANIT.COM");

            var message = () => Console.Write("Hello ");
            message += () => Console.WriteLine("World"); // добавляем анонимное лямбда-выражение
            message += hello1;   // добавляем лямбда-выражение из переменной hello
            message += Print;   // добавляем метод

            message();
            Console.WriteLine("--------------"); 

            message -= Print;   // удаляем метод
            message -= hello1;   // удаляем лямбда-выражение из переменной hello

            message?.Invoke();  // на случай, если в message больше нет действий

            void Print() => Console.WriteLine("Welcome to C#");
        }
    }
}

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

        static int Sum(int[] numbers, IsEqual func)
        {
            int result = 0;
            foreach (int i in numbers)
            {
                if (func(i))
                    result += i;
            }
            return result;
        }

        delegate bool IsEqual(int x);

        static void Main(string[] args)
        {
            //Лямбды
            Message hello = () => Console.WriteLine("hello");
            hello();
            hello();
            hello();
            Console.WriteLine("--------------");
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
            Console.WriteLine("--------------");
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
            Console.WriteLine("--------------");

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

            //----------------------------------------
            Console.WriteLine("--------------");
            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // найдем сумму чисел больше 5
            int result3 = Sum(integers, x => x > 5);
            Console.WriteLine(result3); // 30

            // найдем сумму четных чисел
            int result4 = Sum(integers, x => x % 2 == 0);
            Console.WriteLine(result4);  //20
            Console.WriteLine("--------------");
            //----------------------------------------
            //Лямбда-выражение как результат метода


        }
    }
}

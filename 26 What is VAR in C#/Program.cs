using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_What_is_VAR_in_C_
{

    /* Локальные переменные можно объявлять без указания конкретного типа.
    Ключевое слово var указывает, что компилятор должен вывести тип переменной из выражения
    Справа от оператора инициализации. Выведенный тип может быть встроенным, анонимным,
    определяемым пользователем либо типом, определяемым в библиотеке классов .NET.
    */

    class Person
    {

    }

    internal class Program
    {
        static int Sum(int a, int b)
        {
            int result = a + b;
            
            return result; 
        }

        static void Main(string[] args)
        {
            // не всегда var выбирает подходящий тип данных

            //byte a = 100;

            //var b = 100;

            //double c = 500;

            //var d = 500;

            //Console.WriteLine(a.GetType());

            //Console.WriteLine(b.GetType());

            //Console.WriteLine(c.GetType());

            //Console.WriteLine(d.GetType());

            //var values = new List<int>();

            int result = Sum(1, 2);
            Console.WriteLine(result);


        }
    }
}

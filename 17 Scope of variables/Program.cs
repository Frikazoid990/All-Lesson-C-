using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Scope_of_variables // Тема будет звучать как Контекст или область видимости
{
    internal class Program
    {
        // Контекст класаа это то где сейчас пишется эта небольшая инструкция
        // То есть мы внутри класса Program и область внутри этого класса называется контекст
        //  Включая методы


        static int a = 10;

        static void number()
        {
            int b = 7;
            Console.WriteLine(b);
        }






        static void Main(string[] args)
        {
            // Тут же идет контекст метода(функции) Main
            int a = 5; // Переменные созданные в методе с одним и тем же названием что и глобальная переменная имеет больший приоритет 

            Console.WriteLine(a);

            number();

        }
    }
}

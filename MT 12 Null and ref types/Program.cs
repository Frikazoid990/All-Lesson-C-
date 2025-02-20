#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_12_Null_and_ref_types
{
    internal class Program
    {




        static void Main(string[] args)
        {
            //string name = null;
            //Console.WriteLine(name);

            //string? name1 = null;
            //Console.WriteLine(name1);    // ничего не выведет

            //string? UName = Console.ReadLine(); 

            /*
            Оператор ?
            Чтобы определить переменную/параметр ссылочного типа, как переменную/параметр, которым можно присваивать значение null, 
            после названия типа указывается знак вопроса ?
            */
            void PrintUpper1(string? text)
            {
                Console.WriteLine(text.ToUpper());
            }
            string? name1 = null;
            PrintUpper1(name1);

            /*
            Оператор ! (null-forgiving operator)
            позволяет указать, что переменная ссылочного типа не равна null:
            */

            void PrintUpper2(string text)
            {
                if (text == null) Console.WriteLine("null");
                else Console.WriteLine(text.ToUpper());
            }

            string? name2 = null;

            PrintUpper2(name2!);


            /*
            Исключение кода из nullable-контекста
            С помощью специальной директивы #nullable disable 
            можно исключить какой-то определенный 
            кусок кода из nullable-контекста. Например:
            */

            #nullable disable
            string text = null; // здесь nullable-контекст не действует
            #nullable restore

            string? name = null;   // здесь nullable-контекст снова действует

        }
    }
}

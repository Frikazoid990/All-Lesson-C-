using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_What_is_NULL_Part2__Chek_NULL_
{
    internal class Program
    {
        // оператор null - объединения ?? - позволяет установить default значения для ссылочных типов 
        
        // оператор присваивания объединения со значением NULL ?=

        // оператор условного NULL ?

        static void Main(string[] args)
        {


            // NULL объединение 
            //string str = null ?? "Nothing";
            string str = "test";
            //Console.WriteLine(str ?? "Nothing");
            // NULL ?=
            string str2 = str ??= "Нет данных";
            Console.WriteLine(str);

            int[] array = null;
            Console.WriteLine($"Сумма элементов массива : {   array?.Sum() ?? 0   }");
            Console.ReadKey();


        }
        static int[] CreateArray()
        { 
            return new int[] { 1, 2 ,3 ,4, 5 ,6}; 
        }
    }
}

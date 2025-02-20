using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _18_Value_and_reference_types // Значимые и ссылочные типы
{
    internal class Program
    {
       
        static void Bar (int value)
        {
            value = 5;
        }

        static void Foo (int[] array)
        {
            array[0] = 6;
        }

        static void Main(string[] args)
        {
            int a = 10;

            Bar (a);

            Console.WriteLine(a);

            int [] b = { 1, 2, 3};
            Console.WriteLine(b[0]);
            Foo(b);
            Console.WriteLine(b[0]);











            //===============================================================|
            // Это начало урока, так что если интересно просто раскоментируй |
            //===============================================================|
            //int a = 10;

            //int b = a;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //b = 5;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int[] c = { 10, 20, 30, 40, 50 };
            //int[] d;
            //d = c;

            //for (int i = 0; i < c.Length; i++)
            //{
            //    Console.WriteLine(c[i]);
            //}
            //Console.WriteLine("----------------------");
            //for (int i = 0; i < d.Length; i++)
            //{
            //    Console.WriteLine(d[i]);
            //}
            //Console.WriteLine("----------------------");
            //c[0] = 1;
            //d[4] = 5;

            //for (int i = 0; i < c.Length; i++)
            //{
            //    Console.WriteLine(c[i]);
            //}
            //Console.WriteLine("----------------------");
            //for (int i = 0; i < d.Length; i++)
            //{
            //    Console.WriteLine(d[i]);
            //}


        }
    }
}

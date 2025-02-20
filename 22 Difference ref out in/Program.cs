using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Difference_ref_out_in
{
    internal class Program
    {   
        class Example
        {
            public decimal number1;
            public decimal number2;
            public decimal number3;
            public decimal number4;
            public decimal number5;
        }

        static void ReadValue1 (Example example)
        {
            
        }

        static void ReadValue2(in Example example)
        {
            
        }


        //модификаторы out и in
        static void ReadValue(in int a)
        {

            Console.WriteLine(a);
        }
        
        static void Main(string[] args)
        {
            Example ex1 = new Example();

            Stopwatch sw = new Stopwatch();

            sw.Start();

            for (int i = 0; i < int.MaxValue; i++)
            {
                ReadValue1(ex1);
            }

            Console.WriteLine($"{sw.ElapsedMilliseconds}");

            sw.Restart();

            sw.Stop();
            /*--------------------------*/

            sw.Start();
            for (int i = 0; i < int.MaxValue; i++)
            {
                ReadValue2(in ex1);
            }
            Console.WriteLine($"{sw.ElapsedMilliseconds}\n");
            sw.Restart();
            sw.Stop();
            //int number = 100;
            //ReadValue(in number);

        }
    }
}

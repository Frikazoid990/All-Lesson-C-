using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_MT_01_Delegates
{
    class Program
    {

         public delegate void Message();

        delegate int Operation(int x, int y);


        public class Welcome
        {
            public static void Print() => Console.WriteLine("Welcome");
        }
        class Hello
        {
            public void Display() => Console.WriteLine("Привет");

            //s
        }

        static void HelloM() => Console.WriteLine("Hello METANIT.COM");
        static void Main(string[] args)
        {
            
            Message mes1 = Welcome.Print;
            mes1();

            mes1 = HelloM;
            mes1();

            mes1 = new Hello().Display;
            mes1();
            
        }


    }

}

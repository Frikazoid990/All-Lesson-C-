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

        delegate void Message(string m);

        static void Hello(string message) => Console.WriteLine($"{message}");

        static void Main(string[] args)
        {
            Message mes;
            mes = Hello;

            mes("22");
            
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * while
             * do while 
             * for
             * foreach
             */

            int a = 3;
            while (a <= 2)
            { 
                a++;
                Console.WriteLine(a);
            }
            do
            {
                Console.WriteLine("Выполнился");
            }
            while (a <= 1);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Overloading_methods
{
    internal class Program
    {
        static int Sum(int n1, int n2)
        {
            int result = n1 + n2;
            return result;
        }
        static int Sum(int n1, int n2, int n3)
        {
            int result = n1 + n2 + n3;
            return result;
        }

        static double Sum (double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 7;
            int f = 5;

            int c = Sum(a, b);
            Console.WriteLine(c);
            
            int d = Sum(a, b, f);
            Console.WriteLine(d);


            double y = Sum(3.6, 2.7);
            Console.WriteLine(y);
        }
    }
}

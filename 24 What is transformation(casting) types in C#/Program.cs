using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_What_is_transformation_casting__types_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 11;

            float n2 = 5f;

            int result = n1 + (int)n2;

            Console.WriteLine(result);
        }
    }
}

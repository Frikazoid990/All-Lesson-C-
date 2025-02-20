using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyword_Reference_ref_
{
    internal class Program
    {
        static void ChangeValue(int[] array)
        {
            //array[0] = 6;
            array = null;
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 6, 5 };
            Console.WriteLine(array[0]);
            
            ChangeValue(array);

            Console.WriteLine(array[0]);

             
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_What_is_Nullable_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Nullable<int> a = null;
            int? number = null;

            //int number2 = (int)number;
            //Console.WriteLine(number2); //ошибка

            int? number2 = null;

            int? result = number + number2;

            Console.WriteLine(result);

            //Console.WriteLine(number.HasValue);

            ////Console.WriteLine(number);
            ////Console.WriteLine(number.Value);

            //Console.WriteLine(number.GetValueOrDefault(100));

            //Console.WriteLine(number);




        }
    }
}

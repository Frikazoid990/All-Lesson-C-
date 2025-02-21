using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN_02_Types
{
    class Program
    {

        static void Main(string[] args)
        {
            byte b = 3; //00 00 00 11
            int i = b; // 0000 0000 0000 0000 0000 0000 0000 0011
            long l = i; // 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011

            float f = i; //3.0

            //Console.WriteLine(f);


            b = (byte)i;
            //Console.WriteLine(b);

            i = (int)f;
            //Console.WriteLine(i);

            f = 3.1f;
            i = (int)f;
            Console.WriteLine(i);

            string str = "1";
            //i = (int)str; Error не явнное преобразование
            i = Convert.ToInt32(str);

            int x = 5;
            int result = x / 2;


        }
    }
}

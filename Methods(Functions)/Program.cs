using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Functions_
{
    internal class Program
    {

        static int Sum (int n1, int n2)
        {
            int result = n1 + n2;
            return result;
        }
        void Hello(string name, int age, string city)
        {
            Console.WriteLine("Привет {0} тебе {1} ты из города {2}",name,age,city);
            Console.WriteLine($"Привет {name} тебе {age} ты из города {city}");
        }

        static void HW(char a, int j)
        {
            int i = 0;
            for (i = 0; i < j; i++)
            {
                Console.Write(a + " ");
            }
            i = 0;
            Console.WriteLine();
            while ( i != j)
            {
                Console.Write(a+" ");
                i++;
            }

            Console.WriteLine($"\nСимвол {a} вывелся {j} раз");
        }


        static void Main(string[] args)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Sum(a, b);
            //Console.WriteLine(c);

            //string name = Console.ReadLine();
            //int age = 18;
            //string city = "Moscow";

            //Program pr = new Program();
            //pr.Hello(name, age, city);

            char Symbol = Convert.ToChar(Console.ReadLine());
            int Quol = Convert.ToInt32(Console.ReadLine());
            HW(Symbol, Quol);

            
        }
    }
}

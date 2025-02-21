using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EN_02_Types
{
    class Program
    {

        static void Main(string[] args)
        {

        }

        static void HomeWork3()
        {
            Console.Write("Name:");
            string Name = Console.ReadLine();

            Console.Write("Surname:");
            string Surname = Console.ReadLine();

            Console.Write("Age:");
            int Age = int.Parse(Console.ReadLine());

            Console.Write("Weight = ");
            double Weight = double.Parse(Console.ReadLine());

            Console.Write("Height = ");
            double Height = double.Parse(Console.ReadLine());
            Height = Height / 100;

            double BMI = Weight / (Height * Height);


            string UserProfile =
                $"Your Profile:\n" +
                $"FullName: {Surname} {Name}\n" +
                $"Age: {Age} yo\n" +
                $"Weight: {Weight} kg\n" +
                $"Height: {Height} m\n" +
                $"Body Mass Index: {Math.Round(BMI, 3)}";

            Console.WriteLine(UserProfile);
        }
        
        static void HomeWork2()
        {
            Console.WriteLine("Введите длины 3 сторон треугольника");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            double p = (a + b + c) / 2;
            Console.WriteLine($"Полупериметр(p) = {p}");
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Площадь указанного треугольника (S) = {Math.Round(S, 2)}");
        }

        static void HomeWork1()
        {
            Console.Write("Введите имя пользователя:");
            string UserName = Console.ReadLine();
            Console.WriteLine($"Hello, {UserName}\n");

            Console.WriteLine("Введите 2 целых числа:");
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());

            int tmp = x;
            x = y;
            y = tmp;

            Console.WriteLine($"Обмен x на y\n" +
                $"x = {x}\n" +
                $"y = {y}\n");

            Console.Write("Введите целое число:");
            int numb = int.Parse(Console.ReadLine());

            Console.WriteLine($"Количество чисел в числе {numb} - {numb.ToString().Length}");
        }

        static void DateTimeIntro()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine(now.ToString());

            Console.WriteLine($"It`s {now.Year} {now.Month} {now.Day}, {now.Hour}:{now.Minute}");

            DateTime dt = new DateTime(2016, 2, 28);

            DateTime newdt = dt.AddDays(1);

            Console.WriteLine(newdt.Date);

            TimeSpan ts = now - dt;
            ts = now.Subtract(dt);

            Console.WriteLine(ts.Days);
        }

        static void IntroToArray()
        {
            int[] a1;
            a1 = new int[10];


            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 2, 3, 4, 5 };

            int[] a4 = { 1, 3, 4, 5, 2, 10 };

            Console.WriteLine(a4[0]);

            int number = a4[4];

            Console.WriteLine(number);

            a4[4] = 6;
            Console.WriteLine(a4[4]);

            Console.WriteLine(a4.Length);
            Console.WriteLine(a4[a4.Length - 1]);

            string s1 = "abcdefgh";
            char first = s1[0];
            char last = s1[s1.Length - 1];
            Console.WriteLine($"First {first}\nLast {last}");

            //impossible
            //s1[0] = 'z';
        }

        static void MathDemo()
        {
            //Math
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Sqrt(8));

            Console.WriteLine(Math.Round(1.7));
            Console.WriteLine(Math.Round(1.4));
            Console.WriteLine();


            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));
        }

        static void CastingAndParsing()
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
            Console.WriteLine(result);

            double result2 = (double)x / 2;
            Console.WriteLine(result2);
        }
    }
}

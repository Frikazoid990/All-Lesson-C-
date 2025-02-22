using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EN_03_ControlFlow
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во чисел для вычисления");
            int count = int.Parse(Console.ReadLine());
            if(count < 2 || count == 2)
            {
                Console.WriteLine("Вы ввели кол-во меньше или равное двум(2) в таком случае числа фибоначи выглядят так:");
                int[] tmp = new int[2];
                tmp[0] = 0;
                tmp[1] = 1;
                foreach (var i in tmp)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                int[] fibonachi = new int[count];
                fibonachi[0] = 0;
                fibonachi[1] = 1;
                for(int i = 2; i < fibonachi.Length; i++)
                {
                    fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];

                }
                foreach(var i in fibonachi)
                {
                    Console.Write(i + " ");
                }

            }


        }

        static void WhileDoWhile()
        {
            int age = 0;

            while (age < 18)
            {
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Good!");

            do
            {
                Console.WriteLine("do\\while");
                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }
            while (age < 18);

            int[] numbers = { 1, 2, 3, 4, 5 };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.Write(numbers[i] + " ");
                i++;
            }
        }

        static void NestedFor()
        {
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        int atI = numbers[i];
                        int atJ = numbers[j];
                        int atK = numbers[k];
                        if (atI + atJ + atK == 0)
                        {
                            Console.WriteLine($"Pair ({atI};{atJ};{atK}). Indexes ({i};{j};{k})");
                        }

                    }

                }
            }
        }

        static void ForForeach()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }

            }

            Console.WriteLine();
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
        }

        static void HomeWorkGetMax()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            string Answwer = a == b ? $"Числа равны a({a}) = b({b})" : (a > b ? $"Число A max\nA({a})>B({b})" : $"Число B max\nA({a})<B({b})");
            Console.WriteLine(Answwer);
        }

        static void IfElse()
        {
            double BMI = double.Parse(Console.ReadLine());

            bool isTooLow = BMI <= 18.5;
            bool isNormal = BMI > 18.5 && BMI <= 25;
            bool isAboveNormal = BMI >= 25 && BMI <= 30;
            bool isTooFat = BMI > 30;

            bool isFat = isAboveNormal || isTooFat;

            if (isFat)
            {
                Console.WriteLine("You`d better lose some weight");
            }
            else
            {
                Console.WriteLine("Oh, you are in a good shape");
            }
            // if (isFat == false)
            // if(isFat != true)
            if (!isFat)
            {
                Console.WriteLine("You`re definitely not fat!");
            }

            if (isTooLow)
            {
                Console.WriteLine("Not enough weight");
            }
            else if (isNormal)
            {
                Console.WriteLine("You`re ok");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Be careful");
            }
            else
            {
                Console.WriteLine("You need to lose some weight");
            }

            //

            if (isFat || isTooFat)
            {
                Console.WriteLine("Anyway it`s time to get on diet");
            }



            int age = int.Parse(Console.ReadLine());
            //ternary operation
            string description = age > 18 ? "You can drink alcohol" : "You should get a bit older";


            if (age > 18)
            {
                description = "You can drink alcohol";
            }
            else
            {
                description = "You should get a bit older";
            }

            Console.WriteLine(description);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Part_2
{
    internal class Program
    {
        // 1. Способы инициализации массива
        // 1.1 int[] name = new int[value] {value ..., value};
        // 1.2 int[] name = new int[] {value ..., value};
        // 1.2 int[] name = new int[] {value1, value2 ..., valueN};
        // 1.3 int[] name = new int[value] - потом идет заполнение массива;
        
        // 2. заполнение массива через цикл

        // 3. вывод массива через цикл

        // 4. задачи: самое большое число в массиве, вывод массива в обратном порядке, сумма четных чисел в массиве;
        static void Main(string[] args)
        {
            // Варианты заполнения массива
            int a = Convert.ToInt32(Console.ReadLine());
            int[] arrayTest = new int[a];


            //for (int i = 0; i < a; i++)
            //{
            //    //a[i] = Convert.ToInt32(Console.ReadLine()); Так можем заполнять самостоятельно;
            //    arrayTest[i] = i+1;
            //}


            int f = 0;
            while (f < arrayTest.Length)
            {
                arrayTest [f] = f+1;
                f++;
            }

            // Варианты вывода массива

            foreach (int i in arrayTest)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            for (int i = 0; i < arrayTest.Length; i++)
            {
                Console.Write($"{arrayTest[i]} ");
            }
            Console.WriteLine();
            f = 0;
            while (f < a)
            {
                Console.Write($"{arrayTest[f]} ");
                f++;

            }
            Console.ReadKey();
            Console.WriteLine("\nПереходим к задачам");


            int MostBigNumbr=0;
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 10, 20, 13, 12, 15, 40, 31, 2, 1, 3, 4, 5, 6 };
            for (int i = 0;i < array1.Length; i++)
            {
                if ( MostBigNumbr < array1[i])
                {
                    MostBigNumbr = array1[i];
                }
            }
            Console.WriteLine($"Самое большое число в массиве array1: {MostBigNumbr}");

            Console.WriteLine("Массив в обратном порядке:");
            //for (int i = array1.Length-1; i >= 0; i--)
            //{
            //    Console.Write($"{array1[i]} ");
            //}
            // Это просто вывод этого массив, код представленный ниже нужен для того чтобы перевернуть массив программно с присвоением значений




             /* Пояснение к коду ниже 
             * Всё очень просто
             * Мы берем ровно половину массива - это переменная length 
             * После чего начинаем перебирать массив (не забываем использовать буфер - temp
             * В цикле мы сначала запоминаем первый элемент в temp 
             * После чего присваиваем этому элементу зеркальный элемент который находится в конце этого массива([array1.length - 1 - i])
             */

            int length = array1.Length / 2, temp = 0;

            for (int i = 0; i< length-1; i++)
            {   
                temp = array1[i];
                array1[i] = array1[array1.Length-1-i];
                array1[array1.Length - 1 - i] = temp;
            }

            foreach (int i in array1)
            {
                Console.Write($"{i} ");
            }

            /*------------------------------------------*/
            /*------------------------------------------*/
            /*------------------------------------------*/

            // Сумма четных и нечетных чисел в массиве
            int[] array2 = { 1, 2, 3, 4, 5, 6 };
            int sumchet =0;
            int sumnechet = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                if ( array2[i] % 2 ==  0)
                {
                    sumchet = sumchet + array2[i];
                }
                else
                {
                    sumnechet = sumnechet + array2[i];
                }
            }
            Console.WriteLine($"\nСумма четных чисел: {sumchet}\nСумма нечетных чисел: {sumnechet}");

        }
    }
}

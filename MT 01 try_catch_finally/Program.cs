using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_01_try_catch_finally
{
    class Program
    {
        static void Square(string data) 
        {
            if (int.TryParse(data, out int x))
            {
                Console.WriteLine($"Квадрат числа {x}: {x * x}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }

        }

        static void Main(string[] args)
        {
            Square("12");
            Square("ab"); //Exception
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch
            {
                Console.WriteLine($"Возникло исключение!");
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }
            Console.WriteLine("Конец программы");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_02_Block_catch_and_exceptions_filters
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Возникло исключение {ex.Message}");
            }

            //Exception filter

            int r = 1;
            int f = 0;

            try
            {
                int result1 = r / f;
                int result2 = f / r;
            }
            catch (DivideByZeroException) when (f == 0)
            {
                Console.WriteLine("f не должен быть равен 0"); // сработает этот catch т.к f == 0 возвращает true
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            ////
            Console.ReadLine();

            int a = 0;
            int b = 1;

            try
            {
                int result1 = a / b;
                int result2 = b / a;
            }
            catch (DivideByZeroException) when (b == 0)
            {
                Console.WriteLine("y не должен быть равен 0"); 
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);// сработает этот catch т.к b == 0 возвращает false
            }


        }
    }
}

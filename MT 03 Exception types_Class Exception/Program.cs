using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_03_Exception_types_Class_Exception
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
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
                Console.WriteLine($"Method: {ex.Source}");
            }
            /*
             * Виды искючений:
                DivideByZeroException: представляет исключение, которое генерируется при делении на ноль

                ArgumentOutOfRangeException: генерируется, если значение аргумента находится вне диапазона допустимых значений

                ArgumentException: генерируется, если в метод для параметра передается некорректное значение

                IndexOutOfRangeException: генерируется, если индекс элемента массива или коллекции находится вне диапазона допустимых значений

                InvalidCastException: генерируется при попытке произвести недопустимые преобразования типов

                NullReferenceException: генерируется при попытке обращения к объекту, который равен null (то есть по сути неопределен) 
            */

            try
            {
                int[] numbers = new int[4];
                numbers[7] = 9;     // IndexOutOfRangeException

                int x = 5;
                int y = x / 0;  // DivideByZeroException
                Console.WriteLine($"Результат: {y}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();

            try
            {
                object obj = "you";
                int num = (int)obj;     // System.InvalidCastException
                Console.WriteLine($"Результат: {num}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Возникло исключение IndexOutOfRangeException");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
        }
    }
}

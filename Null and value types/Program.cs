using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_and_value_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            В отличие от ссылочных типов переменным/параметрам значимых типов нельзя напрямую присвоить значение null. 
            Тем не менее нередко бывает удобно, чтобы переменная/параметр значимого типа могли принимать значение null.
            Например, получаем числовое значение из базы данных, которое в бд может отсутствовать. 
            То есть, если значение в базе данных есть - получим число, если нет - то null.

            Чтобы присвоения переменной или параметру значимого типа значения null, эти переменная/параметр значимого типа должны представлять тип nullable. 
            Для этого после названия типа указывается знак вопроса ?
            */
            

            int? val3 = null;
            
            Console.WriteLine(val3 ?? 10);

            void IsNull(int? obj)
            {
                if (obj == null) Console.WriteLine("null");
                else Console.WriteLine(obj);
            }

            int? val1 = null;
            IsNull(val1);    // null
            val1 = 22;
            IsNull(val1);    // 22

            /*
            Стоит отметить, что фактически запись ? для значимых типов является упрощенной формой использования структуры System.Nullable<T>. 
            Параметр T в угловых скобках представляет универсальный параметр, вместо которого в программе подставляется конкретный тип данных. 
            Следующие виды определения переменных будут эквивалентны:
            */

            int? number1 = 5;
            Nullable<int> number2 = 5;

            /*
            Свойства Value и HasValue и метод GetValueOrDefault

            Структура Nullable<T> имеет два свойства:

            Value - значение объекта
            HasValue: возвращает true, если объект хранит некоторое значение, и false, если объект равен null.
            */
            void PrintNullable(int? number)
            {
                if (number.HasValue)
                {
                    Console.WriteLine(number.Value);
                    // аналогично
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine("параметр равен null");
                }
            }

            PrintNullable(5);       // 5
            PrintNullable(null);    // параметр равен null

            int? number = null;
            //Console.WriteLine(number.Value);    // ! Ошибка
            //Console.WriteLine(number);          // Ошибки нет - просто ничего не выведет

            Console.WriteLine(number.GetValueOrDefault());      // 0  - значение по умолчанию для числовых типов
            Console.WriteLine(number.GetValueOrDefault(10));    // 10

            number = 15;    // если значение задано, оно возвращается методом
            Console.WriteLine(number.GetValueOrDefault());    // 15
            Console.WriteLine(number.GetValueOrDefault(10));  // 15

            /*
            Преобразование значимых nullable-типов
            */

            //** явное преобразование от T? к T **//

            //int? x1 = null;
            //if (x1.HasValue)                  //Тут будет false
            //{
            //    int x2 = (int)x1;
            //    Console.WriteLine(x2);            
            //}
            //Соответственно тут ничего не будет//

            //** неявное преобразование от T к T ? **//

            //int x1 = 4;
            //int? x2 = x1;
            //Console.WriteLine(x2); //Резултат 4

            //** неявные расширяющие преобразования от V к T? **//

            //int x1 = 4;
            //long? x2 = x1;
            //Console.WriteLine(x2); // Результат 4

            //** явные сужающие преобразования от V к T? **//
            //long x1 = 4;
            //int? x2 = (int?)x1;

            //** явные сужающие преобразования от V? к T **//
            //long? x1 = null;
            //if (x1.HasValue)
            //{
            //    int x2 = (int)x1;
            //}

            /*
            Операции с nullable-типами
            nullable-типы поддерживают тот же набор операций, что и их не-nullable двойники. Но следует учитывать, что если в операции участвует
            nullable-тип, то результатом также будет значение nullable-типа
            */

            //int? x = 5;
            //int z = x + 7;          // нельзя
            //int? w = x + 7;         // можно
            //int d = x.Value + 7;    // можно

            //int? x = null;
            //int? w = x + 7;         // w = null

            int? x = null;
            int? y = 5;
            int? z = null;
            Console.WriteLine($"x > y is {x > y}");     // false
            Console.WriteLine($"x < y is {x < y}");     // false 
            Console.WriteLine($"x >= y is {x >= y}");   // false
            Console.WriteLine($"x <= y is {x <= y}");   // false

            Console.WriteLine($"x > z is {x > z}");     // false
            Console.WriteLine($"x < z is {x < z}");     // false 
            Console.WriteLine($"x >= z is {x >= z}");   // false
            Console.WriteLine($"x <= z is {x <= z}");   // false

            int? x = null;
            int? y = 5;
            int? z = null;

            Console.WriteLine($"x == y is {x == y}");   // false
            Console.WriteLine($"x != y is {x != y}");   // true

            Console.WriteLine($"x == z is {x == z}");   // true
            Console.WriteLine($"x != z is {x != z}");   // false
            
        }
    }
}

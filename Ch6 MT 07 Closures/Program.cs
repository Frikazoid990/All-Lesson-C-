using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_MT_07_Closures
{
    internal class Program
    {
        static  Action Outer()
        {
            int x = 5;
            void Inner()
            {
                x++;
                Console.WriteLine(x);
            }
            return Inner;
        }
        
        static void Main(string[] args)
        {
            var fn = Outer(); // fn = Inner, так как метод Outer возвращает функцию Inner
            //Вызываем внутреннюю функцию Inner
            fn();
            fn();
            fn();

            
            var outerFn = () =>
            {
                int x = 10;
                var innerFn = () => Console.WriteLine(++x);
                return innerFn;
            };

            var fn1 = outerFn();
            fn1();
            fn1();
            fn1();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_MT_06_Delegates_Action_Func_and_Predicate
{
    internal class Program
    {
        //Action
        static void DoOperation(int a, int b, Action<int,int> op) => op(a,b);

        static void Add(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");

        static void Multiply(int x , int y) => Console.WriteLine($"{x} * {y} = {x * y}");
        //Action

        //Func

        static int DoOperation1(int n, Func<int, int> op) => op(n);

        static int DoubleNumber(int n) => 2 * n;

        static int SquareNumber(int n) => n * n;

        //Func

        static void Main(string[] args)
        {
            //Action
            DoOperation(10, 6, Add);
            DoOperation(10, 6, Multiply);
            //Predicate
            Predicate<int> isPositive = (int x) => x > 0;
            Console.WriteLine(isPositive(20));
            Console.WriteLine(isPositive(30));
            //Func
            int result1 = DoOperation1(6, DoubleNumber);
            Console.WriteLine(result1);

            int result2 = DoOperation1(6, SquareNumber);
            Console.WriteLine(result2);



        }
    }
}

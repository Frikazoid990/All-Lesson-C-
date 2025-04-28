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

        //Predicate

        //Predicate
        static void Main(string[] args)
        {
            //Action
            DoOperation(10, 6, Add);
            DoOperation(10, 6, Multiply);
            //Predicate

            
        }
    }
}

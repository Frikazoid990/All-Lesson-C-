using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycle_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum =1;
            int a = Convert.ToInt32(Console.ReadLine());
            //int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
            
        }
    }
}

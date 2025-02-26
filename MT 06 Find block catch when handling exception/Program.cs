using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_06_Find_block_catch_when_handling_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestClass.Method1();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("=============");
                Console.WriteLine($"Catch в Main : {ex.Message}");
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine("=============");
            }
            finally
            {
                Console.WriteLine("Блок finally в Main");
            }
            Console.WriteLine("Конец метода Main");
        }
    }
}

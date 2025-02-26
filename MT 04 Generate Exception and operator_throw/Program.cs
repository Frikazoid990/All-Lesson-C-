using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_04_Generate_Exception_and_operator_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    string name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name) || name.Length < 2)
                    {
                        throw new Exception("Длинна имени меньше 2 или имя отсутсвует");
                    }
                    else
                    {
                        Console.WriteLine($"Your name: {name}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                    throw;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

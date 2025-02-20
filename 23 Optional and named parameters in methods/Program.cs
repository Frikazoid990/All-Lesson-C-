using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _23_Optional_and_named_parameters_in_methods
{
    internal class Program
    {
        static void PrintPerson(string name, int age, string company = "Unknown")
        {
            Console.WriteLine($"Name: {name} | Age: {age} | Company: {company}");

        }
        
        static int Sum (int n1, int n2 , bool ShowValue = false)
        {
            if (ShowValue)
            {
                Console.WriteLine($"Nr1 = {n1} | Nr2 = {n2}");
            }

            return n1 + n2;
        }

        static void Main(string[] args)
        {
            int sum = Sum(3, 4, true);
            Console.WriteLine(sum);

            PrintPerson("Valery", 26, "Microsoft");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args) 
        {
            string input = "2 неделя Аксус ИнтЕрНет-Продажи.xlsx";
            input.Split(".");
            input = input.ToUpper();
            if (input.Contains("ИНТЕРНЕТ"))
                Console.WriteLine("yes");




            
        }
    }
}

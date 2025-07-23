
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Test1
{
    public class Car
    {
        public string Brand { get; set; }
        public string Mode { get; set; }

        public string CarConfiguration { get; set; }
    }

 
    class Program
    {

        static void Main(string[] args)
        {
            var n = new List<int>();
            if (n.Count == 0)
            {
                Console.WriteLine("0");
            }
            if ( n == null)
            {
                Console.WriteLine("null");
            }
        }
    }
}

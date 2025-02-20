global using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_7_Global_names_space
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company microsoft = new("Microsoft");
            Person tom = new("Tom", microsoft);
            tom.Print();
        }
    }
}

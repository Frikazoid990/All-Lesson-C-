using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test1
{

}
class Program
{
    static void Main(string[] args)
    {
        var source = new List<int>();
        Func<int,bool> isOdd = (int x) => x % 2 == 0;
        var oddList = source.Where(isOdd).ToList();
    }
}
public class Foo1
{
    public static string Name = "Foo1";
    static Foo1()
    {
        Console.WriteLine("static called Foo1");
    }
}

public class Foo2
{
    public const string Name = "Foo2";
    static Foo2()
    {
        Console.WriteLine("static called Foo2");
    }
}

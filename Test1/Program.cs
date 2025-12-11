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
        List<Vehicale> vehicalesRes = new List<Vehicale>()
        {
            new Vehicale(11, true, 1,"green"),
            new Vehicale(12, false, 2,"green"),
            new Vehicale(11, true, 3,"green"),
            new Vehicale(13, false, 4,"green"),
            new Vehicale(13, false, 5,"green"),
            new Vehicale(13, false, 6,"green"),
            new Vehicale(14, true, 7,"green"),
        };
        var groups = vehicalesRes.GroupBy(x => x.IMEI);
        //var existing = _provider.GetByImeis(gropus.Select(x => x.Key));
        foreach (var group in groups)
        {
            var vehicles = group.ToList();
            if (!vehicles.First().HaveDb)//
            {
                vehicles.RemoveAt(0);
            }
            foreach (var vehicle in vehicles)
            {
                vehicle.Property = "";
            }
        }

        Console.WriteLine();
    }
}

public class Vehicale
{
    public int Id { get; set; }
    public int IMEI  { get; set; }
    public bool HaveDb { get; set; }
    
    public string Property { get; set; }

    public Vehicale(int imei, bool haveDb, int id, string property)
    {
        IMEI = imei;
        HaveDb = haveDb;
        Id = id;
        Property = property;
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

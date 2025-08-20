namespace CH_17_MT_04_OrderBy;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 12, 4, 10 };
        var orderedNumbers = numbers.OrderBy(x => x);

        foreach (var i in orderedNumbers)
        {
            Console.WriteLine(i);
        }
        
        string[] peopleExample = { "Ban", "Ann", "Doe" };
        var orderedPeople = peopleExample.OrderBy(x => x);
        foreach (var p in orderedPeople)
        {
            Console.WriteLine(p);
        }
        
        
        var people = new List<Person>
        {
            new Person("Tom", 37),
            new Person("Sam", 28),
            new Person("Tom", 22),
            new Person("Bob", 41),
        };
 
        var sortedPeople1 = from p in people
            orderby p.Name
            select p;
 
        foreach (var p in sortedPeople1)
            Console.WriteLine($"{p.Name} - {p.Age}");

        var sortedPeople2 = people.OrderBy(p => p.Name);
        
        var sortedPeople3 = people.OrderBy(p => p.Name).ThenByDescending(p => p.Age);
 
        foreach (var p in sortedPeople2)
            Console.WriteLine($"{p.Name} - {p.Age}");

        Console.WriteLine("----");
        foreach (var p in sortedPeople3)
        {
            Console.WriteLine($"{p.Name} - {p.Age}");
        }
    }
}

record class Person(string Name, int Age);
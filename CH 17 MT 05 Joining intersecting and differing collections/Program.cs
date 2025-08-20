namespace CH_17_MT_05_Joining_intersecting_and_differing_collections;

class Program
{
    static void Main(string[] args)
    {
        string[] soft2 = { "Microsoft", "Google", "Apple", "Microsoft", "Google" };
        string[] soft = { "Microsoft", "Google", "Apple" };
        string[] hard = { "Apple", "IBM", "Samsung" };
        
        //differing Except()
        var resultDif = soft.Except(hard);
        foreach (var r in resultDif)
        {
            Console.WriteLine(r);
        }
        Console.WriteLine();
        //intersecting
        var resultInt = soft.Intersect(hard);
        foreach (var r in resultInt)
        {
            Console.WriteLine(r);
        }
        Console.WriteLine();
        // del duplicate
        var resultDelDuplicate = soft2.Distinct();
        foreach (var r in resultDelDuplicate)
        {
            Console.WriteLine(r);
        }
        Console.WriteLine();
        //Joining
        var resultJoin = soft.Union(hard);
        foreach (var r in resultJoin)
        {
            Console.WriteLine(r);
        }
        Console.WriteLine();

        Person[] students = { new Person("Tom"), new Person("Bob"), new Person("Sam") };
        Person[] employees = { new Person("Tom"), new Person("Bob"), new Person("Mike") };
        
        var people1 = students.Union(employees);
        foreach (var p in people1)
        {
            Console.WriteLine(p.Name);
        }
    }
}

class Person
{
    public string Name { get; set; }

    public Person(string name) => Name = name;

    public override bool Equals(object? obj)
    {
        if(obj is Person person)
            return Name == person.Name;
        return false;
    }
    public override int GetHashCode() => Name.GetHashCode();
}
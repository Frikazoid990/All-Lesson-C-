namespace CH_10_MT_02_LinkedList;

class Program
{
    static void Main(string[] args)
    {
        var employees = new List<string>() {"Tom", "Jill", "Mike"};
        
        LinkedList<string> people = new LinkedList<string>(employees);

        foreach (var person in people)
        {
            Console.Write(person + " ");
        }

        Console.WriteLine("\n" + people.Count);
        Console.WriteLine(people.First?.Value);
        Console.WriteLine(people.Last?.Value);
        //from start to finish
        var currentNode = people.First;
        while (currentNode != null)
        {
            Console.WriteLine(currentNode.Value);
            currentNode = currentNode.Next;
        }
        //from finish to start
        currentNode = people.Last;
        while (currentNode != null)
        {
            Console.WriteLine(currentNode.Value);
            currentNode = currentNode.Previous;
        }
        
        var peopleEx = new LinkedList<string>();
        peopleEx.AddLast("Tom");
        peopleEx.AddFirst("Bob");
        
        if(peopleEx.First != null) peopleEx.AddAfter(peopleEx.First, "Mike");

        foreach (var person in peopleEx)
        {
            Console.WriteLine(person);
        }
        
        var company = new LinkedList<Person>();
 
        company.AddLast(new Person("Tom"));
        company.AddLast(new Person("Sam"));
        company.AddFirst(new Person("Bill"));
 
        foreach (var person in company) Console.WriteLine(person.Name);
 

    }
}

class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;
}
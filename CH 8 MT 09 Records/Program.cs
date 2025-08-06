namespace Record;

class Program
{
    static void Main(string[] args)
    {
        var person1 = new Person("Tom", 18);
        var person2 = new Person("Tom", 18);
        Console.WriteLine(person1.Equals(person2));
        //operator with
        var sam = person1 with{Name = "Sam"};
        Console.WriteLine($"{sam.Name} - {sam.Age}");
        
        User user1 = new User("Tom");
        User user2 = new User("Tom");
        Console.WriteLine(user1.Equals(user2));
        
        var person = new Person("Tom", 18);
        Console.WriteLine(person.Name); //Tom
        var(personName, personAge) = person;
        Console.WriteLine(personName);
        Console.WriteLine(personAge);
        
    }
}

public record  Person
{
    public string Name { get; init; }
    public int Age { get; init; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public void Deconstruct(out string name, out int age) => (name, age) = (Name, Age);
}

public class User
{
    public string Name { get; init; }
    public User(string name) => Name = name;
}

/*public record struct Person EXAMPLE record with struct
{
    public string Name{ get; set; }
    public Person(string name) => Name = name;
}*/
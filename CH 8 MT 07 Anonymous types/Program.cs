namespace CH_8_MT_07_Anonymous_types;

class Program
{
    static void Main(string[] args)
    {
        var user = new {Name = "Tom", Age = 24};
        Console.WriteLine(user.Name);
        var student = new { Name = "Alice", Age = 21 };
        var manager = new { Name = "Bob", Age = 26, Company = "Microsoft" };
 
        Console.WriteLine(user.GetType().Name); // <>f__AnonymousType0'2
        Console.WriteLine(student.GetType().Name); // <>f__AnonymousType0'2
        Console.WriteLine(manager.GetType().Name); // <>f__AnonymousType1'3
        
        Person tom = new Person("Tom");
        int age = 34;
        var student2 = new {tom.Name, age = age};
        Console.WriteLine($"{student2.Name} {age}");

        var people = new[]
        {
            new { Name = "Tom", age = 22 },
            new { Name = "Bob", age = 26 }
        };
        foreach (var p in people)
        {
            Console.WriteLine($"{p.Name} {p.age}" );
        }
    }
}
class Person
{
    public string Name { get; set; }
    public Person(string name) => Name = name;
}
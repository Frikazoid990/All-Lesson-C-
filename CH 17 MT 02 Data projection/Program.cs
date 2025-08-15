namespace CH_17_MT_02_Data_projection;

class Program
{
    static void Main(string[] args)
    {
        var people = new List<Person>()
        {
            new Person("Tom", 23),
            new Person("Bob", 24),
            new Person("Jill", 25),
            new Person("Alice", 22),
        };
        var names = people.Select(p => new
        {
            
            FirstName = p.Name,
            BornDate = DateTime.Now.Year - p.Age,
        });
        foreach (var n in names)
        {
            Console.WriteLine(n.FirstName + " - " + n.BornDate);
        }

        Console.WriteLine();
        // SelectMany and flattening objects
        var companies = new List<Company>
        {
            new Company("Microsoft", new List<PersonExample> {new PersonExample("Tom"), new PersonExample("Bob")}),
            new Company("Google", new List<PersonExample> {new PersonExample("Sam"), new PersonExample("Mike")}),
        };

        var employees = companies.SelectMany(c => c.Staff, (c,emp) => new {Name = emp.Name, Company = c.Title});
        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.Name} - {employee.Company}");
        }
    }
}

record class Person(string Name, int Age);

record class PersonExample(string Name);

record class Company(string Title, List<PersonExample> Staff);
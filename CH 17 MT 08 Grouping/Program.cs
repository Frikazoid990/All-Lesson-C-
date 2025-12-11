namespace CH_17_MT_08_Grouping;

class Program
{
    static void Main(string[] args)
    {
        Person[] people = new[]
        {
            new Person("Tom", "Microsoft"), new Person("Sam", "Google"),
            new Person("Bob", "JetBrains"), new Person("Mike", "Microsoft"),
            new Person("Kate", "JetBrains"), new Person("Alice", "Microsoft"),
        };

        var companies = people.GroupBy(p => p.Company);
        foreach (var company in companies)
        {
            Console.Write(company.Key + ": ");
            foreach (var person in company)
            {
                Console.Write(" " + person.Name);
            }

            Console.WriteLine();
        }
        
        var companiesExample = people
            .GroupBy(p => p.Company)
            .Select(nw => new{ Name = nw.Key, Count = nw.Count() });
        
        foreach (var company in companiesExample)
            Console.WriteLine($"{company.Name}: {company.Count}");

        var companiesExample2 = people.GroupBy(p => p.Company)
            .Select(g => new
            {
                Title = g.Key,
                Count = g.Count(),
                Employees = g.Select(p => p)
            });
        foreach (var company in companiesExample2)
        {
            Console.WriteLine($"{company.Title}: {company.Count}");
            foreach (var employee in company.Employees)
            {
                Console.WriteLine(employee.Name);
            }
        }
            

    }
}

record class Person(string Name, string Company);
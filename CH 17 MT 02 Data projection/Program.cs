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
        
        var result = new List<Company>();
        for (var i = 0; i < 5; i++)
        {
            result.AddRange(companies);
        }
        var courses = new List<Person> ();
        var students = new List<Company> ();
        
        
        var enrollments = from course in courses    //  выбираем по одному курсу
            from student in students       //  выбираем по одному студенту
            select new { Student = student.Staff, Course = course.Name};   // соединяем каждого студента с каждым курсом

        
        for (int i = 0; i <= 1; i++)
        {
            
        }
        
        var tt1 = Enumerable.Range(1, 5).Select(_ => companies);

        var tt = Enumerable.Range(1, 5)
            .Where(x => true)
            .Select(x => x + 1)
            .SelectMany(x => companies)
            .Distinct();
        
        
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
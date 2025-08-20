namespace CH_17_MT_03_Filtering_a_collections;

class Program
{
    static void Main(string[] args)
    {
        string[] peopleExample = { "Tom", "Alice", "Bob", "Sam", "Tim", "Tomas", "Bill" };
 
        var selectedPeople = peopleExample.Where(p => p.Length == 3); // "Tom", "Bob", "Sam", "Tim"
 
        foreach (string person in selectedPeople)
            Console.WriteLine(person);
        
        int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };

        var selectedNumbers = numbers.Where(x => x > 10 && x % 2 == 0);
        Console.WriteLine();
        
        foreach (var number in selectedNumbers)
        {
            Console.Write(number + " ");
        }
        
        var people = new List<Person>
        {
            new Person ("Tom", 23, new List<string> {"english", "german"}),
            new Person ("Bob", 27, new List<string> {"english", "french" }),
            new Person ("Sam", 29, new List<string>  { "english", "spanish" }),
            new Person ("Alice", 24, new List<string> {"spanish", "german" })
        };
        Console.WriteLine();
        var selectedPeopleExample = people.Where(p => p.Age > 25);

        foreach (var person in selectedPeopleExample)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }

        var selectedPeopleWithLanguages = people.SelectMany(p => p.Languages, (p, l) => new { Person = p, Lang = l })
            .Where(u => u.Lang == "english" && u.Person.Age < 28)
            .Select(u => u.Person);
        foreach (var person in selectedPeopleWithLanguages)
        {
            Console.WriteLine($"{person.Name} - {person.Age} - {person.Languages[0]}");
        }

        Console.WriteLine();
        var peopleExample1 = new List<Person1>
        {
            new Student("Tom"),
            new Person1("Sam"),
            new Student("Bob"),
            new Employee("Mike")
        };

        var students = peopleExample1.OfType<Student>();
        foreach (var student in students)
            Console.WriteLine(student.Name);
    }
}

	
record class Person(string Name, int Age, List<string> Languages);

record class Person1(string Name);
record class Student(string Name): Person1(Name);
record class Employee(string Name) : Person1(Name);
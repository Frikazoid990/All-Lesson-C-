namespace CH_17_MT_09_Joining_collections;

class Program
{
    static void Main(string[] args)
    {
        Person[] people =
        {
            new Person("Tom", "Microsoft"), new Person("Sam", "Google"),
            new Person("Bob", "JetBrains"), new Person("Mike", "Microsoft"),
        };
        Company[] companies =
        {
            new Company("Microsoft", "C#"),
            new Company("Google", "Go"),
            new Company("Oracle", "Java")
        };
    }
}

record class Person(string Name, string Company);
record class Company(string Title, string Language);
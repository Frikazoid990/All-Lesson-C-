namespace Ch_8_MT_03_Indexers;

class Program
{
    static void Main(string[] args)
    {
        var microsoft = new Company(new[]
        {
            new Person("Tom"), new Person("Bob"), new Person("Jill")
        });
        Console.WriteLine(microsoft["Bob"].Name);
        Person firstPerson = microsoft[0];
        Console.WriteLine(firstPerson.Name);
        microsoft[0] = new Person("Mike");
        Console.WriteLine(microsoft[0].Name);
        User tom = new User();
        tom["name"] = "Tom";
        tom["email"] = "tom@gmail.ru";
        tom["phone"] = "+1234556767";
        Console.WriteLine(tom["name"]); // Tom
    }
}
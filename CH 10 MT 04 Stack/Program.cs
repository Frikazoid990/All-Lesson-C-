namespace CH_10_MT_04_Stack;

class Program
{
    static void Main(string[] args)
    {
        var employees = new List<string>() { "Tom", "Sam", "Bob" };
        Stack<string> peopleEx = new Stack<string>(employees);
        foreach (var person in peopleEx)
        {
            Console.WriteLine(person);
        }
        Console.WriteLine(peopleEx.Count);//3
        
        
        var people = new Stack<string>();
        people.Push("Tom");
        // people = { Tom }
        people.Push("Sam");
        // people = { Sam, Tom }
        people.Push("Bob");
        // people = { Bob, Sam, Tom }
        
        // получаем первый элемент стека без его удаления 
        string headPerson = people.Peek();
        Console.WriteLine(headPerson); // Bob
        
        string person1 = people.Pop();
        // people = { Sam, Tom }
        Console.WriteLine(person1); // Bob

        string person2 = people.Pop();
        // people = { Tom }
        Console.WriteLine(person2); // Sam
        
        string person3 = people.Pop();
        // people = {}
        Console.WriteLine(person3); // Tom

        var peopleExample = new Dictionary<int, string>()
        {
            {5,"Tom"},
            {10,"Sam"},
            {9,"Lat"},
            {8,"Mike"},
           
        };
        foreach(var person in peopleExample)
        {
            Console.WriteLine($"key: {person.Key}  value: {person.Value}");
        }

        Console.WriteLine(peopleExample[9]);
        peopleExample[2] = "Tide";
        Console.WriteLine(peopleExample[2]);
        Console.WriteLine();
        var phoneBook = new Dictionary<string, string>();
        phoneBook.Add("+79509260444", "Tom");
        var phoneExists1 = phoneBook.ContainsKey("+79509260444");
        Console.WriteLine($"+79509260444: {phoneExists1}");
        var phoneExists2 = phoneBook.ContainsKey("+567456");
        Console.WriteLine($"+567456 : {phoneExists2}");

        var abonentExists1 = phoneBook.ContainsValue("Tom");
        Console.WriteLine($"Tom: {abonentExists1}");
        var abonentExists2 = phoneBook.ContainsValue("Bob");
        Console.WriteLine($"Bob: {abonentExists2}");
        phoneBook.Remove("+79509260444");
        Console.WriteLine($"Count: {phoneBook.Count}");
    }
}
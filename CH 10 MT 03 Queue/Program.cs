namespace CH_10_MT_03_Queue;

class Program
{
    static void Main(string[] args)
    {
        var employees = new List<string>() { "Tom", "Sam", "Bob" };
        Queue<string> people = new Queue<string>(employees);
        foreach (var person in people)
        {
            Console.Write(person + " ");
        }
        Console.WriteLine("\n"+ people.Count);
        //Methods of the Queue
        var peopleEx = new Queue<string>();
        peopleEx.Enqueue("Tom");
        peopleEx.Enqueue("Sam");
        peopleEx.Enqueue("Bob");

        var firstPerson = peopleEx.Peek();
        Console.WriteLine(firstPerson);

        var person1 = peopleEx.Dequeue();
        Console.WriteLine(person1);
        var person2 = peopleEx.Dequeue();
        Console.WriteLine(person2);
        var person3 = peopleEx.Dequeue();
        Console.WriteLine(person3);

        var patient = new Queue<Person>();
        patient.Enqueue(new Person("Tom"));
        patient.Enqueue(new Person("Sam"));
        patient.Enqueue(new Person("Bob"));

        var doctor = new Doctor("Ervy Hels");
        doctor.TakePatients(patient);




    }
}

public class Person
{
    public string Name { get; set; }
    public Person(string name) => Name = name;
}

public class Doctor
{
    public string Name { get; set; }

    public Doctor(string name)
    {
        Name = name;
    }
    
    public void TakePatients(Queue<Person> people)
    {
        Console.WriteLine($"Доктор {Name} начинает осмотр");
        while (people.Count > 0)
        {
            var person = people.Dequeue();
            Console.WriteLine($"Осмотор пациента {person.Name}");
        }
        Console.WriteLine("Доктор закончил осмотр пациентов!");
    }
}
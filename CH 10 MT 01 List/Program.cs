namespace CH_10_MT_01_List;

class Program
{
    static void Main(string[] args)
    {
        List<int> numb = new List<int>();
        
        List<string> peopleExample2 = new List<string>() { "Tom", "Bob", "Jill" }; // or that List<string> people = ["Tom", "Bob", "Sam"]; List<string> employees = []; - empty list

        var employees = new List<string>(peopleExample2){"Mike"};
        
        List<Person> persons = new List<Person>()
        {
            new Person("Tom"),
            new Person("Bob"),
            new Person("Jill"),
            new Person("Mike")
        };
        
        List<string> peopleExampleWithStartCapacity = new List<string>(16);
        
        var people1 = new List<string>(peopleExample2);
        string firstPerson = people1[0];
        Console.WriteLine(firstPerson);
        people1[0] = "Mike";
        Console.WriteLine(people1[0]);
        //lenght of the list
        Console.WriteLine(people1.Count);
        //iterating over the list
        Console.Write("Cycle Foreach:");
        foreach (var person in people1)
        {
            Console.Write(person + " ");
        }
        
        Console.Write("\nCycle For:");
        for (int i = 0; i < people1.Count; i++)
        {
            Console.Write(people1[i] + " ");
        }
        
        //methods of the list
        
        List<string> peopleEx1 = new List<string> () { "Tom" };
 
        peopleEx1.Add("Bob"); // добавление элемента
        // people = { "Tom", "Bob" };
 
        peopleEx1.AddRange(new[] { "Sam", "Alice" });   // добавляем массив
        // people = { "Tom", "Bob", "Sam", "Alice" };
        // также можно было бы добавить другой список
        // people.AddRange(new List<string>(){ "Sam", "Alice" });
 
        peopleEx1.Insert(0, "Eugene"); // вставляем на первое место
        // people = { "Eugene", "Tom", "Bob", "Sam", "Alice" };
         
        peopleEx1.InsertRange(1, new string[] {"Mike", "Kate"}); // вставляем массив с индекса 1
        // people = { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Alice" };
 
        // также можно было бы добавить другой список
        // people.InsertRange(1, new List<string>(){ "Mike", "Kate" });
        var peopleEx2 = new List<string> () { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };
 
        peopleEx2.RemoveAt(1); //  удаляем второй элемент
        // people = { "Eugene", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };
        peopleEx2.Remove("Tom"); //  удаляем элемент "Tom"
        // people = { "Eugene", "Kate", "Bob", "Sam", "Tom", "Alice" };
 
        // удаляем из списка все элементы, длина строки которых равна 3
        peopleEx2.RemoveAll(person => person.Length == 3);
        // people = { "Eugene", "Kate", "Alice" };
 
        // удаляем из списка 2 элемента начиная с индекса 1
        peopleEx2.RemoveRange(1, 2);
        // people = { "Eugene"};
 
        // полностью очищаем список
        peopleEx2.Clear();
        // people = {  };

        var peopleEx3 = new List<string> () { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam" };
 
        var containsBob = peopleEx3.Contains("Bob");     //  true
        var containsBill = peopleEx3.Contains("Bill");    // false
 
        // проверяем, есть ли в списке строки с длиной 3 символа
        var existsLength3 = peopleEx3.Exists(p => p.Length == 3);  // true
 
        // проверяем, есть ли в списке строки с длиной 7 символов
        var existsLength7 = peopleEx3.Exists(p => p.Length == 7);  // false
 
        // получаем первый элемент с длиной в 3 символа
        var firstWithLength3 = peopleEx3.Find(p => p.Length == 3); // Tom
 
        // получаем последний элемент с длиной в 3 символа
        var lastWithLength3 = peopleEx3.FindLast(p => p.Length == 3);  // Sam
 
        // получаем все элементы с длиной в 3 символа в виде списка
        List<string> peopleWithLength3 = peopleEx3.FindAll(p => p.Length == 3);
        // peopleWithLength3 { "Tom", "Bob", "Sam"}
            List<string> peopleEx33 = new List<string>() {"Eugene", "Tom", "Mike", "Sam", "Bob" };
 
        // получаем диапазон со второго по четвертый элемент
            var range = peopleEx33.GetRange(1, 3);
        // range = { "Tom", "Mike", "Sam"};
 
        // копируем в массив первые три элемента
            string[] partOfPeople = new string[3];
            peopleEx33.CopyTo(0, partOfPeople, 0, 3);
        // partOfPeople = { "Eugene", "Tom", "Mike"};
            var peopleEx4 = new List<string> () { "Eugene", "Tom", "Mike", "Sam", "Bob" };
 
    // переворачиваем весь список
    peopleEx4.Reverse();
    // people = { "Bob","Sam", "Mike", "Tom", "Eugene"};
 
            var peopleEx5 = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };
    // переворачиваем часть только 3 элемента с индекса 1
    peopleEx5.Reverse(1, 3);
    // people2 = { "Eugene","Sam", "Mike", "Tom", "Bob" };
    }
}

public class Person
{
    public string Name;
    
    public Person(string name) => Name = name;
}
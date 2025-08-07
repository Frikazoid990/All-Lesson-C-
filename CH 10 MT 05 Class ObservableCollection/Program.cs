using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace CH_10_MT_05_Class_ObservableCollection;

class Program
{
    static void Main(string[] args)
    {
        var people = new ObservableCollection<Person>()
        {
            new Person("Tom"),
            new Person("Bob"),
        };
        
        people.CollectionChanged += People_CollectionChanged;
        
        people.Add(new Person("Mike"));
        
        people.RemoveAt(1);
        people[0] = new Person("Even");

        Console.WriteLine($"\nСписок пользователей:");
        foreach (var person in people)
        {
            Console.WriteLine(person.Name);
        }
    }

    static void People_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add: // если добавление
                if(e.NewItems?[0] is Person newPerson)
                    Console.WriteLine($"Добавлен новый объект: {newPerson.Name}");
                break;
            case NotifyCollectionChangedAction.Remove: // если удаление
                if (e.OldItems?[0] is Person oldPerson)
                    Console.WriteLine($"Удален объект: {oldPerson.Name}");
                break;
            case NotifyCollectionChangedAction.Replace: // если замена
                if ((e.NewItems?[0] is Person replacingPerson)  && 
                    (e.OldItems?[0] is Person replacedPerson))
                    Console.WriteLine($"Объект {replacedPerson.Name} заменен объектом {replacingPerson.Name}");
                break;
        }
    }
}

class Person
{
    public string Name { get; set; }

    public Person(string name) => Name = name;
}
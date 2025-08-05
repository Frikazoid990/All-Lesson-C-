namespace Partial_classes_methods_and_properties;

public partial class Person
{
    public void Move() => Console.WriteLine("human is go");
}

public partial class Person
{
    public partial void Say(string message);
}

public partial class Person : Object
{
    public partial void Say(string message) => Console.WriteLine(message);
}
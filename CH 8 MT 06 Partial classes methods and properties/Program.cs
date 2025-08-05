namespace Partial_classes_methods_and_properties;

partial class Person
{
    public partial string Name { get; set; }
}
partial class Person
{
    private string name;
    
    public Person(string name) => this.name = name;

    public partial string Name 
    {
        get => name;
        set => name = value; 
    }
}

class Program
{
    static void Main(string[] args)
    {
        /*
         * partial(частичные) classes PersonEat.cs and PersonMove 
         */

        var tom = new Person("Bob");
        tom.Move();
        tom.Eat();
        
        /*
         * partial methods in
         * PersonMove
         */
        
        /*
         * partial properties
         */
        
    }

    
}

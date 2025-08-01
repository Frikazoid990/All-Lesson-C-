namespace Ch7_MT_07_Copy_objects._Interface_ICloneable;

class Program
{
    static void Main(string[] args)
    {
        var tom = new PersonExample1("Tom", 23);
        var bob = (PersonExample1)tom.Clone();
        bob.Name = "Bob";
        Console.WriteLine(tom.Name);
        
        
        var fan = new PersonExample2("Fan", 23, new Company("Microsoft"));
        var rob = (PersonExample2)tom.Clone();
        
        
    }
}



class PersonExample1 : ICloneable
{
    delegate void Operation();
    event Operation OperationEvent;
    public string Name { get; set; }
    public int Age { get; set; }

    public PersonExample1(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public object Clone()
    {
        
        return new PersonExample1(Name, Age); 
    }
}

public interface ICloneable
{
    object Clone();
}

class Company
{
    public string Name { get; set; }
    public Company(string name) => Name = name;
}

class PersonExample2 : ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Company Work { get; set; }

    public PersonExample2(string name, int age, Company company)
    {
        Name = name;
        Age = age;
        Work = company;
    }
    public object Clone() => MemberwiseClone();
}
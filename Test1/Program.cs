namespace Test1;

class Program
{
    static void Main(string[] args)
    {
        var fact = new Fact(5);
        fact.Calculation();
        fact.Result();
        //test
    }
}

class FooClass
{
    public string Foo { get; set; }
}
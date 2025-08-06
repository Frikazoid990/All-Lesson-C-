namespace CH_8_MT_10_ref_struct;

class Program
{
    static void Main(string[] args)
    {
        var tom = new Person("Tom");
        Console.WriteLine(tom.Name);
        int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};
        Sum summator = new Sum(numbers, 1..3);
        Console.WriteLine(summator.Get());
        
        Shape myShape = new();
        myShape.Draw();     // Draw some shape
 
    // Draw_Shape(myShape);           // ! Ошибка - Так нельзя
    // var shape2 = (IShape)shape; // ! Ошибка - Так нельзя
    }
    
    static void Draw_Shape(IShape shape)
    {
        shape.Draw();
    }

}

ref struct Person
{
    public string Name;
    public Person(string name) => Name = name;
   
}

ref struct Sum
{
    private ReadOnlySpan<int> data;

    public Sum(int[] numbers, Range range)
    {
        data = numbers[range];
    }

    public int Get()
    {
        int result = 0;
        foreach (var n in data)
        {
            result += n;
        }
        return result;
    }
}


interface IShape
{
    void Draw();
}

ref struct Shape : IShape
{
    public void Draw()
    {
        Console.WriteLine("Draw some shape");
    }
}
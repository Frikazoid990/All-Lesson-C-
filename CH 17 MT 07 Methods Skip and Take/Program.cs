namespace CH_17_MT_07_Methods_Skip_and_Take;

class Program
{
    static void Main(string[] args)
    {
        string[] people = { "Tom", "Sam", "Bob", "Mike", "Kate", "Alice" };

        var resultSkip = people.Skip(2);
        foreach (var r in resultSkip)
        {
            Console.Write($"{r}");
        }

        var resultSkipLas = people.SkipLast(2);
        foreach (var r in resultSkipLas)
        {
            Console.WriteLine($"{r}");
        }

        var resultSkipWhile = people.SkipWhile(p => p.Length == 3);

        foreach (var r in resultSkipWhile)
        {
            Console.WriteLine($"{r}");
        }
        
        var resultTake = people.Take(3);

        foreach (var r in resultTake)
        {
            Console.WriteLine($"{r}");
        }
        
        var resultTakeLast = people.TakeLast(3);
        foreach (var r in resultTakeLast)
        {
            Console.WriteLine($"{r}");
        }
        
        var resultTakeWhile = people.TakeWhile(p => p.Length == 3);

        var result = people.Skip(3).Take(2);
        foreach (var r in result)
        {
            Console.WriteLine(result);
        }
    }
}
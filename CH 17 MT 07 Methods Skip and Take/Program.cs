namespace CH_17_MT_07_Methods_Skip_and_Take;

class Program
{
    static void Main(string[] args)
    {
        string[] people = { "Tom", "Sam", "Bob", "Mike", "Kate" };

        var resultSkip = people.Skip(2);
        foreach (var r in resultSkip)
        {
            Console.Write($"{r}");
        }

    }
}
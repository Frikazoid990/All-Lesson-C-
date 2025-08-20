namespace CH_17_MT_06_Aggregate_operations;

class Program
{
    static void Main(string[] args)
    {
        //Method Aggregate
        int[] numbers = { 1, 2, 3, 4, 5 };
        int query = numbers.Aggregate((x,y) => x - y );
        Console.WriteLine(query);
        
        string[] words = { "Gaudeamus", "igitur", "Juvenes", "dum", "sumus" };
        var sentence = words.Aggregate("Text:", (first, next) => $"{first} {next}");
        Console.WriteLine(sentence);  // Text: Gaudeamus igitur Juvenes dum sumus
        
        //method Count
        int[] numbers2 = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
        int count = numbers2.Count();
        Console.WriteLine(count); // 10
        
        int size = numbers.Count(i => i % 2 == 0 && i > 10);
        Console.WriteLine(size);    // 3
        
        // get (method) Sum
        int[] numbers3 = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
        int sum = numbers3.Sum();
        Console.WriteLine(sum); //340

        int min = numbers3.Min();
        int max = numbers3.Max();
        double avg = numbers3.Average();

        Console.WriteLine($"Min: {min}\nMax: {max}\nAvg: {avg}");
        


    }
}
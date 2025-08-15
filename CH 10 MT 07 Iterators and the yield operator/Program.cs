namespace CH_10_MT_07_Iterators_and_the_yield_operator;

class Program
{
    static void Main(string[] args)
    {
        Numbers numbers = new Numbers(144);

        foreach (var n in numbers) 
        {
            Console.WriteLine(n);
        }

        Console.WriteLine(numbers.GetCount());
    }
}

class Numbers
{
    private readonly int _number;
    private int count = -1;
    
    public int GetCount() => count;
    public Numbers(int number) => this._number = number;
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i <= _number; i++)
        {
            yield return i * i;
            count++;
        }
    }
}
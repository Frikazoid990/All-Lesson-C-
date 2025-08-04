namespace Ch8_MT_01_Defining_Operators;

class Program
{
    static void Main(string[] args)
    {
        Counter counter1 = new Counter { Value = 10 }; 
        Counter counter2 = new Counter { Value = 20 };
        
        bool result = counter1 > counter2;
        Counter c3 = counter1 + counter2;
        Console.WriteLine(result);
        Console.WriteLine(c3.Value);

        int result1 = counter1 + 27;
        Console.WriteLine(result1);
        
        Counter c4 = new Counter { Value = 20 };
        Counter cresult = c4++;
        Console.WriteLine(cresult.Value);
        Console.WriteLine(c4.Value);



    }
}

public class Counter
{
    public int Value { get; set; }

    public static Counter operator +(Counter counter1, Counter counter2)
    {
        return new Counter { Value = counter1.Value + counter2.Value };
    }

    public static bool operator >(Counter counter1, Counter counter2)
    {
        return counter1.Value > counter2.Value;
    }

    public static bool operator <(Counter counter1, Counter counter2)
    {
        return counter1.Value < counter2.Value;
    }

    public static int operator +(Counter counter1, int val)
    {
        return counter1.Value + val;
    }

    public static Counter operator ++(Counter counter1)
    {
        return new Counter { Value = counter1.Value + 10 };
    }
    
}
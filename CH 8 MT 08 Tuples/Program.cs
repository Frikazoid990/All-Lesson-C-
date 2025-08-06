namespace CH_8_MT_08_Tuples;

class Program
{
    static void Main(string[] args)
    {
        var tuple = (5, 10); // or (int,int) tuple = (5,10)
        Console.WriteLine(tuple.Item1);
        Console.WriteLine(tuple.Item2);
        
        tuple.Item1 += tuple.Item2;
        Console.WriteLine(tuple.Item1);

        (string, int, double) person = ("Tom", 18, 67.3);
        var tuple2 = (count: 5, sum: 10);
        Console.WriteLine(tuple2.count);
        Console.WriteLine(tuple2.sum);
        
        var (name, age) = ("Tom", 18);
        Console.WriteLine(name);
        Console.WriteLine(age);

        string first = "Java";
        string second = "C#";
        (first,second) = (second,first);
        Console.WriteLine(first);
        Console.WriteLine(second);
        
        int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };

        for (int i = 0; i < nums.Length-1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] > nums[j])
                    (nums[i], nums[j]) = (nums[j], nums[i]);
            }
        }

        Console.WriteLine("Вывод отсортированного массива");
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
        var tuple3 = GetValue();
        Console.WriteLine(tuple3.Item1);
        Console.WriteLine(tuple3.Item2);
        PrintPerson(("Tom", 18));
        
    }

    static (int, int) GetValue()
    {
        var result = (1, 3);
        return result;
    }

    static void PrintPerson((string name, int age) person)
    {
        Console.WriteLine($"Name: {person.name} and age: {person.age}");
    }
}
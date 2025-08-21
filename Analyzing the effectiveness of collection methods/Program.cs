using System.Collections.Concurrent;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Analyzing_the_effectiveness_of_collection_methods;

// Необходимо написать программу, которая могла проанализировать эффективность работы основных методов коллекции, а именно
// Добавить, Вставить, Удалить, Найти, Сортировать и т.д. для разных видов коллекций.
//array, list, hashSet, dictionary, linkedList
class Program
{
    static Stopwatch sw = new Stopwatch();
    static void EffectCheck(string operationName, Action action, string collections)
    {
        sw.Restart();
        action();
        sw.Stop();
        Console.WriteLine($"{operationName} {collections} ms: {sw.ElapsedMilliseconds}");
    }
    static void Main(string[] args)
    {
        // BenchmarkRunner.Run<StringTest>(); EXAMPLE
        Console.WriteLine("Test collection ARRAY");
        var exArr = new EffectivenessOfArray();
        EffectCheck("Setup", exArr.Setup, "in array");
        EffectCheck("Add", exArr.Add,"in array");
        EffectCheck("Find", exArr.Find,"in array");
        EffectCheck("Delete", exArr.Delete,"in array");
        EffectCheck("Sort", exArr.Sort,"in array");
        
        Console.WriteLine("\nTest collection LIST");
        var exList = new EffectivenessOfList();
        EffectCheck("Setup", exList.Setup, "in list");
        EffectCheck("Add", exList.Add,"in list");
        EffectCheck("Find", exList.Find,"in list");
        EffectCheck("Delete", exList.Delete,"in list");
        EffectCheck("Sort", exList.Sort,"in list");

        Console.WriteLine("\nTest collection HSet");
        var exHSet = new EffectivenessOfHashSet();
        EffectCheck("Setup", exHSet.Setup, "in hashset");
        EffectCheck("Add", exHSet.Add,"in hashset");
        EffectCheck("Find", exHSet.Find,"in hashset");
        EffectCheck("Delete", exHSet.Delete,"in hashset");
        EffectCheck("Sort", exHSet.Sort,"in hashset");
        
        // var set = new ConcurrentBag<long>();
        // Parallel.For(0, Environment.ProcessorCount, _ =>
        // {
        //     while (true)
        //     {
        //         set.Add(Random.Shared.NextInt64());
        //         Math.Sqrt(Random.Shared.NextDouble());
        //
        //     }
        // });
    }
}

public interface IEffectiveness
{
    public void Setup();
    public void Add();
    public void Delete();
    public void Find();
    public void Sort();
}

public class EffectivenessOfArray : IEffectiveness
{

    const int size = 10000000;

    private int count;
    private int[] array;
    
    
    [Benchmark]
    public void Setup()
    {
        count = size;
        array = new int[size];
        
        for (var i = 0; i < array.Length; i++)
        {
            array[i] = Random.Shared.Next(-1000000,1000000);
            
        }
    }
    
    [Benchmark]
    public void Add()
    {
        if (count >= array.Length)
        {
            Array.Resize(ref array, array.Length * 2);
        }

        array[count] = count;
        count++;
    }
    [Benchmark]
    public void Delete()
    {
        if (count <= 0)
        {
            return;
        }

        for (var i = 0; i < count - 1; i++)
        {
            array[i] = array[i + 1];
        }

        count--;
        array[count] = default!;
    }
    [Benchmark]
    public void Find()
    {
        var FindNumber = array[Random.Shared.Next(0, array.Length)];
        Array.Find(array, i => i == FindNumber);
    }
    [Benchmark]
    public void Sort()
    {
        var temp = (int[])array.Clone();
        Array.Sort(temp);
    }
}

public class EffectivenessOfList : IEffectiveness
{
    const int size = 10000000;
    private List<int> list; 
    
    public void Setup()
    {
        list = new List<int>(size);
        for (var i = 0; i < list.Capacity ; i++)
        {
            list.Add(Random.Shared.Next(-1000000,1000000));
        }

        // Console.WriteLine(list[0]);
        // Console.WriteLine(list.Capacity == size);
    }
    
    public void Add()
    {
        list.Add(Random.Shared.Next(-1000000,1000000));
    }

    public void Delete()
    {
        
        list.RemoveAt(0);
    }

    public void Find()
    {
        var r = Random.Shared.Next(0, list.Count() - 1);
        var FindNumber = list[r];
        var f= list.Find(x => x == FindNumber);
    }

    public void Sort()
    {
        list.Sort();
    }
}

public class EffectivensessOfLinkedList : IEffectiveness
{
    public void Setup()
    {
        throw new NotImplementedException();
    }

    public void Add()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public void Find()
    {
        throw new NotImplementedException();
    }

    public void Sort()
    {
        throw new NotImplementedException();
    }
}

public class EffectivensessOfStack : IEffectiveness
{
    public void Setup()
    {
        throw new NotImplementedException();
    }

    public void Add()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public void Find()
    {
        throw new NotImplementedException();
    }

    public void Sort()
    {
        throw new NotImplementedException();
    }
}

public class EffectivenessOfHashSet : IEffectiveness
{
    const int size = 10000000;
    
    private HashSet<int> hashset;
    public void Setup()
    {
        hashset = new HashSet<int>(size);
        for (var i = 0; i < hashset.Capacity; i++)
        {
            hashset.Add(i);
        }

        Console.WriteLine();
    }

    public void Add()
    {
        hashset.Add(Random.Shared.Next(-1000000,1000000));
    }

    public void Delete()
    {
            var number = hashset.First();
            hashset.Remove(number);    
    }

    public void Find()
    {
       var b = hashset.Contains(Random.Shared.Next(-1000000,1000000));
    }

    public void Sort()
    {
        var l = hashset.OrderBy(x => x).ToList();
    }
}

// public class StringTest EXAMPLE
// {
//     string[] numbers = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
//     [Benchmark]
//     public string WithStringBuilder()
//     {
//         StringBuilder stringBuilder = new StringBuilder();
//         foreach (string s in numbers)
//         {
//             stringBuilder.Append(s);
//             stringBuilder.Append(" ");
//         }
//         return stringBuilder.ToString();
//     }
//     [Benchmark]
//     public string WithConcatenation()
//     {
//         string result = "";
//         foreach (string s in numbers) result = result + s + " ";
//         return result;
//     }
//     [Benchmark]
//     public string WithInterpolation()
//     {
//         string result = "";
//         foreach (string s in numbers) result = $"{result}{s} ";
//         return result;
//     }
//
// }
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
    static void EffectCheck(string operationName, Action action)
    {
        sw.Restart();
        action();
        sw.Stop();
        Console.WriteLine($"{operationName} array ms: {sw.ElapsedMilliseconds}");
    }
    static void Main(string[] args)
    {
        // BenchmarkRunner.Run<StringTest>(); EXAMPLE
        // BenchmarkRunner.Run<EffectivenessOfArray>();
        var ex = new EffectivenessOfArray();
        EffectCheck("Setup", ex.Setup);
        EffectCheck("Add", ex.Add);
        EffectCheck("Find", ex.Find);
        EffectCheck("Delete", ex.Delete);
        EffectCheck("Sort", ex.Sort);

        
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

    private int size = 10000000;

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
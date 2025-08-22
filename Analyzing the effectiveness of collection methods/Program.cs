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

        Console.WriteLine("\nTest collection LinkedList");
        var exLinkedList = new EffectivensessOfLinkedList();
        EffectCheck("Setup", exLinkedList.Setup, "in linkedlist");
        EffectCheck("Add", exLinkedList.Add,"in linkedlist");
        EffectCheck("Find", exLinkedList.Find,"in linkedlist");
        EffectCheck("Delete", exLinkedList.Delete,"in linkedlist");
        EffectCheck("Sort", exLinkedList.Sort,"in linkedlist");

        Console.WriteLine("\nTest collection Stack");
        var exStack = new EffectivensessOfStack();
        EffectCheck("Setup", exStack.Setup, "in stack");
        EffectCheck("Add", exStack.Add,"in stack");
        EffectCheck("Find", exStack.Find,"in stack");
        EffectCheck("Delete", exStack.Delete,"in stack");
        EffectCheck("Sort", exStack.Sort,"in stack");

        Console.WriteLine("\nTest collection Dictionary");
        var exDict = new EffectivenessOfDictionaty();
        EffectCheck("Setup", exDict.Setup, "in dictionary");
        EffectCheck("Add", exDict.Add,"in dictionary");
        EffectCheck("Find", exDict.Find,"in dictionary");
        EffectCheck("Delete", exDict.Delete,"in dictionary");
        EffectCheck("Sort", exDict.Sort,"in dictionary");
        
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
    const int size = 10000000;
    private LinkedList<int> linkedList;
    public void Setup()
    {
        linkedList = new LinkedList<int>();
        for (int i = 0; i < size; i++)
        {
            linkedList.AddLast(Random.Shared.Next(-1000000,1000000));
        }
    }

    public void Add()
    {
        linkedList.AddLast(Random.Shared.Next(-1000000,1000000));
    }

    public void Delete()
    {
        linkedList.RemoveLast();
    }

    public void Find()
    {
        var item = Random.Shared.Next(-1000000, 1000000);
        linkedList.Find(item);
    }

    public void Sort()
    {
        
        var sorted = linkedList.OrderBy(x => x).ToList();
        linkedList = new LinkedList<int>(sorted);
    }
}

public class EffectivensessOfStack : IEffectiveness
{
    private Stack<int> stack;
    const int size = 10000000;
    public void Setup()
    {
        stack = new Stack<int>(size);
        for (int i = 0; i < stack.Capacity; i++)
        {
            stack.Push(Random.Shared.Next(-1000000,1000000));
        }
    }

    public void Add()
    {
        stack.Push(Random.Shared.Next(-1000000,1000000));
    }

    public void Delete()
    {
        var item = stack.Pop();
    }

    public void Find()
    {
        var list = stack.ToList();
        var item = list[Random.Shared.Next(list.Count - 1)];
        var b = stack.Contains(item);
    }

    public void Sort()
    {
        var sortedStack = stack.OrderBy(x => x).ToList();
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

public class EffectivenessOfDictionaty : IEffectiveness
{
    private Dictionary<int, int> dict;
    const int size = 10000000;
    
    public void Setup()
    {
        dict = new Dictionary<int, int>(size);
        for (int i = 0; i < dict.Capacity; i++)
        {
            dict.Add(i, Random.Shared.Next(-10000000,1000000));
        }
        
    }

    public void Add()
    {
        dict.Add(-10, Random.Shared.Next(-1000000,1000000));
    }

    public void Delete()
    {
        dict.Remove(-10);
    }

    public void Find()
    {
        var item = dict[Random.Shared.Next(dict.Capacity)];
        var b = dict.ContainsValue(item);
    }

    public void Sort()
    {
        var list = dict.OrderBy(x => x.Value).ToList();
        dict = new Dictionary<int, int>(list);
    }
}

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

    static void EffectCheckWithClasses<T>(List<T> obj) where T : IEffectiveness
    {
        foreach (var o  in obj)
        {
            var nc = o.GetNameOfCollection();
            Console.WriteLine($"\nTest collection {nc}");
            EffectCheck("Setup", o.Setup, nc);
            EffectCheck("Add", o.Add,nc);
            EffectCheck("Find", o.Find,nc);
            EffectCheck("Delete", o.Delete,nc);
            EffectCheck("Sort", o.Sort,nc);
        }

        
    }
    static void Main(string[] args)
    {
        // BenchmarkRunner.Run<StringTest>(); EXAMPLE
        var collectionList = new List<IEffectiveness>();
        var exArr = new EffectivenessOfArray("Array");
        var exList = new EffectivenessOfList("List");
        var exHSet = new EffectivenessOfHashSet("HashSet");
        var exLinkedList = new EffectivensessOfLinkedList("LinkedList");
        var exStack = new EffectivensessOfStack("Stack");
        var exDict = new EffectivenessOfDictionaty("Dictionary");
        collectionList.AddRange(exArr, exList, exHSet, exLinkedList, exStack, exDict);
        EffectCheckWithClasses(collectionList);
    }
}

public interface IEffectiveness
{
    public string GetNameOfCollection();
    public void Setup();
    public void Add();
    public void Delete();
    public void Find();
    public void Sort();
}

public class EffectivenessOfArray : IEffectiveness
{
    public string NameOfCollection { get; set; }
    const int size = 10000000;
    private int count;
    private int[] array;

    public EffectivenessOfArray(string nameOfCollection)
    {
        NameOfCollection = nameOfCollection;
    }

    public string GetNameOfCollection()
    {
        return NameOfCollection;
    }

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
    public string NameOfCollection { get; set; }
    const int size = 10000000;
    private List<int> list;

    public EffectivenessOfList(string nameOfCollection)
    {
        NameOfCollection = nameOfCollection;
    }
    public string GetNameOfCollection()
    {
        return NameOfCollection;
    }

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
    public string NameOfCollection { get; set; }
    const int size = 10000000;
    private LinkedList<int> linkedList;

    public EffectivensessOfLinkedList(string nameOfCollection)
    {
        NameOfCollection = nameOfCollection;
    }
    public string GetNameOfCollection()
    {
        return NameOfCollection;
    }

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
    public string NameOfCollection { get; set; }
    private Stack<int> stack;
    const int size = 10000000;

    public EffectivensessOfStack(string nameOfCollection)
    {
        NameOfCollection = nameOfCollection;
    }
    
    public string GetNameOfCollection()
    {
        return NameOfCollection;
    }

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
    public string NameOfCollection { get; set; }
    private HashSet<int> hashset;

    public EffectivenessOfHashSet(string nameOfCollection)
    {
        NameOfCollection = nameOfCollection;
    }
    public string GetNameOfCollection()

    {
        return NameOfCollection;
    }

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

    public EffectivenessOfDictionaty(string nameOfCollection)
    {
        NameOfCollection = nameOfCollection;
    }

    public string NameOfCollection { get; set; }
    
    public string GetNameOfCollection()
    {
        return NameOfCollection;
    }

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

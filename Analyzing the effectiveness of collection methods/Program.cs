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
    private static Stopwatch sw = new Stopwatch(); //обычно мы явно указываем уровень доступа
    static void EffectCheck(Action action, string description) //нейминг - отдельная сложная тема.. но в целом - старайся чтоб текст читался как английский.. DoWithMeasure(work, description) выгля
        // метод с двумя строками плох тем, что их можно перепутать.
        // порядок тоже старайся писать от важных к менее важным, и служебные (CancellationToken) в конце
    {
        sw.Restart();
        action();
        sw.Stop();
        Console.WriteLine($"{description} ms: {sw.ElapsedMilliseconds}");
    }

    static void EffectCheckWithClasses<T>(List<T> objs) where T : IEffectiveness
    {
        foreach (var obj  in objs) //однобуквенные переменные - почти всегда плохая идея... именно тут список - objs и obj - элемент этого списка
        {
            var collectionName = obj.NameOfCollection;
            
            Console.WriteLine($"{Environment.NewLine}Test collection {collectionName}"); 
            EffectCheck(obj.Setup, "Setup " + collectionName);
            EffectCheck(obj.Add,"Add " + collectionName);
            EffectCheck(obj.Find,"Find " + collectionName);
            EffectCheck(obj.Delete,"Delete " + collectionName);
            EffectCheck(obj.Sort,"Sort " + collectionName);
        }
    }
    static void Main(string[] args)
    {
        var l = Enumerable.Range(0, 10).ToList();
        var l2 = Enumerable.Range(0, 5).Union(Enumerable.Range(6, 4)).ToList();
        int tt = 0;

        int tt2 = 0;
        for (var i = 0; i < l.Count; i++)
        {
            tt ^= l[i];
        }
        
        for (var i = 0; i < l2.Count; i++)
        {
            tt2 ^= l2[i];
        }
        Console.WriteLine(tt);
        Console.WriteLine(tt2);

        Console.WriteLine(tt^tt2);

        Console.WriteLine(string.Join(',', l.Select(x => x.ToString())));
        Console.WriteLine(string.Join(',', l2.Select(x => x.ToString())));
        
        return;
        var collectionList = new List<IEffectiveness>() //инициализаторы спасают))
        {
            //new EffectivenessOfArray(),
            //new EffectivenessOfList(),
            new EffectivenessOfHashSet(),
            //new EffectivensessOfLinkedList(),
            //new EffectivensessOfStack(),
            //new EffectivenessOfDictionaty(),
        };
        EffectCheckWithClasses(collectionList);
    }
}

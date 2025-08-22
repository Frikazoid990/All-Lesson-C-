namespace Analyzing_the_effectiveness_of_collection_methods;

public class EffectivenessOfList : IEffectiveness
{
    public string NameOfCollection { get; } = nameof(list);
    const int size = 10000000;
    private const int min = -1000000;
    private const int max = 1000000;
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
        list.Add(Random.Shared.Next(min,max));
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
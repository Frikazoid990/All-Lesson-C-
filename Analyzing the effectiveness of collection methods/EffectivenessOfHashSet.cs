namespace Analyzing_the_effectiveness_of_collection_methods;

public class EffectivenessOfHashSet : IEffectiveness
{
    const int size = 10000000;
    private const int min = -1000000;
    private const int max = 1000000;
    public string NameOfCollection { get; } = nameof(hashset);
    private HashSet<int> hashset;

    public void Setup()
    {
        hashset = new HashSet<int>(size);
        for (var i = 0; i < hashset.Capacity; i++)
        {
            hashset.Add(i);
        }
        
    }

    public void Add()
    {
        hashset.Add(Random.Shared.Next(min,max));
    }

    public void Delete()
    {
        var number = hashset.First();   
        hashset.Remove(number);    
    }

    public void Find()
    {
        var b = hashset.Contains(Random.Shared.Next(min,max));
    }

    public void Sort()
    {
        var l = hashset.OrderBy(x => x).ToList();
    }
}
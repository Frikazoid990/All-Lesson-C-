namespace Analyzing_the_effectiveness_of_collection_methods;

public class EffectivenessOfDictionaty : IEffectiveness
{
    private Dictionary<int, int> dict;
    const int size = 10000000;
    private const int min = -1000000;
    private const int max = 1000000;
    public string NameOfCollection { get; } = nameof(dict);

    public void Setup()
    {
        dict = new Dictionary<int, int>(size);
        for (int i = 0; i < dict.Capacity; i++)
        {
            dict.Add(i, Random.Shared.Next(min,max));
        }
        
    }

    public void Add()
    {
        dict.Add(-10, Random.Shared.Next(min,max));
    }

    public void Delete()
    {
        dict.Remove(-10);
    }

    public void Find()
    {
        var item = dict[Random.Shared.Next(dict.Count)];
        var b = dict.ContainsValue(item);
    }

    public void Sort()
    {
        var list = dict.OrderBy(x => x.Value).ToList();
        dict = new Dictionary<int, int>(list);
    }
}
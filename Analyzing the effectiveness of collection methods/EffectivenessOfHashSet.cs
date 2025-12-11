namespace Analyzing_the_effectiveness_of_collection_methods;

public class EffectivenessOfHashSet : IEffectiveness
{
    class MyClass
    {
        private Guid id;
        private Guid parentId;
        
        public override int GetHashCode()
        {
            return id.GetHashCode() ^ parentId.GetHashCode() ;
        }

        public override bool Equals(object? obj)
        {
            return true;
        }
    }
    
    const int size = 100000;
    private const int min = -1000000;
    private const int max = 1000000;
    public string NameOfCollection { get; } = nameof(hashset);
    private HashSet<MyClass> hashset;

    public void Setup()
    {
        Dictionary<(Guid, Guid), MyClass> tt = new Dictionary<(Guid, Guid), MyClass>();
        hashset = new HashSet<MyClass>(size);
        for (var i = 0; i < hashset.Capacity; i++)
        {
            hashset.Add(new MyClass());
        }

        Console.WriteLine(hashset.Count);   
    }

    public void Add()
    {
        hashset.Add(new MyClass());
    }

    public void Delete()
    {
        var number = hashset.First();   
        hashset.Remove(number);    
    }

    public void Find()
    {
        var b = hashset.Contains(new MyClass());
    }

    public void Sort()
    {
        var l = hashset.OrderBy(x => x).ToList();
    }
}
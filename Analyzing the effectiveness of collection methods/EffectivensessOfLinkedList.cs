namespace Analyzing_the_effectiveness_of_collection_methods;

public class EffectivensessOfLinkedList : IEffectiveness
{
    public string NameOfCollection { get; } = nameof(linkedList);
    const int size = 10000000;
    private LinkedList<int> linkedList;
    private const int min = -1000000;
    private const int max = 1000000;
    public string GetNameOfCollection()
    {
        return NameOfCollection;
    }

    public void Setup()
    {
        linkedList = new LinkedList<int>();
        for (int i = 0; i < size; i++)
        {
            linkedList.AddLast(Random.Shared.Next(min,max));
        }
    }

    public void Add()
    {
        linkedList.AddLast(Random.Shared.Next(min,max));
    }

    public void Delete()
    {
        linkedList.RemoveLast();
    }

    public void Find()
    {
        var item = Random.Shared.Next(min, max);
        linkedList.Find(item);
    }

    public void Sort()
    {
        
        var sorted = linkedList.OrderBy(x => x).ToList();
        linkedList = new LinkedList<int>(sorted);
    }
}
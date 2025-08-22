namespace Analyzing_the_effectiveness_of_collection_methods;

public class EffectivensessOfStack : IEffectiveness
{
    public string NameOfCollection { get; } = nameof(stack);
    private Stack<int> stack;
    private const int min = -1000000;
    private const int max = 1000000;
    const int size = 10000000;
    
    public string GetNameOfCollection()
    {
        return NameOfCollection;
    }

    public void Setup()
    {
        stack = new Stack<int>(size);
        for (int i = 0; i < stack.Capacity; i++)
        {
            stack.Push(Random.Shared.Next(min,max));
        }
    }

    public void Add()
    {
        stack.Push(Random.Shared.Next(min,max));
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
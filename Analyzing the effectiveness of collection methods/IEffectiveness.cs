namespace Analyzing_the_effectiveness_of_collection_methods;

public interface IEffectiveness
{
    public string NameOfCollection { get; }
    public void Setup();
    public void Add();
    public void Delete();
    public void Find();
    public void Sort();
}
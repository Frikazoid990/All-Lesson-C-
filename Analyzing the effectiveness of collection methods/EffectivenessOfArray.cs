namespace Analyzing_the_effectiveness_of_collection_methods;

public class EffectivenessOfArray : IEffectiveness // один файл - один класс
{

    const int size = 10000000;
    private int count;
    private int[] array;
    private const int min = -1000000;
    private const int max = 1000000;
    public string NameOfCollection { get; } = nameof(array);
    public void Setup()
    {
        count = size;
        array = new int[size];
        for (var i = 0; i < array.Length; i++)
        {
            array[i] = Random.Shared.Next(min,max); //числа выглядят как глобальные константы, но зашиты везде. так делать точно не надо. как минимум - локальную переменную
            
        }
    }
    public void Add()
    {
        if (count >= array.Length)
        {
            var temp = new int[array.Length * 2];
            array.CopyTo(temp, 0);
            temp[count] = count;
            array = temp;
        }
        else
        {
            array[count] = count;
        }
        
        count++;
    }
    public void Delete()
    {
        for (var i = 0; i < count - 1; i++)
        {
            array[i] = array[i + 1];
        }

        count--;
        array[count] = default!;
    }
    public void Find()
    {
        var FindNumber = array[Random.Shared.Next(0, array.Length)];
        Array.Find(array, i => i == FindNumber);
    }
    public void Sort()
    {
        var temp = (int[])array.Clone();
        Array.Sort(temp);
    }
}
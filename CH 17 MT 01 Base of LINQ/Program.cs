namespace CH_17_MT_01_Base_of_LINQ;

class Program
{
    static void Main(string[] args)
    {
        string[] people = new []{ "Tom", "Jane", "Doe", "Fred", "Tim", "Teddy" };

        var selectedPeople = new List<string>();

        var selectedPeopleExample = from p in people
            where p.ToUpper().StartsWith("T")
            orderby p
            select p;
        
        var selectedPeopleExampleWithMethods = people.Where(p => p.ToUpper().StartsWith("T"))
            .OrderBy(p => p);
        
        foreach (string person in people)
        {
            if(person.ToUpper().StartsWith('T')) 
                selectedPeople.Add(person);
        }
        selectedPeople.Sort();

        foreach (var person in selectedPeople)
        {
            Console.WriteLine(person);
        }
    }
}
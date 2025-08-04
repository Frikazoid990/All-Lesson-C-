namespace Ch_8_MT_03_Indexers;

public class Company
{
    public Person[] personal;

    public Company(Person[] personal) => this.personal = personal;
    
    //indexers
    public Person this[int index]
    {
        get
        {
            if(index >= 0 && index < personal.Length)
                return personal[index];
            else
                throw new ArgumentOutOfRangeException();
            
        }
        set
        {
            if (index >= 0 && index < personal.Length)
            {
                personal[index] = value;
            }
        }
    }
    
    public Person this[string name]
    {
        get
        {
            foreach (var person in personal)
            {
                if (person.Name == name) return person;
            }
            throw new Exception("Unknown name");
        }
    }
}
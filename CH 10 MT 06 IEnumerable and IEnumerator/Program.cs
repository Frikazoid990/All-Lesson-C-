using System.Collections;

namespace CH_10_MT_06_IEnumerable_and_IEnumerator;

class Program
{
    static void Main(string[] args)
    {
        var l = new List<int>();
        Week week = new Week();

        foreach (var day in week)
        {
            Console.WriteLine(day);
        }
    }
}

public class Week : IEnumerable
{
    string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
        "Friday", "Saturday", "Sunday" };

    public IEnumerator GetEnumerator() => new WeekEnumerator(days);
    
}

class WeekEnumerator : IEnumerator
{
    string[] days;
    int position = -1;

    public WeekEnumerator(string[] days) => this.days = days;
    
    
    public bool MoveNext()
    {
        if (position < days.Length - 1)
        {
            position++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Reset() => position = -1;

    public object? Current
    {
        get
        {
          if(position == -1 || position >= days.Length)
              throw new ArgumentException();
          return days[position];
        }
    }
}
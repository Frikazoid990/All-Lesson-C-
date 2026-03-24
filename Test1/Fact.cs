namespace Test1;

public class Fact
{
    private readonly double x;
    private double result = 1;
    
    public Fact(double x)
    {
        this.x = x;
    }
    
    

    public void Calculation()
    {
        if (x == 0 || x == 1)
        {
            return;
        }
        for (int i = 1; i <= x; i++)
        {
            result = result * i;
        }
    }

    public void Result()
    {
        if (result > 0)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(1);
        }
    }

}
namespace Test1;

public class A<T> where T : B
{
    public void Run(T input)
    {
        if (input.Z == 0)
            throw new NotImplementedException();
    }
}



public class B
{
    public int Z;
}
public class C : B
{

}
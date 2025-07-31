namespace Ch7_MT_05_Inheritance_of_the_interfaces;

class Program
{
    static void Main(string[] args)
    {
        IAction act1 = new RunActionExample1();
        act1.Move();
        
        IRunAction act2 = new RunActionExample1();
        act2.Move();
        Console.WriteLine("------------------------------------");
        IAction act3 = new RunActionExample2();
        act3.Move();
        IRunAction act4 = new RunActionExample2();
        act4.Move();
        RunActionExample2 act5 = new RunActionExample2();
        act5.Move();

    }

}


interface IAction
{
    void Move() => Console.WriteLine("I`m moving");
}

interface IRunAction: IAction
{
    new void Move() => Console.WriteLine("I`m running");
}

public class RunActionExample1 : IRunAction
{
        
}

public class RunActionExample2 : IRunAction
{
    public void Move() => Console.WriteLine("I`m tired");
}
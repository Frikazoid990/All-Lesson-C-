namespace MT_03_Threads_with_params;

class Program
{
    static void Main(string[] args)
    {
        // Thread thread1 = new Thread(new ParameterizedThreadStart(Print));
        // Thread thread2 = new Thread(Print);
        // Thread thread3 = new Thread(message => Console.WriteLine("{0}", message));
        // thread1.Start(1);
        // thread2.Start(2);
        // thread3.Start("Hello");
        //


        var number = 4;
        Thread thread4 = new Thread(new ParameterizedThreadStart(Print1));
        thread4.Start(number);
        var tom = new Person("Tom", 24);
        Thread thread5 = new Thread(new ParameterizedThreadStart(Print1));
        thread5.Start(tom);
    }

    static void Print(object param)
    {
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine("{2}  Поток номер: {0}: {1}",param, i, DateTime.Now);
            Thread.Sleep(500);
            
        }
    }

    static void Print1(object param)
    {
        if (param is int n)
        {
            Console.WriteLine($"{DateTime.Now}: n * n: {n * n}");
        }

        if (param is Person person)
        {
            Console.WriteLine($"{DateTime.Now}:\n" +
                              $"Name:{person.Name}\n" +
                              $"Age:{person.Age}");
        }
    }
}

public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public string Name { get; set; }
    
    public int Age { get; set; }
}

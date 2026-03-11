namespace MT_03_Threads_with_params;

class Program
{
    static void Main(string[] args)
    {
        Thread thread1 = new Thread(new ParameterizedThreadStart(Print));
        Thread thread2 = new Thread(Print);
        Thread thread3 = new Thread(message => Console.WriteLine("{0}", message));
        thread1.Start(1);
        thread2.Start(2);
        thread3.Start("Hello");
    }

    static void Print(object param)
    {
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine("{2}  Поток номер: {0}: {1}",param, i, DateTime.Now);
            Thread.Sleep(500);
            
        }
    }
}

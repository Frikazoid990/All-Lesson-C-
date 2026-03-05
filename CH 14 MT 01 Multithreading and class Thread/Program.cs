namespace CH_14_MT_01_Multithreading_and_class_Thread;

class Program
{
    static void Main(string[] args)
    {
        var currentThread = Thread.CurrentThread;

        Console.WriteLine($"Name of current thread:{currentThread.Name}");
        currentThread.Name = "Main";
        Console.WriteLine($"Name of current thread:{currentThread.Name}");
        
        Console.WriteLine($"Thread is start: {currentThread.IsAlive}");
        Console.WriteLine($"Thread id`s {currentThread.ManagedThreadId}");
        Console.WriteLine($"Thread priority: {currentThread.Priority}");
        Console.WriteLine($"Thread state:{currentThread.ThreadState}");
    }
}
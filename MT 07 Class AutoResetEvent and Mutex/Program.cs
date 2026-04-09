namespace MT_07_Class_AutoResetEvent_and_Mutex;

class Program
{
    static Lock locker = new();
    static AutoResetEvent waitHandler = new AutoResetEvent(true);
    static int x = 0;
    static Mutex mutexObj = new();
    static void Main(string[] args)
    {
        for (var i = 1; i < 6; i++)
        {
            Thread myThread = new(PrintWithMutex);
            myThread.Name = $"Поток {i}";
            myThread.Start();
        }
    }

    static void Print()
    {
        lock (locker)
        {
            x = 1;
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                x++;
                Thread.Sleep(100);
            }
        }
    }

    static void PrintWithAutoResetEvent()
    {
        waitHandler.WaitOne();
        x = 1;
        for (int i = 1; i < 6; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
            x++;
            Thread.Sleep(100);
        }
        waitHandler.Set();
    }
    
    static void PrintWithMutex()
    {
        mutexObj.WaitOne();     // приостанавливаем поток до получения мьютекса
        x = 1;
        for (int i = 1; i < 6; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
            x++;
            Thread.Sleep(100);
        }
        mutexObj.ReleaseMutex();    // освобождаем мьютекс
    }
}
namespace MT_05_Monitors;

class Program
{
    static int x = 0;
    static object locker = new();  // объект-заглушка
    static void Main(string[] args)
    {

        // запускаем пять потоков
        for (int i = 1; i < 6; i++)
        {
            Thread myThread = new(PrintWithKeywordLock);
            myThread.Name = $"Поток {i}";
            myThread.Start();
        }
    }

    static void PrintWithKeywordLock()
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

    static void PrintWithMonitorLock()
    {
        bool acquiredLock = false;
        try
        {
            Monitor.Enter(locker, ref acquiredLock);
            x = 1;
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                x++;
                Thread.Sleep(100);
            }
        }
        finally
        {
            if (acquiredLock)
            {
                Monitor.Exit(locker);
            }
        }
    }
}

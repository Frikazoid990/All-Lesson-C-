int x = 0; //некоторый общий ресурс
Lock _locker = new();

for (int i = 1; i < 6; i++)
{
    Thread myThread1 = new Thread(PrintWithKeyWordlock);
    myThread1.Name = $"Поток with key word lock {i}";
    myThread1.Start();
}

for (int i = 1; i < 6; i++)
{
    Thread myThread2 = new Thread(PrintWithMethodEnter);
    myThread2.Name = $"Поток with method enter {i}";
    myThread2.Start();
}

for (int i = 1; i < 6; i++)
{
    Thread myThread2 = new Thread(PrintWithEnterScope);
    myThread2.Name = $"Поток with method enter {i}";
    myThread2.Start();
}

void PrintWithKeyWordlock()
{
    lock (_locker)
    {
        x = 1;
        for (int i = 1; i < 6; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
            x++;
            Thread.Sleep(150);
        }    
    }
}

void PrintWithMethodEnter()
{
    _locker.Enter();
    try
    {
        x = 1;
        for (int i = 1; i < 6; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
            x++;
            Thread.Sleep(150);
        }
    }
    finally
    {
        _locker.Exit();
    }
}

void PrintWithEnterScope()
{
    using (_locker.EnterScope())
    {
        x = 1;
        for (int i = 1; i < 6; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
            x++;
            Thread.Sleep(150);
        }
    }
}
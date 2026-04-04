int x = 0; //некоторый общий ресурс
Lock _locker = new();

for (int i = 1; i < 6; i++)
{
    Thread myThread = new Thread(PrintWithKeyWordlock);
    myThread.Name = $"Поток {i}";
    myThread.Start();
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
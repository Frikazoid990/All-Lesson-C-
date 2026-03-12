var x = 0;



for (int i = 1; i < 6; i++)
{
    Thread myThread = new(Print);
    myThread.Name = $"Поток {i}";   // устанавливаем имя для каждого потока
    myThread.Start();
}

Thread.Sleep(1000);
Console.WriteLine(x);
x = 0;
var locker = new Object();
for (int i = 1; i < 6; i++)
{
    Thread myThread = new(PrintWithLock);
    myThread.Name = $"Поток {i}";   // устанавливаем имя для каждого потока
    myThread.Start();
}

void Print()
{
    x = 1;
    for (int i = 1; i < 6; i++)
    {
        Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
        x++;
        Thread.Sleep(100);
    }
}

void PrintWithLock()
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
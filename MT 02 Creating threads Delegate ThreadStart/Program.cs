var thread1 = new Thread(Print);
var thread2 = new Thread(new ThreadStart(Print));
var thread3 = new Thread(() => Console.WriteLine("Thread 3"));
thread1.Start();
thread2.Start();
thread3.Start();

Thread myThread = new Thread(Print1);
// запускаем поток myThread
myThread.Start();
 
// действия, выполняемые в главном потоке
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Главный поток: {i}");
    Thread.Sleep(600);
}
 
// действия, выполняемые во втором потокке
void Print1()
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Второй поток: {i}");
        Thread.Sleep(700);
    }
}

void Print() => Console.WriteLine($"Hello");
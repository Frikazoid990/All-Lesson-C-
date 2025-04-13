using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchrone_methods__async_and_await
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await PrintAsync();

            var tomTask = PrintNameAsync("Tom");
            var bobTask = PrintNameAsync("Bob");
            var samTask = PrintNameAsync("Sam");

            await tomTask;
            await bobTask;
            await samTask;
            // определение асинхронного метода


        }

        static async Task PrintNameAsync(string name)
        {
            await Task.Delay(3000);     // имитация продолжительной работы
            Console.WriteLine(name);
        }

        static void Print()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Hello");
        }

        static async Task PrintAsync()
        {
            Console.WriteLine("Начало асинхронного метода");
            await Task.Run(Print);
            Console.WriteLine("Конец асинхронного метода");
        }
    }
}

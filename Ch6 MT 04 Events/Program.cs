using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_MT_04_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(100);
            account.Put(20);
            Console.WriteLine($"Сумма на счете: {account.Sum}");
            account.Take(70);   // пытаемся снять со счета 70
            Console.WriteLine($"Сумма на счете: {account.Sum}");
            account.Take(180);  // пытаемся снять со счета 180
            Console.WriteLine($"Сумма на счете: {account.Sum}");
        }
    }
}

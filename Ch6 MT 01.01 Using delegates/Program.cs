using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ch6_MT_01._01_Using_delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем банковский счет
            Account account = new Account(200);
            // Добавляем в делегат ссылку на метод PrintSimpleMessage
            account.RegisterHandler(PrintSimpleMessage);
            // Два раза подряд пытаемся снять деньги
            account.Take(100);
            account.Take(150);

            
        }





        static void PrintSimpleMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

using Events.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(100);
            account.Notify += DisplayMessage;
            account.Notify += DisplayMessage1;
            account.Put(20);
            account.Take(70);
            account.Take(180);
            

        }

        private static void DisplayMessage(string message) => Console.WriteLine(message);

        private static void DisplayMessage1(string message)
        {
            message = "Опа должен был косарь отдать!";
            Console.WriteLine(message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Delegates_codaza
{
    // https://www.youtube.com/watch?v=pP24DbV0uCc&ab_channel=codaza
    class Program
    {
        private delegate void NoParams();

        private delegate void WithParams(string mes);

        // Delegate этот объект может хранить ссылку на метод(ы)
        static void Main(string[] args)
        { 
            NoParams noPrm = ShowMessage1;
            noPrm();

            WithParams withPrm = ShowMyMessage;
            withPrm("Hello with prm");

            noPrm += ShowMessage2;
            noPrm();

            NoParams anonimMeth = delegate ()
            {
                Console.WriteLine("Hello my name is...");

            };
            anonimMeth();
        }

        private static void ShowMyMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static void ShowMessage1()
        {
            Console.WriteLine("Hello");
        }
        private static void ShowMessage2()
        {
            Console.WriteLine("My name is ...");
        }
    }
}

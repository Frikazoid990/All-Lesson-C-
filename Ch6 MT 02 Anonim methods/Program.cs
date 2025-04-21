using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_MT_02_Anonim_methods
{
    class Program
    {
        //delegate void MessageHandler(string message);

        //delegate int Operation(int x, int y);

        //static void ShowMessage(string message, MessageHandler handler)
        //{
        //    handler(message);
        //}

        delegate void MessageHandler(string message);

        static void Main(string[] args)
        {
            MessageHandler handler = (string message) =>
            {
                message += " Skripkin Daniil";
                Console.WriteLine(message);
            };

            handler("Messangers");





            //MessageHandler handler = delegate (string mes)
            //{
            //    Console.WriteLine(mes);
            //};

            //handler("What`s up?");


            //ShowMessage("Hello!...", handler);

            //ShowMessage("hello!", delegate (string mes)
            //{
            //    Console.WriteLine(mes);
            //});

            //Operation operation = delegate (int x, int y)
            //{
            //    return x + y;
            //};

            //int z = operation(2, 1);

            //Console.WriteLine(z);

            //Operation operation1 = delegate (int x, int y)
            //{
            //    return x + y + z;
            //};

            //int result = operation1(2, 1);
            //Console.WriteLine(result);

        }
    }
}

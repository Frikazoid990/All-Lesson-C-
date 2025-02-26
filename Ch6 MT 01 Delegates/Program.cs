using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_MT_01_Delegates
{
    class Program
    {

        delegate void Message();



        delegate int Operation(int x, int y);



        //--------------------------------------------------------------------
        delegate void SomeDel(int a, double b);
        //SomeMethod1 Полностью соответствует delegate SomeDel
        void SomeMethod1(int g, double n) { }
        //Вот эти методы снизу НЕ(!!!!) соответсвуют
        double SomeMethod2(int g, double n) { return g + n; }
        void SomeMethod3(double n, int g) { }
        void SomeMethod4(ref int g, double n) { }
        void SomeMethod5(out int g, double n) { g = 6; }
        //--------------------------------------------------------------------

        static void HelloM() => Console.WriteLine("Hello METANIT.COM");
        static void HowAreYou() => Console.WriteLine("How are you?");

        static int Add(int x, int y) => x + y;

        int Multiply(int x, int y) => x * y;

        public class Welcome
        {
            public static void Print() => Console.WriteLine("Welcome");
        }
        class Hello
        {
            public void Display() => Console.WriteLine("Привет");

        }


        static void Main(string[] args)
        {
            /////++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Message mes1 = Welcome.Print;
            mes1();

            mes1 = HelloM;
            mes1();

            mes1 = new Hello().Display;
            mes1();
            /////++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Operation operation = Add;      // делегат указывает на метод Add
            int result = operation(4, 5);   // фактически Add(4, 5)
            Console.WriteLine(result);      // 9

            operation = new Program().Multiply; // теперь делегат указывает на метод Multiply
            result = operation(4, 5);       // фактически Multiply(4, 5)
            Console.WriteLine(result);      // 20

            Operation operation1 = Add;
            Operation operation2 = new Operation(Add); // Равноценные присвоения делегату методы
            Console.WriteLine();
            /////++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Message message = HelloM;
            message += HowAreYou;
            message += HowAreYou;
            message += HelloM;
            message += HowAreYou;
            message();
            Console.WriteLine();
            message -= HowAreYou;
            message();
            Console.WriteLine();
            message -= HowAreYou;
            message();
            Console.WriteLine();
            /////++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Message mes5 = HelloM;
            Message mes6 = HowAreYou;
            Message mes56 = mes5 + mes6; // объединяем делегаты
            mes56();
            /////++++++++++++++++++++++++++++++++++++++++++++++++++++++

            /////++++++++++++++++++++++++++++++++++++++++++++++++++++++
        }


    }

}

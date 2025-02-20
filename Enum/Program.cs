using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Enum
{
    enum Season
    {
        Winter,
        Summer,
        Autumn,
        Spring
    }
    
    enum DayTime
    {
        Morning,
        Afternoon,
        Evening,
        Night
    }

    internal class Program
    {


        static void Main(string[] args)
        {
            //while (true) {
            //    ConsoleKey key = Console.ReadKey().Key;
            //    Console.WriteLine($"\nВы нажали {key}");
            //}
            DayTime dayTime = (DayTime)3;

            Console.WriteLine(dayTime);

            switch (dayTime)
            {
                case DayTime.Morning:
                    Console.WriteLine("Доброе утро!");
                    break;
                case DayTime.Afternoon:
                    Console.WriteLine("Иди кушай!");
                    break;
                case DayTime.Evening:
                    Console.WriteLine("Иди отдыхай!");
                    break;
                case DayTime.Night:
                    Console.WriteLine("Спокойной ночи");
                    break;
            }





        }
    }
}

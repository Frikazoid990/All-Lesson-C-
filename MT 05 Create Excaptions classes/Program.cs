using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_05_Create_Excaptions_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person() { Age = 17, Name = "Tom" };

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Person person = new Person { Name = "Tom", Age = 17 };
            }
            catch (PersonException1 ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine($"Некорректное значение: {ex.Value}");
            }
        }
    }
}

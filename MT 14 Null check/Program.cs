using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_14_Null_check
{
    internal class Program
    {
        /*
        Оператор условного null
        */
        class Person
        {
            public Company? Company { get; set; }

        }
        class Company
        {
            public string CompanyName { get; set; }
            public string Address { get; set; }
            public string? WebSite { get; set; }
            public int ИНН { get; set; }
        }

        static void PrintWebSite(Person? person)
        {
            if (person != null && person.Company != null && person.Company.WebSite != null)
            {
                Console.WriteLine(person.Company.WebSite.ToUpper());
            }
        }

        static void PrintWebSite1(Person? person)
        {
            Console.WriteLine(person?.Company?.WebSite?.ToUpper());
        }

        static void Main(string[] args)
        {
            void PrintUpper(string? text)
            {
                if (text != null)
                {
                    Console.WriteLine(text.ToUpper());
                }
                else
                {
                    Console.WriteLine($"Error\nNullable type");
                }
            }

            string Name = null;
            PrintUpper(Name);

            /*
            Кроме того, с помощью оператора is мы можем проверить значение объекта:
            */
            //объект is значение

            //Например, проверка параметра/ переменной на значение null:
            //void PrintUpper(string? text)
            //{
            //    if (text is null) return;
            //    Console.WriteLine(text.ToUpper());
            //}

            //Или, наоборот, с помощью is not можно проверить отсутствие значения:
            //void PrintUpper(string? text)
            //{
            //    if (text is not null)
            //        Console.WriteLine(text.ToUpper());
            //}

            /*
            Оператор ??
            */
            //левый_операнд ?? правый_операнд
            //либо же ??= в целом не имеет разницы

            //Оператор ?? возвращает левый операнд, если этот операнд не равен null.Иначе возвращается правый операнд.
            //При этом левый операнд должен принимать null.Посмотрим на примере:

            string? text = null;
            string name = text ?? "Tom";  // равно Tom, так как text равен null
            Console.WriteLine(name);    // Tom

            int? id = 200;
            int personid = id ?? 1; // равно 200, так как id не равен null
            Console.WriteLine(personid);    // 200

            Person Tom = new Person
            {
                Company = new Company
                {
                    CompanyName = "ООО Ромашка",
                    Address = "г. Москва, ул. Ленина, д. 1",
                    WebSite = "https://example.com",
                    ИНН = 1234567890
                }
            };
            Console.WriteLine(Tom.Company.ИНН); 
            PrintWebSite(Tom);
            PrintWebSite1(Tom);
        }
    }
}

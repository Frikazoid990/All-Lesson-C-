using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_OOP_03._02_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Person<string> person1 = new Person<string>("31");

            Person<int> person2 = new UniversalPerson<int>(32);

            UniversalPerson<int> person3 = new UniversalPerson<int>(33);

            StringPerson person4 = new StringPerson("438767");

            Person<string> person5 = new StringPerson("43875");
            // так нельзя написать
            //Person<int> person6 = new StringPerson("45545");
            IntPerson<string> person7 = new IntPerson<string>(123, "ab23");
            Person<int> person8 = new IntPerson<long>(7, 42141242);
            var person9 = (IntPerson<long>)person8;
            person9.code = 102;
            Console.WriteLine(person9.code);
            var person10 = (IntPerson<long>)person8;
            Console.WriteLine(person10.code);
            Console.WriteLine(person1.Id);
            Console.WriteLine(person2.Id);
            Console.WriteLine(person3.Id);
            
        }
    }
}

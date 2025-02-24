using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_OOP_3_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonWithGenerics personBobWithGenerics = new PersonWithGenerics("abc123", "Bob");

            PersonWithGenerics personTomWithGenerics = new PersonWithGenerics(123, "Tom");

            /* Явление описанное выше является boxing и unboxing в данном случае при передачи ID в двух этих случаях система оборачивает все эти значения в System.Object
             * И сохраняет его в куче(hipe)
             * Распаковка же ведет к обратному из object в value type, что влияет на производительность
             * 
             */


            PersonWithoutGenerics personBobWithoutGenerics = new PersonWithoutGenerics(1, "Bob");

            int intBobId = personBobWithoutGenerics.Id;
            int intTomId = (int)personTomWithGenerics.Id;
            string strBobId = (string)personBobWithGenerics.Id;

            Console.WriteLine($"Generic: {strBobId}, Without Generic: {intBobId}, Tom ID: {intTomId}");

        }
    }
}

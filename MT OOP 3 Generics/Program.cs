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
            PersonObj PersonObjBob = new PersonObj("abc123", "Bob");

            PersonObj PersonObjTom = new PersonObj(123, "Tom");

            /* Явление описанное выше является boxing и unboxing в данном случае при передачи ID в двух этих случаях система оборачивает все эти значения в System.Object
             * И сохраняет его в куче(hipe)
             * Распаковка же ведет к обратному из object в value type, что влияет на производительность
            */

            /*
             * Исправляется это классом PersonGeneric (зайди в класс чтобы увидеть реализацию generic)
             * Вот так ->
            */

            PersonGeneric<int, string> PersonGenBobi = new PersonGeneric<int, string>(546, "Bobi");
            Console.WriteLine(PersonGenBobi.Id + " " + PersonGenBobi.Name);

            /*
             * 
            */

            PersonInt personBobWithoutGenerics = new PersonInt(1, "Bob");

            int intBobId = personBobWithoutGenerics.Id;
            int intTomId = (int)PersonObjTom.Id;
            string strBobId = (string)PersonObjBob.Id;

            Console.WriteLine($"Generic: {strBobId}, Without Generic: {intBobId}, Tom ID: {intTomId}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_05_Create_Excaptions_classes
{
    class PersonException1 : ArgumentException
    {
        public int Value {get;}

        public PersonException1(string message,int value) : base(message)
        {
            Value = value;
        }
    }
}

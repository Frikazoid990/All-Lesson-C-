using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_05_Create_Excaptions_classes
{
    public class PersonException : Exception
    {
        public PersonException(string message) : base(message)
        {}
    }
}

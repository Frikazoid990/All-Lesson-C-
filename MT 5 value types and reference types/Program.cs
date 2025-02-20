using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_5_value_types_and_reference_types
{
    internal class Program
    {
        struct State
        {
            public int x;
            public int y;
            public Country country;
            public State()
            {
                x = 0;
                y = 0;
                country = new Country();
            }
        }
        class Country
        {
            public int x;
            public int y;
        }
        static void Main(string[] args)
        {
            State state1 = new State();
            Country country1 = new Country();
        }
    }
}

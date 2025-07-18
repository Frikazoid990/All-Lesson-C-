using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_interfaces
{
    internal interface IMovable
    {
        const int minSpeed = 0;     //Доступно с версией C# 8.0

        static int maxSpeed = 60;   //Доступно с версией C# 8.0

        void Move();                //Движение

        string Name { get; set; }

        delegate void MoveHandler(string message); // определение делегата для события

        event MoveHandler MoveEvent; // событие движения
    }
}

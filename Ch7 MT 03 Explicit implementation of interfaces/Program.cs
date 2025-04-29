using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_implementation_of_interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseAction baseAction1 = new BaseAction();

            // baseAction1.Move();  // ! Ошибка - в BaseAction нет метода Move
            // необходимо приведение к типу IAction
            // небезопасное приведение
            ((IAction)baseAction1).Move();
            // безопасное приведение 
            if (baseAction1 is IAction action) action.Move();
            // или так
            IAction baseAction2 = new BaseAction();
            baseAction2.Move();

            Person person = new Person();
            ((ISchool)person).Study();
            ((IUniversity)person).Study();

            

        }

        class Person : IUniversity, ISchool
        {
            void IUniversity.Study() => Console.WriteLine("Учеба в университете");
            void ISchool.Study() => Console.WriteLine("Учеба в школе");
        }

        interface IUniversity
        {
            void Study();
        }

        interface ISchool
        {
            void Study();
        }


        interface IAction
        {
            void Move();
        }

        class BaseAction : IAction
        {
            void IAction.Move() => Console.WriteLine("Move in Base Class");
        }
    }
}

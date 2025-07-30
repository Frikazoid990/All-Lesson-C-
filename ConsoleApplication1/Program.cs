using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            HeroAction action1 = new HeroAction();
            action1.Move();            // Move in BaseAction
            ((IAction)action1).Move(); // Move in HeroAction
            
            IAction action2 = new HeroAction();
            action2.Move();     
        }
    }

    interface IAction
    {
        void Move();
    }

    class BaseAction : IAction
    {
        public void Move()
        {
            Console.WriteLine("Move in BaseAction");
        }
    }

    class HeroAction : BaseAction, IAction
    {
        void IAction.Move() => Console.WriteLine("Move in HeroAction");
    }
    
}
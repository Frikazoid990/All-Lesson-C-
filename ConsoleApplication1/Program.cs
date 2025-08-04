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
            
            var sample = new Sample();
            var overrided = new OverridedSample();

            Console.WriteLine(sample.Virtuals[Sample.GetValuePosition].DynamicInvoke(sample));
            Console.WriteLine(overrided.Virtuals[Sample.GetValuePosition].DynamicInvoke(sample));
        }
    }

    public class Sample
    {
        public const int GetValuePosition = 0;

        public Delegate[] Virtuals;

        public int _x;

        public Sample()
        {
            Virtuals = new Delegate[1] { 
                new Func<Sample, int>(GetValue) 
            };
        }

        public static void ChangeTo(Sample self, int newValue)
        {
            self._x = newValue;
        }

        public static int GetValue(Sample self)
        {
            return self._x;
        }
    }

    public class OverridedSample : Sample
    {
        public OverridedSample() : base()
        {
            Virtuals[0] = new Func<Sample, int>(GetValue);
        }

        public static new int GetValue(Sample self)
        {
            return 666;
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
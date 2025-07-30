IAction action1 = new HeroActionWithOverride();
action1.Move();  // Move in HeroAction
BaseActionWithOverride action2 = new HeroActionWithOverride();
action2.Move(); // Move in HeroAction
Console.WriteLine();

IAction action3 = new HeroActionHidingMethod();
action3.Move();// Move in BaseAction
BaseActionHidingMethod action4 = new HeroActionHidingMethod();
action4.Move();// Move in BaseAction
HeroActionHidingMethod action5 = new HeroActionHidingMethod();
action5.Move();// Move in HeroAction
Console.WriteLine();

IAction action6 = new HeroActionRepeatedImplementation();
action6.Move();// Move in HeroAction
BaseActionRepeatedImplementation action7 = new HeroActionRepeatedImplementation();
action7.Move();// Move in BaseAction
HeroActionRepeatedImplementation action8 = new HeroActionRepeatedImplementation(); 
action8.Move();// Move in HeroAction
Console.WriteLine();

IAction action9 = new HeroActionExplicitImplementation();
action9.Move(); // Move in IAction
BaseActionExplicitImplementation action10 = new HeroActionExplicitImplementation();
action10.Move(); // Move in BaseAction
HeroActionExplicitImplementation action11 = new HeroActionExplicitImplementation();
action11.Move(); // Move in HeroAction


interface IAction
{
    void Move();
}
//Изменение реализации в наследнике
class BaseActionWithOverride : IAction
{
    public virtual void Move() => Console.WriteLine("Move in BaseAction");
}
class HeroActionWithOverride : BaseActionWithOverride, IAction
{
    public override void Move() => Console.WriteLine("Move in HeroAction");
}

class BaseActionHidingMethod : IAction
{
    public void Move() => Console.WriteLine("Move in BaseAction");
}
class HeroActionHidingMethod : BaseActionHidingMethod
{
    public new void Move() => Console.WriteLine("Move in HeroAction");
}

class BaseActionRepeatedImplementation : IAction
{
    public void Move() => Console.WriteLine("Move in BaseAction");
}
class HeroActionRepeatedImplementation : BaseActionRepeatedImplementation, IAction
{
    public new void Move() => Console.WriteLine("Move in HeroAction");
}

class BaseActionExplicitImplementation : IAction
{
    public void Move() => Console.WriteLine("Move in BaseAction");
}
class HeroActionExplicitImplementation : BaseActionExplicitImplementation, IAction
{
    public new void Move() => Console.WriteLine("Move in HeroAction");
    void IAction.Move() => Console.WriteLine("Move in IAction");
}








 

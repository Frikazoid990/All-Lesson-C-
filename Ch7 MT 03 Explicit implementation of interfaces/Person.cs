using System;

public delegate void MoveHandler();

public interface IMovable
{
    protected internal void Move();
    protected internal string Name { get; }

    protected internal event MoveHandler MoveEvent;
}

public class Person : IMovable
{
    string name;

    MoveHandler MoveEvent;

    event MoveHandler IMovable.MoveEvent
    {
        add => MoveEvent += value;

        remove => MoveEvent -= value;
    }

    string IMovable.Name { get => name; }

    public Person(string name) => this.name = name;

    void IMovable.Move()
    {
        Console.WriteLine($"{name} is walking");
        MoveEvent?.Invoke();
    }
}

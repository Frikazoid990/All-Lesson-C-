namespace Ch7_MT_06_Interfaces_in_gereic;

class Program
{
    static void Main(string[] args)
    {
        var telegram = new Messenger<Message>();

        var message = new Message("Hello World!");
        
        telegram.Send(message);
        
        var telegram1 = new Messenger<IPrintableMessage>();
        var message1 = new PrintableMessage("Hello World!");
        telegram1.Send(message1);

        IUser<int> user1 = new User<int>(6789);
        Console.WriteLine(user1.id);
        
        IUser<string> user2 = new User<string>("12345 - string");
        Console.WriteLine(user2.id);
        
        IUser<int> user3 = new IntUser(6789);
        Console.WriteLine(user3.id);
    }
}

interface IMessage
{
    string Text{ get; }
}

interface IPrintable
{
    void Print();
}

class Message : IMessage, IPrintable
{
    public string Text { get; }
    public void Print()
    {
        Console.WriteLine(Text);
    }
    public Message(string text) => Text = text;
    
}
interface IPrintableMessage: IPrintable, IMessage { }
class PrintableMessage : IPrintableMessage
{
    public string Text { get; }
    public PrintableMessage(string text) => Text = text;
    public void Print() => Console.WriteLine(Text);
}
class Messenger<T> where T : IMessage, IPrintable
{
    public void Send(T message)
    {
        Console.WriteLine($"Message sent");
        message.Print();
    }
}

interface IUser<T>
{
    T id { get; }
}

class User<T> : IUser<T>
{
    public T id { get; }
    public User(T id) => this.id = id;
}

class IntUser : IUser<int>
{
    public int id { get; }
    public IntUser(int id) => this.id = id;
}

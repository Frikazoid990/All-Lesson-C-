using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_MT_05_Covariance_and_contravariance_of_delegates
{
    public class Message
    {
        public string Text { get; }

        public Message(string text) => Text = text;

        public virtual void Print() => Console.WriteLine(Text);
    }

    public class EmailMessage : Message
    {
        public EmailMessage(string text) : base(text)
        {
        }
        public override void Print() => Console.WriteLine($"Email: {Text}");
    }

    public class SmsMessage<T> : Message
    {
        public SmsMessage(string text) : base(text)
        {
        }
        public override void Print() => Console.WriteLine($"Sms:{Text}");
    }
}
  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_OOP_03._01_Generic
{
    class Program
    {

        static void SendMessage<T>(T message) where T : Message
        {
            Console.WriteLine(message.text);
        }
        static void Main(string[] args)
        {
            SendMessage(new EmailMassage("Hello, my name is...", @"0@frikazoid.ru"));

            Messanger<Message> telegram = new Messanger<Message>();
            telegram.SendMessage(new Message("Hello...telegram"));

            Messanger<EmailMassage> email = new Messanger<EmailMassage>();
            var EmailSend = new EmailMassage("Hello...email", "0@frikazoid.ru");
            email.SendMessage(EmailSend);
        }
    }
}

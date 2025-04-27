using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_MT_05_Covariance_and_contravariance_of_delegates
{
    internal class Program
    {
        delegate Message MessageBuilder(string text);

        delegate void EmailReciver(EmailMessage message);
        static void Main(string[] args)
        {
            // делегату с базовым типом передаем метод с производным типом
            MessageBuilder messageBuilder = WriteEmailMessage; // ковариантность
            Message message = messageBuilder("Hello");
            message.Print();    // Email: Hello
            
            EmailReciver emailBox = ReceiveMessage;
            emailBox(new EmailMessage("Holla!"));
        }
        static EmailMessage WriteEmailMessage(string text) => new EmailMessage(text);
        static void ReceiveMessage(Message message) => message.Print();
    }
}

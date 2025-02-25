using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_OOP_03._01_Generic
{

    public class Messanger<T> where T: Message
    {
        public void SendMessage(T message) 
        {
            Console.WriteLine(message.text);
        }
    }

    public class Message
    {
        public string text { get;}

        public Message(string text)
        {
            this.text = text;
        }

    }

    public class EmailMassage : Message
    {
        public string email { get; set; }

        public EmailMassage(string text, string email) : base(text)
        {
            this.email = email;
        }
    }

    public class SMSMassage : Message
    {
        public string telnumber { get; set; }

        public SMSMassage(string text, string telnumber) : base(text)
        {
            this.telnumber = telnumber;
        }
    }


}

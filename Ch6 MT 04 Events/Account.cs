using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_MT_04_Events
{
    public class Account
    {
        public delegate void AccountHandler(string message);

        public event AccountHandler Notify;

        // сумма на счете
        public int Sum { get; private set; }
        // в конструкторе устанавливаем начальную сумму на счете
        public Account(int sum) => Sum = sum;
        // добавление средств на счет

        public void Put(int sum)
        {
            Sum += sum;
        }
        // списание средств со счета
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
            }
        }
    }
}

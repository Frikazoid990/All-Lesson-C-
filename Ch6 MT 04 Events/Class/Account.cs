using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Class
{
    

    public class Account
    {
        public delegate void AccountHandler(string message);

        public event AccountHandler? Notify;

        public int sum { get; private set; }

        public Account(int sum) { this.sum = sum; }

        public void Put(int sum)
        {
            this.sum += sum;
            Notify?.Invoke($"На счет поступило: {sum}");
        }

        public void Take(int sum)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;
                Notify?.Invoke($"Со счета снято: {sum}");   // 2.Вызов события
            }
            else
            {
                Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {this.sum}"); ;
            }
        }
    }
}

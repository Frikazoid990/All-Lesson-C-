using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_MT_01._01_Using_delegates.Test
{
    public delegate void AccountHandler1(string message);
    public class Account1
    {
        int sum;

        AccountHandler1? taken;

        public void RegisterHandler(AccountHandler1 del)
        {
            this.taken = del;
        }

        public Account1(int sum) => this.sum = sum;

        public void Add(int sum) => this.sum += sum;

        public void Take(int sum)
        {
            if(this.sum >= sum)
            {
                this.sum -= sum;
                taken?.Invoke($"Со счета списано {sum} у.е.");
            }
            else
            {
                taken?.Invoke($"На счете недостаточно средств. Баланс: {this.sum} у.е.");
            }
        }

    }
}

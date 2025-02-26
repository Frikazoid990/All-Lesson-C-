using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_MT_01._01_Using_delegates
{
    public delegate void AccountHandler(string message);
    public class Account
    {
        
        AccountHandler? taken;
        private int sum;
        public Account(int sum)
        {
            this.sum = sum;
        }

        public void RegisterHandler(AccountHandler del)
        {
            taken = del;
        }

        public void Add(int sum)
        {
            this.sum += sum;
        }

        public void Take(int sum)
        {
            if(sum < 0)
            {
                throw new ArgumentException("Сумма не может быть отрицательной!");
                
            }
            else if(this.sum >= sum && sum > 0)
            {
                this.sum -= sum;
                taken?.Invoke($"Со счета списано {sum} у.е.");
            }
            else
            {
                taken?.Invoke($"На счете недостаточно средств!\nБаланс: {this.sum}");
            }

        }
    }
}

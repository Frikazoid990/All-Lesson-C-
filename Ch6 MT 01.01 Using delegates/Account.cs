
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

        // Регистрируем делегат
        public void RegisterHandler(AccountHandler del)
        {
            taken += del;
        }
        // Отмена регистрации делегата
        public void UnregisterHandler(AccountHandler del)
        {
            taken -= del; // удаляем делегат
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
                taken?.Invoke($"Со счета списано {sum}");
            }
            else
            {
                taken?.Invoke($"На счете недостаточно средств!\nБаланс: {this.sum}");
            }

        }
    }
}

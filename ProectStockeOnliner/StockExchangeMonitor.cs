using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProectStockeOnliner
{
    
    public class StockExchangeMonitor
    {
        public delegate void PriceChange(int price);
        
        public PriceChange PriceChangeHandler { get; set; }

        public void Start()
        {
            while (true)
            {
                int bankOfAmercaPrice = (new Random().Next(100));

                PriceChangeHandler(bankOfAmercaPrice);

                Thread.Sleep(2000);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProectStockeOnliner
{
    class Program
    {
        static void Main(string[] args)
        {
            StockExchangeMonitor stock = new StockExchangeMonitor();
            stock.PriceChangeHandler = ShowPrice;
            stock.Start();
        }

        public static void ShowPrice(int price)
        {
            Console.WriteLine($"Текущая цена: {price}");
        }
    }
}

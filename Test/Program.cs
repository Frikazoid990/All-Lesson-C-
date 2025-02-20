using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static int Combin1(int N, int K)                                       //Вариант 9
        {
            int C = 0;
            if ((K == 0) || (N == K))
            {
                C = 1;
                return C;
            }

            C = Combin1(N - 1, K) + Combin1(N - 1, K - 1);

            return C;
        }

        static void Main(string[] args)
        {
            int N = 0;
            int K = 0;
            int C = 0;
            int count = 0;
            Console.Write("Введите значение переменной N (N > 0): ");
            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Введите значение переменной K (0 <= K <= N (N = {N})): ");
                K = Convert.ToInt32(Console.ReadLine());

                C = Combin1(N, K);
                if ((K != N) & (K != 0))
                    count = 1 + (N - K) + K;
                else
                    count = 1;

                Console.WriteLine($"Число сочетаний С({N},{K}) = {C}. Число вызовов рекурсивной функции count = {count}");
            }

            Console.ReadLine();
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Toothed_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];

            array[0] = new int[3];
            array[1] = new int[2];
            array[2] = new int[5];
            
            Random random = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = new int[Convert.ToInt32(Console.ReadLine())];
            //}
            
            for (int i =0; i< array.Length; i++)
            {
                for (int j =0; j < array[i].Length; j++)
                {

                    array[i][j] = random.Next(1,1000);
                    Console.Write(array[i][j] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}

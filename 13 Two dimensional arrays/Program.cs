using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Two_dimensional_arrays
{
    internal class Program
    {
        /*
        Все возможные способы определения двухмерных массивов:
        1. int[,] name;
        2. int [,] name = new int[2,3];
        3. int [,] name = new int [2,3] { {0,1,2} , {3,4,5} };
        4. int [,] name = new int[,] { {0,1,2} , {3,4,5} };
        5. int [,] name = new[,] { {0,1,2} , {3,4,5} };
        6. int [,] name = { {0,1,2} , {3,4,5} };
        */
        static void Main(string[] args)
        {
            int[,] array1 = { { 3, 4 }, { 5, 7 }, { 3, 8 } };
            Console.WriteLine(array1.Rank);
            Console.WriteLine("Выводим массив");
            for (int i = 0; i < array1.GetLength(0); i++) {
                for (int j = 0; j < array1.GetLength(1); j++) {
                    Console.Write(array1[i,j] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}

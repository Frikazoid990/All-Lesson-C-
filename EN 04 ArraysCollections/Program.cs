using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN_04_ArraysCollections
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void ListDemo()
        {
            List<int> intList = new List<int>() { 1, 4, 2, 7, 5, 9, 12 };
            intList.Add(7);

            int[] intArray = { 1, 2, 3 };
            intList.AddRange(intArray);

            if (intList.Remove(1)) //первый попавшийся
            {

            }
            else { }

            intList.RemoveAt(0);

            intList.Reverse();

            bool contains = intList.Contains(3);
            Console.WriteLine(contains);
            int min = intList.Min();
            int max = intList.Max();

            Console.WriteLine($"Min = {min}, Max = {max}");

            int indexOf = intList.IndexOf(2);
            int lastIndexOf = intList.LastIndexOf(2);
            Console.WriteLine($"IndexOf2 = {indexOf}, LastIndexOf2 = {lastIndexOf}");

            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{intList[i]} ");
            }
            Console.WriteLine();
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }

        static void ArrayType()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = Array.BinarySearch(numbers, 7);
            Console.WriteLine(index);

            int[] copy = new int[10];
            Array.Copy(numbers, copy, numbers.Length);

            int[] anotherCopy = new int[10];
            copy.CopyTo(anotherCopy, 0);

            Array.Reverse(copy);
            foreach (var c in copy)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Array.Sort(copy);
            foreach (var c in copy)
            {
                Console.Write(c + " ");
            }

            Array.Clear(copy, 0, copy.Length);


            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

            int[] a4 = { 1, 3, 2, 4, 5 };
        }
    }
}

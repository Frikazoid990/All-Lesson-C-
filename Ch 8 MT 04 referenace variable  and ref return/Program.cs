using System.Security.Cryptography;

namespace Ch_8_MT_04_referenace_variable__and_ref_return;

class Program
{
    static void Main(string[] args)
    {
        int x = 5;
        // ref int xRef - error 
        ref int xRef = ref x;
        Console.WriteLine($"xRef: {xRef}");

        xRef = 125;
        Console.WriteLine($"x: {x}");

        x = 625;
        Console.WriteLine($"xRef: {xRef}");

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7};
        ref int numbersRef = ref Find(4,numbers);
        Console.WriteLine(numbersRef);
        numbersRef = 99;
        Console.WriteLine();
        foreach (var number in numbers)
        {
            Console.Write(" " + number);
        }
        
        
    }

    static ref int Find(int number, int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == number)
            {
                return ref numbers[i];
            }
        }
        throw new IndexOutOfRangeException("Number not found");
    }
}
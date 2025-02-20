using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Tell me your name");

            //string name = Console.ReadLine();

            //string sentence = $"Your name is {name}";
            //Console.WriteLine(sentence);

            Console.WriteLine("Tell me age");

            string input = Console.ReadLine();

            int age = int.Parse(input);

            string sentence = $"Your age is {age}";

            Console.WriteLine(sentence);

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Newstyle");





        }

        static void ComparingStrings() {
            string str1 = "abcde";
            string str2 = "abcde";

            bool areEqual = str1 == str2;
            Console.WriteLine(areEqual);

            areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(areEqual);

        }

        static void StrinFormat()
        {
            string name = "John";
            int age = 30;
            string str1 = string.Format("My name is {0} and I`m {1}", name, age);
            string str2 = $"My name is {name} and I`m {age}";
            //string str2 = "My name is" + name + "and I`,m" + age;

            string str3 = $"My name is\n{name}";
            string str4 = "I`m \t 30";

            str3 = $"My name is{Environment.NewLine}John";
            //string str 5 = "I`m John and I`m a "good" programmer"
            string str5 = "I`m John and I`m a \"good\" programmer";

            //string str6 = "C:\\tmp\\pest_file.txt";
            string str6 = @"C:\tmp\test_file.txt";

            int answer = 42;

            string result = string.Format("{0:d}", answer);
            string result2 = string.Format("{0:d4}", answer);
            Console.WriteLine(result);
            Console.WriteLine(result2);

            result = string.Format("{0:f}", answer);
            result2 = string.Format("{0:f4}", answer);

            Console.OutputEncoding = Encoding.UTF8;

            double money = 12.8;
            result = string.Format("{0:C}", money);
            result2 = string.Format("{0:C2}", money);
            Console.WriteLine(money.ToString("C2"));
            Console.WriteLine(result2);
        }

        static void StringBuilderDemo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John");
            sb.AppendLine("!");
            sb.AppendLine("Hello");

            string str = sb.ToString();
            Console.WriteLine(str);
        }

        static void StringModification()
        {

            string nameConcat = string.Concat("My", "name", "is", "Daniil");
            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ", "My", "name", "is", "Daniil");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Insert(0, "By the way ");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Remove(0, 1);
            Console.WriteLine(nameConcat);

            //nameConcat = string.Concat('B', nameConcat);
            nameConcat = nameConcat.Insert(0, "B");

            string replaced = nameConcat.Replace('n', 'z');
            Console.WriteLine(replaced);

            string data = "12;28;34;25;64";
            string[] split = data.Split(';');
            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);

            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]);
            Console.WriteLine(nameConcat[0]);

            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);

            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            string john = " My name is John ";

            Console.WriteLine(john.Trim());

        }

        static void QueryingString()
        {
            string name = "abracadabra";
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('E');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            bool endsWithAbra = name.EndsWith("abra");
            Console.WriteLine(endsWithAbra);

            bool startsWithAbra = name.StartsWith("abra");
            Console.WriteLine(startsWithAbra);

            int indexOfA = name.IndexOf('a', 1);
            Console.WriteLine(indexOfA);

            int lastIndexOfR = name.LastIndexOf('r');
            Console.WriteLine(lastIndexOfR);

            Console.WriteLine(name.Length);

            string substrFrom5 = name.Substring(5);
            string substrFromTo = name.Substring(0, 3);
            Console.WriteLine($"{substrFrom5}\n{substrFromTo}");
        }

        static void StringEmptiness()
        {
            string str = string.Empty; // string = "" равноценно
            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = " b";
            string nullString = null;

            Console.WriteLine("IsNullOrEmpty");
            bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(isNullOrEmpty);

            isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(isNullOrEmpty);

            Console.WriteLine();
            Console.WriteLine("IsNullOrWhiteSpace");

            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine(isNullOrWhiteSpace);

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(isNullOrWhiteSpace);

        }
    }
}

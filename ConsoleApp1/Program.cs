using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test1
{
    public class Program
    {
        readonly string pattern;
        public string Type { get; init; } = "2";

        void tt()
        {
        }

        public Program()
        {

        }

        static Program()
        {
            Console.WriteLine("2");
        }
        public static void Main(string[] args)
        {
            var input1 = args[0].ToUpper();
            var cond = input1.Contains("ИНТЕРНЕТ");
            try
            {

            }
            catch (Exception e) when(cond)
            {
            }
            catch (Exception e)
            {
            }
            finally
            {

            }

            
            
            Type += "3";
            pattern = "dfh";
            
            Console.WriteLine("1");
            string input = "2 неделя Аксус ИнтЕрНет-Продажи.xlsx";
            input.Split('.');
            input = input.ToUpper();
            if (input.Contains("ИНТЕРНЕТ"))
                Console.WriteLine("yes");

            Foo1([TestEnum.IsTest]);
            Foo2(TestEnum.IsTest, TestEnum.IsDaniilMade, TestEnum.IsDotNet);
            Foo3(TestEnum.IsTest.ToString());
            Foo4(TestEnum.IsTest | TestEnum.IsDaniilMade | TestEnum.IsDotNet);

        }
        
        public class GenericException<T> : Exception
        {
            public GenericException(string msg) : base(msg)
            {
                
            }
            static void ThrowMe(T input)
            {
                switch (input.GetType())
                {
                    case 
                }
                throw new GenericException<T>();
            }
        }
        
        public static void Foo1(TestEnum[] bar) //[1,2,3]
        {
            if (bar.Contains(TestEnum.IsTest))
            {
                Console.WriteLine("testCase");
            }
        }
        
        public static void Foo2(params TestEnum[] bar) //[1,2,3]
        {
            if (bar.Contains(TestEnum.IsTest))
            {
                Console.WriteLine("testCase");
            }
        }
        
        public static void Foo3(string barRaw) //"IsTest,IsDaniilMade"
        {
            var bar = barRaw.Split(',').Select(x => Enum.Parse<TestEnum>(x));
            if (bar.Contains(TestEnum.IsTest))
            {
                Console.WriteLine("testCase");
            }
        }
        
        public static void Foo4(TestEnum bar) //4
        {
            //1 == 0000 0001
            //2 == 0000 0010        
            //4 == 0000 0100         
            //8 == 0000 1000
            if (bar == TestEnum.IsTest)
            {
                Console.WriteLine("testCase");
            }
        }
        
        public static void Foo(TestEnum bar, bool? myBool)
        {
            var tt = TestEnum.IsTest;
            switch (tt)
            {
                case TestEnum.IsTest when myBool.Value: 
                    break;
                case TestEnum.IsTest when !myBool.Value: 
                    break;
                case TestEnum.IsTest: 
                    break;
                case TestEnum.IsDaniilMade:
                    break;
                case TestEnum.IsGitBased:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    [Flags]
    public enum TestEnum
    {
        IsTest = 1,
        IsDaniilMade = 2 ,
        IsGitBased = 4,
        IsDotNet = 8,
    }
}
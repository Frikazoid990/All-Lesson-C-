using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args) 
        {
            string input = "2 неделя Аксус ИнтЕрНет-Продажи.xls";
            input.Split('.');
            input = input.ToUpper();
            if (input.Contains("ИНТЕРНЕТ"))
                Console.WriteLine("yes");

            Foo1([TestEnum.IsTest]);

        }
        void Foo1(TestEnum[] bar)
        {
            if (bar.Contains(TestEnum.IsTest))
            {
                Console.WriteLine("textCase");
            }
        }
        
        void Foo(TestEnum bar, bool? myBool)
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

    public enum TestEnum
    {
        IsTest,
        IsDaniilMade,
        IsGitBased,
        IsDotNet,
    }
}

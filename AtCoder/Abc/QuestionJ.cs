using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionJ
    {
        /// <summary>
        /// B - String Palindrome
        /// https://atcoder.jp/contests/abc159/tasks/abc159_b
        /// </summary>
         public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            string str_S = Console.ReadLine();

            var num_Length = str_S.Length;

            var num_End = (num_Length - 1) / 2;
            var num_Start = (num_Length + 3) / 2;

            var str_New01 = str_S.Substring(0, num_End);

            var str_New02 = str_S.Substring(num_Start - 1);


            if (str_New01 == str_New02) Console.WriteLine("Yes");
            else Console.WriteLine("No");

            Console.Out.Flush();
        }
    }
}

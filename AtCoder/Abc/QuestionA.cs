using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    
    public class QuestionA
    {
        /// <summary>
        /// A - Registration
        /// https://atcoder.jp/contests/abc167/tasks/abc167_a
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            string str_S = Console.ReadLine();

            string str_T = Console.ReadLine();

            int num_Length = str_S.Length;

            if (str_T.Substring(0, num_Length) == str_S) Console.WriteLine("Yes");
            else Console.WriteLine("No");

            Console.Out.Flush();

        }
    }
}

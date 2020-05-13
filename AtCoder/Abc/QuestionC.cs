using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionC
    {

        /// <summary>
        /// ABC081A - Placing Marbles
        /// https://atcoder.jp/contests/abs/tasks/abc081_a
        /// </summary>
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            string str_s = Console.ReadLine();

            char[] str_S = str_s.ToCharArray();

            int num_count = 0;
            foreach (char SS in str_S)
            {
                if (SS=='1')
                {
                    num_count++;
                }
            }

            Console.WriteLine(num_count);

            Console.Out.Flush();
        }
    }
}

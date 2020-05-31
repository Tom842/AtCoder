using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionD
    {

        /// <summary>
        /// B - 1%
        /// https://atcoder.jp/contests/abc165/tasks/abc165_b
        /// </summary>
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            long num_X = long.Parse(Console.ReadLine());

            long num_Sum = 100; //残高

            int num_N = 0;

            while (num_Sum < num_X)
            {
                num_Sum += num_Sum / 100;
                num_N++;
            } 

            Console.WriteLine(num_N);

            Console.Out.Flush();
        }
    }
}

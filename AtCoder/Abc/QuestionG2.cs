using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionG2
    {
        /// <summary>
        /// B - FizzBuzz Sum
        /// https://atcoder.jp/contests/abc162/tasks/abc162_b
        /// </summary>
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            int num_N = int.Parse(Console.ReadLine());

            var num_Sum = Sum(num_N) - Sum(num_N / 3) * 3 - Sum(num_N / 5) * 5 + Sum(num_N / 15) * 15;

            Console.WriteLine(num_Sum);

            Console.Out.Flush();
        }

        public static long Sum(long N)  //1からNまでを順番に足した和を求める式
        {
            long NN = N * (N + 1) / 2;
            return NN;
        }
    }
}

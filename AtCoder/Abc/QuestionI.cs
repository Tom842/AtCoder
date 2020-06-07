using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionI
    {
        /// <summary>
        /// B - Golden Coins
        /// https://atcoder.jp/contests/abc160/tasks/abc160_b
        /// </summary>
        /// <param name="args"></param>

        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            long num_N = long.Parse(Console.ReadLine());

            int num_500Joy = 1000;
            int num_5Joy = 5;

            long num_500Coin = num_N / 500;
            long num_5Coin = (num_N % 500) / 5;

            long result = num_500Coin * num_500Joy + num_5Coin * num_5Joy;

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}

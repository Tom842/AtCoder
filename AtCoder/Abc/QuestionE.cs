using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionE
    {
        /// <summary>
        /// B - Battle
        /// https://atcoder.jp/contests/abc164/tasks/abc164_b
        /// </summary>
      
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var num_ABCD = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            do
            {
                num_ABCD[2] = num_ABCD[2] - num_ABCD[1];
                num_ABCD[0] = num_ABCD[0] - num_ABCD[3];

            } while (num_ABCD[0] > 0 & num_ABCD[2] > 0);

            if (num_ABCD[2] <= 0) //高橋の勝ち
            {
                Console.WriteLine("Yes");
            }
            else if (num_ABCD[0] <= 0)　//青木の勝ち
            {
                Console.WriteLine("No");
            }

            Console.Out.Flush();
        }
    }
}

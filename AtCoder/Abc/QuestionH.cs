using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionH
    {
        /// <summary>
        /// B - Popular Vote
        /// https://atcoder.jp/contests/abc161/tasks/abc161_b
        /// </summary>
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var num_NM= Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            // 整数配列の入力
            var num_A = Console.ReadLine().Split(' ').Select(i => int.Parse(i));

            //総得票数
            double num_SumA = num_A.Sum();

            var num_M = num_NM[1];

            var num_Limit = num_SumA / (4 * num_M);

            var num_Count = num_A.Count(a => a >= num_Limit);

            if (num_Count >= num_M) Console.WriteLine("Yes");
            else Console.WriteLine("No");

            Console.Out.Flush();
        }
    }
}

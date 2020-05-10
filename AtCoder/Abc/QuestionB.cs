using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionB
    {
        /// <summary>
        /// ABC086A - Product
        /// https://atcoder.jp/contests/abs/tasks/abc086_a
        /// </summary>


        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var num_ab = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            int num_Answer = 1;
            foreach (int num_AB in num_ab)
            {
                num_Answer  = num_Answer  * num_AB;
            }

            string result = "";
            if (num_Answer % 2 == 0) result = "Even";
            else result = "Odd";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}

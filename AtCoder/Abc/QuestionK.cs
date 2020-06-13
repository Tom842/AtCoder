using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionK
    {
        /// <summary>
        /// B - Count Balls
        /// https://atcoder.jp/contests/abc158/tasks/abc158_b
        /// </summary>
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var num_Array = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            var num_Unit = num_Array[1] + num_Array[2];

            var num_Set = num_Array[0] / num_Unit;
            var num_SP = num_Array[0] % num_Unit;

            long num_Blue = 0;

            if (num_SP >= num_Array[1])
            {
                num_Blue = num_Set * num_Array[1] + num_Array[1];
            }
            else if (num_SP < num_Array[1])
            {
                num_Blue = num_Set * num_Array[1] + num_SP;
            }

            Console.WriteLine(num_Blue);

            Console.Out.Flush();
        }
    }
}

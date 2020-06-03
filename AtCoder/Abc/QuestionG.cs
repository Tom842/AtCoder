﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionG
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

            var num_Sumlist = new List<long>();

            for (int inumA = 1; inumA <= num_N; inumA++)
            {
                if (inumA % 3 != 0 & inumA % 5 != 0)
                {
                    num_Sumlist.Add(inumA);
                }

            }

            var num_Sum = num_Sumlist.Sum();

            Console.WriteLine(num_Sum);

            Console.Out.Flush();
        }
    }
}

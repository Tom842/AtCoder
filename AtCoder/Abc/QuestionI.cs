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
        /// ABC085C - Otoshidama
        /// https://atcoder.jp/contests/abs/tasks/abc085_c
        /// </summary>
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            int[] num_N= Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            
            string result = Sum_check(num_N[0], num_N[1]);

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        public static string Sum_check(int N, int Y)
        {
            string str_N = "False";    //答えが一致したときに結果を格納する文字列

            //　Y = 10000 * inumA + 5000 * inumB + 1000 * (N - inumA - inumB)
            //　1000円札の枚数　=　N - inumA - inumB　
            //　10000円と5000円の枚数が決まれば、1000円札の枚数は決まる
            //
            for (int inumA = 0; inumA <= N; inumA++)
            {
                for (int inumB = 0; inumB <= N - inumA; inumB++)
                {
                    if (Y == 10000 * inumA + 5000 * inumB + 1000 * (N - inumA - inumB))
                    {
                        str_N = inumA.ToString() + " " + inumB.ToString() + " " + (N - inumA - inumB).ToString();
                    }
                }
            }

            if (str_N == "False") str_N = "-1 -1 -1";

            return str_N;
        }
    }



}

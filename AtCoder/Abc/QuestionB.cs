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
        /// B - Easy Linear Programming
        /// https://atcoder.jp/contests/abc167/tasks/abc167_b
        /// </summary>
        /// <param name="args"></param>

        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列配列の入力
            int[] str_ABCK = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            //マイナスカードの枚数
            int num_Minus = str_ABCK[3] - (str_ABCK[0] + str_ABCK[1]);

            int result = 0;

            if (str_ABCK[3] <= str_ABCK[0])   //引く枚数がＡより少ないときは引く枚数が答え
            {
                result = str_ABCK[3];
            }
            else if (str_ABCK[3] <= str_ABCK[0] + str_ABCK[1]) 
            {
                result = str_ABCK[0];
            }
            else result = str_ABCK[0] - num_Minus;


            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}

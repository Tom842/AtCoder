using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abc141/tasks/abc141_a
    public class QuestionA 
    {
        /// <summary>
        /// PracticeA - Welcome to AtCoder
        /// https://atcoder.jp/contests/abs/tasks/practice_1
        /// </summary>


        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            int num_a = int.Parse(Console.ReadLine());

            // 整数配列の入力
            var num_bc = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            // 文字列の入力
            string str_s = Console.ReadLine();

            int num_Answer = num_a + num_bc[0] + num_bc[1];

            string str_Answer = num_Answer.ToString() + " " + str_s;

            Console.WriteLine(str_Answer );

            Console.Out.Flush();
        }
    }
}

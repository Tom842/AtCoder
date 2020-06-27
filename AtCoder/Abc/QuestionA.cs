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
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            long a = long.Parse(Console.ReadLine());

            var result = (long)(a + Math.Pow(a, 2) + Math.Pow(a, 3));

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}

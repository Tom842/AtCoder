using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionC
    {
        //https://atcoder.jp/contests/abc169/tasks/abc169_c
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var num_AB = Console.ReadLine().Split(' ');

            num_AB[1] = num_AB[1].Replace(".", "");

            var A = ulong.Parse(num_AB[0]);
            var B = ulong.Parse(num_AB[1]);

            var num_P = (A * B) / 100;

            Console.WriteLine(num_P);

            Console.Out.Flush();
        }
    }
}

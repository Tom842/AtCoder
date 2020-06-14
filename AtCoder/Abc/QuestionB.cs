using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionB
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var num_A = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            var num_B = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();


            // 整数の入力
            long T = long.Parse(Console.ReadLine());

            //二点間の距離
            var D = Math.Abs(num_A[0] - num_B[0]);

            //縮まる距離
            var H = (num_A[1] - num_B[1]) * T;

            if (H >= D) Console.WriteLine("Yes");
            else Console.WriteLine("NO");

            Console.Out.Flush();
        }
    }
}

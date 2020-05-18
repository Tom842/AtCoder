using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    
    public class QuestionA
    {
        /// <summary>
        /// https://atcoder.jp/contests/abc168/submissions/me
        /// </summary>
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            int num_N = int.Parse(Console.ReadLine());

            switch (num_N % 10)     //整数の1桁目を求めるには10の余剰を求める
            {
                case 2:
                case 4:
                case 5:
                case 7:
                case 9:
                    Console.WriteLine("hon");
                    break;

                case 0:
                case 1:
                case 6:
                case 8:
                    Console.WriteLine("pon");
                    break;

                case 3:
                    Console.WriteLine("bon");
                    break;

                default:
                break;
            }

            Console.Out.Flush();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionB
    {
        //https://atcoder.jp/contests/abc169/tasks/abc169_b
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            long n = long.Parse(Console.ReadLine());

            // 整数配列の入力
            var num_AN = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            
            long result = 1;

            var limit = (long)Math.Pow(10, 18);

            foreach(long c in num_AN)
            {
                if (c == 0) //0の場合は計算終了
                {
                    result = 0;
                    break;
                }

                if (c <= limit / result)
                {
                    result *= c;
                }
                else
                {
                    result = -1;
                }

            }

            Console.WriteLine(result);
            

            Console.Out.Flush();
        }
    }
}

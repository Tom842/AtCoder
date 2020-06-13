using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionM
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var num_NK = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            int result = 0;
            var num_M = num_NK[0];

            do
            {
                num_M = num_M / num_NK[1];

                result++;

            } while (num_M != 0);


            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
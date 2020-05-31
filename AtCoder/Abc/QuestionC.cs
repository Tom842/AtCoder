using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionC
    {

        /// <summary>
        /// ABC 166
        /// B - Trick or Treat
        /// https://atcoder.jp/contests/abc166/tasks/abc166_b
        /// </summary>
        
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var num_NK = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            //人数分の配列を用意
            var A = new int[num_NK[0]];

            //お菓子の種類分入力
            for (int inumA = 0; inumA < num_NK[1]; inumA++)
            {
                var J = int.Parse(Console.ReadLine());  //持っている人数

                var AI = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();　//持っているすぬけ君[i]

                for(int inumB = 0; inumB < J; inumB++)
                {
                    var N = AI[inumB]-1;

                    A[N]++;
                }
            }

            int result = 0;

            foreach(int C in A)
            {
                if (C == 0) result++;
            }

            Console.WriteLine(result);


            Console.Out.Flush();
        }
    }
}

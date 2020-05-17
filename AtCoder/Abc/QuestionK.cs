using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionK
    {
        /// <summary>
        /// ABC086C - Traveling
        /// https://atcoder.jp/contests/abs/tasks/arc089_a
        /// </summary>
        
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            int num_N = int.Parse(Console.ReadLine());

            int[] num_X = new int[num_N + 1];
            int[] num_Y = new int[num_N + 1];
            int[] num_T = new int[num_N + 1];

            num_X[0] = num_Y[0] = num_T[0] = 0; //初期座標

            for (int inumA = 1; inumA <= num_N; inumA++)
            {
                // 整数配列の入力
                int[] num_txy = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

                num_T[inumA] = num_txy[0]; //t:時間

                num_X[inumA] = num_txy[1]; //x座標
                num_Y[inumA] = num_txy[2]; //y座標
            }

            bool flag = true;

            for(int inumA = 0; inumA < num_N; inumA++)
            {
                int num_TT = num_T[inumA + 1] - num_T[inumA]; //タイム：移動できる距離

                int num_Distance = Math.Abs(num_X[inumA + 1] - num_X[inumA]) + Math.Abs(num_Y[inumA + 1] - num_Y[inumA]); //移動する距離

                if (num_TT < num_Distance)　//移動できる距離 < 移動する距離 のときは False
                {
                    flag = false;
                    break;
                }

                if((num_TT-num_Distance) % 2 != 0)　
                {
                    flag = false;
                    break;
                }
            }

            if (flag) Console.WriteLine("Yes");
            else Console.WriteLine("No");

            Console.Out.Flush();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionH
    {
        /// <summary>
        /// ABC085B - Kagami Mochi
        /// https://atcoder.jp/contests/abs/tasks/abc085_b
        /// </summary>
        public static void Main(string[] args)
        {
            
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            int num_N = int.Parse(Console.ReadLine());

            //餅の直径を入力
            int[] num_D = new int[num_N];

            for (int inumA = 0; inumA < num_N; inumA++)
            {
                num_D[inumA] = int.Parse (Console.ReadLine());
            }

            //入力された直径から重複削除して、昇順にならべかえる
            var num_List = new List<int>(num_D).Distinct().OrderBy(x => x).ToArray();

            int num_Count = num_List.Length;

            Console.WriteLine(num_Count);

            Console.Out.Flush();
        }
    }
}

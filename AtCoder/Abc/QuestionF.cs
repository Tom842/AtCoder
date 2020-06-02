using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionF
    {
        /// <summary>
        /// B - Homework
        /// https://atcoder.jp/contests/abc163/tasks/abc163_b
        /// </summary>
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var num_NM = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();  //num_NM[0]：N 日数　num_NM[1]：M 宿題数

            // 整数配列の入力
            var num_A = Console.ReadLine().Split(' ').Select(i => int.Parse(i)); //.ToArray();  //各宿題にかかる日数

            int num_Sumday = num_A.Sum();　//LINQ Sum関数で宿題にかかる合計日数をもとめる

            int num_Remain = num_NM[0] - num_Sumday;  //残り日数を求める

            if (num_Remain >=0)
            {
                Console.WriteLine(num_Remain);
            }
            else if (num_Remain < 0)
            {
                Console.WriteLine("-1");
            }

            Console.Out.Flush();
        }
    }
}

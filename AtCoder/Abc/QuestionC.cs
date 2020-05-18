using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionC
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var num_N = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            //num_N[0]  時針の長さ
            //num_N[1]  分針の長さ
            //num_N[2]  時間
            //num_N[3]  分

            //時針の角度
            //[rad] = 度 * π/180
            //30°*　時間　＝分針が0のときの時針の位置

            var num_H = (30 * num_N[2] + 0.5 * num_N[3]) * Math.PI / 180;

            //分針の角度
            var num_M = (6 * num_N[3]) * Math.PI / 180;

            var num_HM = num_H - num_M;

            //時針と分針の角度差が180°(π[rad])より大きい場合の処理
            if (num_HM > Math.PI) num_HM = (2 * Math.PI) - num_HM;

            //余弦の定理
            var num_AA = Math.Sqrt(Math.Pow(num_N[0], 2) + Math.Pow(num_N[1], 2) - 2 * num_N[0] * num_N[1] * Math.Cos(num_HM));

            Console.WriteLine(num_AA);

            Console.Out.Flush();
        }
    }
}

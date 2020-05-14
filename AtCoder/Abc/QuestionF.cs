using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionF
    {
        /// <summary>
        /// ABC083B - Some Sums / 
        /// https://atcoder.jp/contests/abs/tasks/abc083_b
        /// </summary>
        
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            int[] num_nab = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            int num_Counter = 0; //総和　格納用

            for (int inumA=1;inumA<=num_nab[0]; inumA++)
            {
                char[] char_N = inumA.ToString().ToCharArray();　//整数を桁ごとにばらす

                int num_Sum = 0; //各桁　合計格納用
                
                foreach (char i in char_N)
                {
                    int num_N = int.Parse(i.ToString ());
                    
                    num_Sum += num_N;  //各桁の合計
                }

                if (num_Sum >= num_nab[1] & num_Sum <= num_nab[2])
                {
                    num_Counter +=inumA;　//総和
                }

            }

            Console.WriteLine(num_Counter);

            Console.Out.Flush();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionD
    {
        /// <summary>
        /// ABC081B - Shift only
        /// https://atcoder.jp/contests/abs/tasks/abc081_b
        /// </summary>
        
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 入力する数字の数
            int num_n = int.Parse(Console.ReadLine());

            // 整数配列の入力
            int[] num_A= Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            int num_Answer = 0;
            foreach (int AA in num_A)
            {
                if (AA == 0 | AA % 2 != 0)
                {
                    num_Answer = 0;
                    break;
                }

                string str_A = Convert.ToString(AA, 2); //2進数に変換

                int num_Len = str_A.Length;
                int num_Bit = str_A.LastIndexOf("1");

                int num_Temp = num_Len - num_Bit - 1;
                                
                if(num_Temp <= num_Answer)
                {
                    num_Answer = num_Temp;
                }
                else if (num_Answer == 0)
                {
                    num_Answer = num_Temp;
                }
            }

            Console.WriteLine(num_Answer);

            Console.Out.Flush();
        }
    }
}

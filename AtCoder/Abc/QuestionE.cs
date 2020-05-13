using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionE
    {

        /// <summary>
        /// ABC087B - Coins
        /// https://atcoder.jp/contests/abs/tasks/abc087_b
        /// </summary>
     
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            int num_A = int.Parse(Console.ReadLine()); //A
            int num_B = int.Parse(Console.ReadLine()); //B 100Yen
            int num_C = int.Parse(Console.ReadLine()); //C 50Yen

            int num_X = int.Parse(Console.ReadLine()); //X Sum

            int num_Return = 0;

            if(num_X <= 50)
            {
                num_Return = Sum_check(0, 0, num_C, num_X);
            } 
            else if(num_X <= 100)
            {
                num_Return = Sum_check(0, num_B, num_C, num_X);
            }
            else
            {
                num_Return = Sum_check(num_A, num_B, num_C, num_X);
            }

            Console.WriteLine(num_Return);

            Console.Out.Flush();
        }

        public static int Sum_check(int A, int B, int C, int X)
        {
            int num_Counter = 0;    //答えが一致した数
            int num_Sum = 0;        //答え格納用

            for (int inumA = 0; inumA <= A; inumA++)
            {
                for (int inumB = 0; inumB <= B; inumB++)
                {
                    for (int inumC = 0; inumC <= C; inumC++)
                    {
                        num_Sum = 500 * inumA + 100 * inumB + 50 * inumC;

                        if (num_Sum == X)
                        {
                            num_Counter++;
                        }
                    }
                }

            }

            return num_Counter;
        }
    }


   
}

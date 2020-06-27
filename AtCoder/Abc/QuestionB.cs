using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionB
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            string S = Console.ReadLine();

            string T = Console.ReadLine();

            var Len = S.Length;
            var Count = 0;
            
            for(int inumA = 0; inumA < Len; inumA++)
            {
                var ST = S.Substring(inumA, 1);
                var TT = T.Substring(inumA, 1);

                if (ST != TT)
                {
                    Count++;
                }


            }

            Console.WriteLine(Count);

            Console.Out.Flush();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AtCoder.Abc
{
    class QuestionJ
    {
        /// <summary>
        /// ABC049C - 白昼夢
        /// https://atcoder.jp/contests/abs/tasks/arc065_a
        /// </summary>
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            string str_S = Console.ReadLine();

            //string[] str_TT = new string[4] { "dream$", "dreamer$", "erase$", "eraser$" };

            //string str_Match = "dream$ | dreamer$ | erase$ | eraser$";
            string str_Match = "^(dream|dreamer|erase|eraser)+$";

            /*
            do
            {
                for(int inumA = 0; inumA < str_TT.Length; inumA++)
                {
                    str_S = Regex.Replace(str_S, str_TT[inumA], string.Empty);
                }

            } while (Regex.IsMatch(str_S, str_Match));
            */

            string str_result = "";

            if (Regex.IsMatch(str_S, str_Match))
            {
                str_result = "YES";
            }
            else
            {
                str_result = "NO";
            }

            Console.WriteLine(str_result);

            Console.Out.Flush();
        }
    }
}

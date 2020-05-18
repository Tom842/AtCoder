using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionB
    {
        /// <summary>
        /// https://atcoder.jp/contests/abc168/tasks/abc168_b
        /// </summary>
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            int num_K = int.Parse(Console.ReadLine());

            // 文字列の入力
            string str_S = Console.ReadLine();
            
            int num_Length = str_S.Length;

            if (num_Length <= num_K)
            {
                Console.WriteLine(str_S);
            }
            else if(num_Length > num_K)
            {
                string str_SS = str_S.Substring(0, num_K) + "...";
                Console.WriteLine(str_SS);
                
            }
            
            Console.Out.Flush();

        }
    }
}

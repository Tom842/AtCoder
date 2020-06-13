using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    /// <summary>
    /// B - Papers, Please
    /// https://atcoder.jp/contests/abc155/tasks/abc155_b
    /// </summary>
    class QuestionN
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            int num_N = int.Parse(Console.ReadLine());

            // 整数配列の入力
            var num_A = Console.ReadLine().Split(' ').Select(i => int.Parse(i));  //.ToArray();

            string result = "APPROVED";

            var num_Even = num_A.Where(k => k % 2 == 0);
            var num_Count = num_Even.ToArray().Length;

            if(num_Count==0) result= "DENIED";

            foreach (var AA in num_Even)
            {
                if(AA % 3 !=0 && AA % 5 != 0)
                {
                    result = "DENIED";            
                }
            }

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
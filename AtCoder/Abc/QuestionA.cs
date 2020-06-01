using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abc169/tasks/abc169_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var num_AB = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            
           int result = num_AB[0]*num_AB[1];

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}

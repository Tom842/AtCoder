using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionO
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            long n = long.Parse(Console.ReadLine());

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            string result = "";

            if (inputLongArray[0] % n == 0) result = "OK";
            else
            {
                var numA = inputLongArray[0] / n;
                var numB = numA * n + n;

                if (numB <= inputLongArray[1]) result = "OK";
                else result = "NG";

            }
            
            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
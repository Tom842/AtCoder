using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionL
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

           bool[] Append = new bool[9];  //初期値はfalse

            // 整数配列の入力
            int[] A1 = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            int[] A2 = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            int[] A3 = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            List<int> BC = new List<int>();

            BC.AddRange(A1);
            BC.AddRange(A2);
            BC.AddRange(A3);

            var N = int.Parse(Console.ReadLine());

            for(int inumC = 0; inumC < N; inumC++)
            {
                var b =int.Parse(Console.ReadLine());

                for (int inumA = 0; inumA < 9; inumA++)
                {
                   if(BC[inumA] == b)
                   {
                        Append[inumA] = true;
                   }
                }
            }

            string result = "No"; 

            for(int inumD = 0; inumD < 7; inumD +=3)
            {
                if(Append[inumD]==true && Append[inumD + 1] == true && Append[inumD + 2] == true) result = "Yes";
            }

            for (int inumD = 0; inumD < 3; inumD++)
            {
                if (Append[inumD] == true & Append[inumD + 3] == true & Append[inumD + 6] == true) result = "Yes";
            }

            if (Append[0] == true && Append[4] == true && Append[8] == true) result = "Yes";
            if (Append[2] == true && Append[4] == true && Append[6] == true) result = "Yes";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}

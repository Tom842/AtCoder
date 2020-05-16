using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionG
    {
        /// <summary>
        /// ABC088B - Card Game for Two / 
        /// https://atcoder.jp/contests/abs/tasks/abc088_b
        /// </summary>
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            int num_N = int.Parse(Console.ReadLine());

            // 整数配列の入力
            
            int[] num_A  = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            //配列を降順で並べ替えかえて、再代入
            var num_List = new List<int>(num_A).OrderBy(x => -x).ToArray (); 
            
            int num_Sum = 0;

            for (int inumA = 0; inumA < num_List.Length ; inumA++)
            {
                if (inumA == 0)         //初回はAlice num_List[0]
                {
                    num_Sum += num_List[inumA];
                }
                else if (inumA % 2 != 0)    //要素番号 奇数はBob 
                {
                    num_Sum -= num_List[inumA];
                }
                else if (inumA % 2 == 0)    //要素番号 偶数はAlice
                {
                    num_Sum += num_List[inumA];
                }
            }

            /*
            //配列をバブルソートで降順にする。
            //バブルソート
            for (int inumA = 0; inumA <= (num_A.Length - 1); inumA++)
            {
                for (int inumB = (num_A.Length - 1); inumB > inumA; inumB--)
                {
                    if (num_A[(inumB - 1)] < num_A[inumB])
                    {
                        int numTemp = num_A[inumB - 1];
                        num_A[inumB - 1] = num_A[inumB];
                        num_A[inumB] = numTemp;
                    }
                }
            }
            

            int num_Sum = 0;
            
            for(int inumA = 0; inumA < num_A.Length; inumA++)
            {
                if(inumA == 0)
                {
                    num_Sum += num_A[inumA];
                }
                else if(inumA % 2 != 0)
                {
                    num_Sum -= num_A[inumA];
                }
                else if(inumA % 2 == 0)
                {
                    num_Sum += num_A[inumA];
                }
            }
           
            */



            Console.WriteLine(num_Sum);

            Console.Out.Flush();
        }
    }
}

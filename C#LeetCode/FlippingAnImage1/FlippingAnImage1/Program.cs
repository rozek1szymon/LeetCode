using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlippingAnImage
{

    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            int[][] B = new int[A.Length][];

            for (int i = 0; i < A.Length; i++)
            {
                B[i] = new int[A.Length];

                for (int j = A.Length - 1, iterator = 0; j >= 0; j--, iterator++)
                {




                   
                    B[i][iterator] = A[i][j];
                    if (B[i][iterator] == 0)
                        B[i][iterator] = 1;
                    else
                        B[i][iterator] = 0;

                    
                }

            }
           
           
            return B;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Solution solution = new Solution();
            int[][] table = new int[][]
 {
    new int[] { 1,1,0,0 },
    new int[] { 1,0,0,1 },
    new int[] { 0, 1, 1, 1 },
    new int[] { 1, 0, 1, 0 }

 };

            solution.FlipAndInvertImage(table);

            Console.ReadKey();


        }
    }
}

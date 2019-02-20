using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfEvenNumbersAfterQueries
{

    public class Solution
    {
        public int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {

            int[] value = new int[queries.Length];
            int sum = 0;
            for (int i = 0; i < queries.Length; i++)
            {
              
                
                A[queries[i][1]] += queries[i][0];

                for (int j = 0; j < queries.Length; j++)
                {
                    if(A[j]%2==0)
                    sum += A[j];
                }

                value[i] = sum;
                sum = 0;

            }

            
            return value;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Solution solution = new Solution();
            int[] A = { 1, 2, 3, 4 };
            int[][] queries = new int[][]
            {
                new int[]  {1,0},
                new int[] {-3,1},
                new int[] {-4,0},
                new int[] {2,3},


            };
            solution.SumEvenAfterQueries(A, queries);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}

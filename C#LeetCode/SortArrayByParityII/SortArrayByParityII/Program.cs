using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayByParityII
{




    public class Solution
    {
        public int[] SortArrayByParityII(int[] A)
        {
            
            int iteratorOdd=1;
            int iteratorEven = 0;
           

            for (int i = 0; i < A.Length; i++)
            {
                if(A[i]%2==0)
                {
                    A[iteratorEven] = A[i];
                    iteratorEven += 2;
                }
                else
                {
                    A[iteratorOdd] = A[i];
                    iteratorOdd += 2;
                }
            }
            

            return A;

        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] array = { 4, 2, 5, 7 };
            solution.SortArrayByParityII(array);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}

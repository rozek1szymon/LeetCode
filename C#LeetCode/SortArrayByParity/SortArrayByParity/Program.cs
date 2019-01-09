using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayByParity
{
    public class Solution
    {
        public int[] SortArrayByParity(int[] A)
        {
            int[] result = new int[A.Length]; 
            int iStart = 0 , iEnd = A.Length - 1; // we are creating iterators which are at the and and athe the beggining
            for (int i = 0; i < A.Length; i++) // check for all numbers of A array
            {
                if(A[i]%2==0)
                    result[iStart++] = A[i]; // if even ad to the beginning
                else
                    result[iEnd--] = A[i]; // if odd at to the end

            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution Super = new Solution();
            int[] table  = { 3, 1 , 2, 4 };
            Super.SortArrayByParity(table);
        }
    }
}

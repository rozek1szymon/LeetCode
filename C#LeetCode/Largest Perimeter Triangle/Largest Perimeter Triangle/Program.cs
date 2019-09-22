using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Perimeter_Triangle
{

    public class Solution
    {
        public int LargestPerimeter(int[] A)
        {
            Array.Sort(A);
            Array.Reverse(A);
            for (int i = 0; i < A.Length-2; i++)
            {
                if (0 > A[i] - A[i + 1] - A[i + 2])
                    return A[i] + A[i + 1] + A[i + 2];
            }

            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {2,2,1 };
            Solution solution = new Solution();
            Console.WriteLine(solution.LargestPerimeter(array));

            Console.ReadKey();
        }
    }
}

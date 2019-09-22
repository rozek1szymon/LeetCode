using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fair_Candy_Swap
{
    public class Solution
    {
        public int[] FairCandySwap(int[] A, int[] B)
        {
            var k = (A.Sum() - B.Sum()) / 2;

            var h = new HashSet<int>(A);

            foreach (var b in B)
                if (h.Contains(k + b)) return new[] { k + b, b };

            throw new Exception();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] aliceCandies = {32,38,8,1,9};
            int[] bodCandies = { 68,92};
            Solution solution = new Solution();

            solution.FairCandySwap(aliceCandies, bodCandies);

            Console.ReadKey();
        }
    }
}

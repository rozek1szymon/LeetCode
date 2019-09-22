using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Zeroes
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
           
            nums = nums.ToList().OrderBy(x => x).Reverse().ToArray();
           
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            Solution solution = new Solution();
            solution.MoveZeroes(nums);
        }
    }
}

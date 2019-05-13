using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_K_Frequent_Elements
{

    public class Solution
    {
        public IList<int> TopKFrequent(int[] nums, int k)
        {
            //var nums= nums.OrderBy(x=>x).ToArray();
            Dictionary<int, int> dictOfValues = new Dictionary<int, int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                if(dictOfValues.Keys.Contains(nums[i]))
                {
                    dictOfValues[nums[i]]++;
                }
                else
                {
                    dictOfValues.Add(nums[i], 1);
                }
            }
          
            return dictOfValues.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToList();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            int k = 2;
            int[] nums =  { 1, 5,6,5 ,5,1, 2, 2, 2 };
            Console.WriteLine(solution.TopKFrequent(nums, k)); 
            Console.ReadKey();

        }
    }
}

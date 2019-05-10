using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container_With_Most_Water
{

    public class Solution
    {
        public int MaxArea(int[] height)
        {
            var whichElement=0;
            var finalCapacity = 0;
            var capacity = 0;
            var whichLoop = 1;
            for (int i = whichLoop; i < height.Length; i++)
            {                             
                if(height[whichElement]<height[i])
                {
                    capacity = height[whichElement] * (i-whichElement);
                }
                else
                {
                    capacity = height[i] * (i - whichElement);
                }
                //whichElement++;
                if (capacity > finalCapacity)
                    finalCapacity = capacity;
                if (height.Length-1 == i)
                {
                    i = whichLoop++;
                    whichElement++;
                }
            }
                            
            return finalCapacity;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var solution = new Solution();
            solution.MaxArea(height);
            Console.ReadKey();
        }
    }
}

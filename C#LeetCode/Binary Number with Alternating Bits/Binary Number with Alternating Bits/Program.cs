using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Number_with_Alternating_Bits
{
    public class Solution
    {
        public bool HasAlternatingBits(int n)
        {

            string binaryRepresentation = Convert.ToString(n, 2);
          
            for (int i = 0; i < binaryRepresentation.Length-1; i++)
            {
                if (binaryRepresentation[i] == binaryRepresentation[i + 1])
                    return false;
            }

            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            solution.HasAlternatingBits(5);

            Console.ReadKey();
        }
    }
}

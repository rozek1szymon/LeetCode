using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Gap
{

    public class Solution
    {
        public int BinaryGap(int N)
        {
            if (N == 0 || N == 1)
                return 0;
            else
            {
                string binaryNumber = Convert.ToString(N, 2);
                int howMuch = 1;
                int theBiggest = 0;              
                for (int i = 1; i < binaryNumber.Length; i++)
                {
                    if (binaryNumber[i] == '0')
                    {
                        howMuch++;
                    }
                    else if (binaryNumber[i] == '1')
                    {
                        if (howMuch > theBiggest)
                            theBiggest = howMuch;
                        howMuch = 1;
                    }

                }
                Console.WriteLine(theBiggest);
                return theBiggest;
               
            }
           
          
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.BinaryGap(22);
            Console.ReadKey();
        }
    }
}

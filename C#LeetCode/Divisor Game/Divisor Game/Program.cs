using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisor_Game
{

    public class Solution
    {
        public bool DivisorGame(int N)
        {
            bool isAlice = false;
            while (N > 1)
            {
                for (int i = 1; i <= N; i++)
                {
                    if (N % i == 0)
                    {
                        Console.WriteLine(N);
                        isAlice = !isAlice;
                        N -= i;
                        break;
                    }
                }
            }
            Console.ReadKey();
            return isAlice;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.DivisorGame(8);
        }
    }
}

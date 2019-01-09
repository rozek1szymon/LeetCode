using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIStringMatch
{

    public class Solution
    {
        public int[] DiStringMatch(string S)
        {
            int[] A = new int[S.Length+1];
            int up = S.Length;
            int down = 0;

            for (int i = 0; i <= S.Length-1; i++)
            {
                if (S[i]=='I')
                {
                    A[i] = down;
                    down++;
                    
                }
                else
                {
                    A[i] = up;
                    up--;
                   
                }

                
            }
            A[S.Length] = up;
            
            return A;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Solution solution = new Solution();
            solution.DiStringMatch("IDID");
            
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}

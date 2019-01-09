using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumAddToMakeParenthesesValid
{
    public class Solution
    {
        public int MinAddToMakeValid(string S)
        {
            var iterator1 = 0;
            var iterator2 = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i]=='(')
                {
                    iterator1++;
                }
                else if(S[i]==')'&& iterator1==0)
                {
                    iterator2++;
                }
                else if(S[i]==')' && iterator1>0)
                {
                    iterator1--;
                }



            }

            
            return iterator1 + iterator2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.MinAddToMakeValid("()))((");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}

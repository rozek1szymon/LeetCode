using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_Case_Permutation
{

    public class Solution
    {
        public IList<string> LetterCasePermutation(string S)
        {
            List<string> listOfPermutations = new List<string>();
            listOfPermutations.Add(S);

            for (int i = 0; i < length; i++)
            {

            }


            return listOfPermutations;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string S = "a1b2";
            Solution solution = new Solution();

            solution.LetterCasePermutation(S);
        }
    }
}

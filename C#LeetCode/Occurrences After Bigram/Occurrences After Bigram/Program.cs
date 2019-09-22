using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Occurrences_After_Bigram
{
    public class Solution
    {
        public string[] FindOcurrences(string text, string first, string second)
        {
            IList<string> results = new List<string>(); ;

           var arrayOfStrings = text.Split(' ').ToArray();
            for (int i = 0; i < arrayOfStrings.Length-2; i++)
            {
                if(arrayOfStrings[i]==first && arrayOfStrings[i+1]==second)
                {
                    results.Add(arrayOfStrings[i + 2]);
                }

            }


            return results.ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = "we will we will rock you";
            string first = "we";
            string second = "will";
            Solution solution = new Solution();
            solution.FindOcurrences(text,first,second);
        }
    }
}

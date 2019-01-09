using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;

namespace FindAndReplacePattern
{


    public class Solution
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {

            List<string> list = new List<string>();


            
           

            return list;
            

        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            Solution solution = new Solution();
            string[] words = { "abc", "deq", "mee", "aqq", "dkd", "ccc" };
            string pattern = "abb";

            solution.FindAndReplacePattern(words, pattern);
           
           
            Console.ReadKey();

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buddy_String
{


    public class Solution
    {
        public bool BuddyStrings(string A, string B)
        {
            if(A.Length==B.Length)
            {
                var result = A.Zip(B, (a, b) => (a == b) ? a : '0' )
                    .Zip(
                    {
                   
                }
                  );

                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
               

            }
            

            return false;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            string a = "abc";
            string b = "bac";
            Solution solution = new Solution();
            solution.BuddyStrings(a, b);
            Console.ReadKey();
        }

    }
   
}

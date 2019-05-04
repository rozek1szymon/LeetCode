using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            s = s.Reverse().ToArray<char>();
 
           
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            char[] array = { 'h', 'e', 'l', 'l', 'o' };

            Solution solution = new Solution();
            solution.ReverseString(array);
            Console.ReadKey();
        }
    }
}

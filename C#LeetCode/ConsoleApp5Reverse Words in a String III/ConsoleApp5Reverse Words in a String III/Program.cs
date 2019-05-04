using System;
using System.Linq;
namespace ConsoleApp5Reverse_Words_in_a_String_III
{

    public class Solution
    {
        public string ReverseWords(string s)
        {
            
            return string.Join(" ", s.Split().Select(ss => new string(ss.Reverse().ToArray())));

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string Input = "Let's take LeetCode contest";

            Solution solution = new Solution();
            solution.ReverseWords(Input);

            Console.ReadKey();
        }
    }
}

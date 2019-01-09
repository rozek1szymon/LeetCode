using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueMorseCodeWords
{
    public class Solution
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            // Directory is a data structure which contain key-value
            Dictionary <char,string> mors = new Dictionary<char, string>()
            {
                 {'a',".-"},
                {'b',"-..."},
                {'c',"-.-."},
                {'d',"-.."},
                {'e',"."},
                {'f',"..-."},
                {'g',"--."},
                {'h',"...."},
                {'i',".."},
                {'j',".---"},
                {'k',"-.-"},
                {'l',".-.."},
                {'m',"--"},
                {'n',"-."},
                {'o',"---"},
                {'p',".--."},
                {'q',"--.-"},
                {'r',".-."},
                {'s',"..."},
                {'t',"-"},
                {'u',"..-"},
                {'v',"...-"},
                {'w',".--"},
                {'x',"-..-"},
                {'y',"-.--"},
                {'z',"--.."},
            };
            List<string> morses = new List<string>();
           
            foreach (string word in words) //for every word in a table words
            {
                string morse = "";        // we are creating new blank string
                foreach (char item in word) // for every char in a word form table words
                {
                    morse += mors[item];  // we are creating morse words by adding the value of every letter 
                }
                if(!morses.Contains(morse)) //check if element exist in a list 
                {
                    morses.Add(morse);  // adds an element at the end of a list 
                }
            }

            return  morses.Count;
        }
        }

    class Program
    {

        static void Main(string[] args)
        {
            Solution morse = new Solution();
            string [] words = { "gin", "zen", "gig", "msg" };
            Dictionary<string, int> testing = new Dictionary<string, int>()
            {
                {"jeden", 1 },
                {"dwa", 2 },
            };
            
            Console.WriteLine(testing["dwa"]); //we will get 2

            morse.UniqueMorseRepresentations(words);
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_Row
{



    public class Solution
    {
        public string[] FindWords(string[] words)
        {

           var words1 = words.ToList().ConvertAll(d => d.ToLower()).ToArray();
            string[] keyboardRows = new[] { "qwertyuiop", "asdfghjkl", "zxcvbnm" };           
            var whichWord = 0;
            var whichCharcater = 0;
            var Row = "";
            var keepInTable = true;
            foreach (var word in words1)
            {
                whichWord++;
                foreach (var character in word)
                {
                   
                    whichCharcater++;
                    if(whichCharcater==1)
                    {
                        foreach (var wordInRow in keyboardRows)
                        {
                            var found = wordInRow.Contains(character);
                            if (found == true)
                            {                               
                                Row = wordInRow;
                                break;
                            }
                              
                        }
                    }
                    else
                    {
                        var found = Row.Contains(character);
                        if (found == false)
                        {
                            keepInTable = false;
                            break;
                        }
                           
                    }

                }
                if(keepInTable==false)
                {
                    for (int i = 0; i < words1.Length; i++)
                    {
                        if(words1[i]==word)
                        {
                            words = words.Where(a => a != words[i]).ToArray();
                            words1= words1.Where(a => a != words1[i]).ToArray();
                            break;
                        }
                        
                    }
                }
                keepInTable = true;
                whichCharcater = 0;
            }
            

            return words;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string[] table = new[] { "Hello", "Alaska", "Dad", "Peace" };
            solution.FindWords(table);

            Console.ReadKey();
           
        }
    }
}

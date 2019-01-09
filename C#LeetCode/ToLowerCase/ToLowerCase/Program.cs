using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToLowerCase
{
    public class Solution
    {
        public string Lower(string str)
        {

           string str2 = str.ToLower();
            return str2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution dupa = new Solution();
            dupa.Lower("cipka");
            Console.ReadLine();
        }
       
    }
    
   
}

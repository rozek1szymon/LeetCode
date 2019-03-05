using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Common_Characters
{

    public class Solution
    {
        public IList<string> CommonChars(string[] A)
        {
            Dictionary<string, int> final = new Dictionary<string, int>();
            IList<string> list = new List<string>();
            int[] numbers = new int[A[0].Length];
            
           
           

            foreach (var item in A[0])
            {

                var stringer = item.ToString();
                if (!final.Keys.Contains(stringer))
                {

                    int count = A[0].Where(e => e.Equals(item)).Count();
                    final.Add(stringer, count);

                }
            }

            List<string> keys = new List<string>(final.Keys);
            foreach (var item in keys)
            {
                var charer = char.Parse(item);
 
                for (int i = 0; i < A.Length; i++)
                {
                    var count = A[i].Where(a => a == charer).Count();
                    if(final.Keys.Contains(item) && count ==0)
                    {
                        final.Remove(item);
                    }
                    else if(final.Keys.Contains(item)  && count < final[item])
                    {
                       
                        var value = final[item] - ( final[item] - count);
                        final[item] = value;
                      
                    }
                    
                }
                
            }

           
           

            foreach (var item in final)
            {
               if(item.Value>0)
                {
                    for (int i = 0; i < item.Value; i++)
                    {
                        list.Add(item.Key);
                    }
                    
                }
               
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
           
            return list;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           string[] table = { "bbddabab","cbcddbdd","bbcadcab","dabcacad","cddcacbc","ccbdbcba","cbddaccc","accdcdbb"};
           // string[] table = { "cool", "lock", "cook","lool" };
   
            Solution solution = new Solution();
            solution.CommonChars(table);

            Console.ReadKey();
        }
    }
}

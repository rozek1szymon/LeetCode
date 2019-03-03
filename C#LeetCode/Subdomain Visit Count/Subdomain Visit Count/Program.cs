using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subdomain_Visit_Count
{



    public class Solution
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
           var hashtable = new Hashtable();
            IList<string> lista = new List<string>();
            string number="0";

            var newstring = cpdomains.SelectMany(s =>
            {
                
                return s.Split(' ');    

            }
            ).SelectMany(s =>
            {
                
                string[] splitDomain = s.Split('.');
                if(splitDomain.Length==1)
                {
                    number = splitDomain[0];
                }

                
                return Enumerable.Range(0, splitDomain.Length)
                    .Select(counter =>
                             number + " " + String.Join(".", splitDomain.Skip(counter))).ToArray();
                    
                //return splitDomain
                
            }).ToArray();







            //var result2 = result.Aggregate();

            foreach (var item in newstring)
            {
                Console.WriteLine(item);
            }
            return lista;

        }


            
            

        
    }



    class Program
    {
        static void Main(string[] args)
        {
            string[] list = { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" };


            Solution solution = new Solution();
            solution.SubdomainVisits(list);

            //List<string> strings = new List<string>() { "ABC", "DEF", "GHI" };
            //string s = strings.Aggregate((a, b) => a + ',' + b);
            //Console.WriteLine(s);

            Console.ReadLine();


        }
    }
}

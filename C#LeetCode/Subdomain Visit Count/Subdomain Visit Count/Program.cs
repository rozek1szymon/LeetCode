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
            Dictionary<string, int> hashtable = new Dictionary<string, int>();
            IList<string> lista = new List<string>();
            string number = "0";

            var newstring = cpdomains.SelectMany(s =>
            {

                return s.Split(' ');

            }
            ).SelectMany(s =>
            {

                string[] splitDomain = s.Split('.');
                if (splitDomain.Length == 1)
                {
                    number = splitDomain[0];
                    return Enumerable.Range(0, splitDomain.Length)
                    .Select(counter =>
                             number + " " + String.Join(".", splitDomain.Skip(counter))).Skip(1).ToArray();
                }


                return Enumerable.Range(0, splitDomain.Length)
                   .Select(counter =>
                            number + " " + String.Join(".", splitDomain.Skip(counter))).ToArray();



            });




            foreach (var item in newstring)
            {
                var item2 = item.Split(' ');
                int number2 = Int32.Parse(item2[0]);
                if (hashtable.Keys.Contains(item2[1]))
                {
                  
                    hashtable[item2[1]] += number2;
                }
                else
                {
                    hashtable.Add(item2[1], number2);
                }

            }

                foreach (var item4 in hashtable)
                {
                 lista.Add(item4.Value + " " + item4.Key);
                 
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

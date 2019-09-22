using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz
{

    public class Solution
    {
        public IList<string> FizzBuzz(int n)
        {
            List<int> listOfFizzBuzz = new List<int>();
            List<string> listOfFizzBuzz1 = new List<string>();

            for (int i = 1; i < n+1; i++)
            {
                listOfFizzBuzz.Add(i);
            }

            listOfFizzBuzz1 = listOfFizzBuzz.ConvertAll(x => (x % 3 == 0 && x % 5 == 0) ? -4 : x).ConvertAll(x => x % 3 == 0 ? -1 : x).ConvertAll(x => x % 5 == 0 ? -2 : x).ConvertAll<string>(x => x.ToString());
              
            foreach (var item in listOfFizzBuzz1)
            {
               
                if (item == "-4")
                    listOfFizzBuzz1.Add("FizzBuzz");
               else if(item=="-1")
                    listOfFizzBuzz1.Add("Fizz");
               else if (item == "-3")
                    listOfFizzBuzz1.Add("Buzz");
                else
                   listOfFizzBuzz1.Add(item);



            }

           return listOfFizzBuzz1;
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.FizzBuzz(15);
        }
    }
}

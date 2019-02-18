using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfDividingNumbers
{


    public class Solution
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> list = new List<int>();
            bool flag=true;
            for (int i=left;  i<=right; i++)
            {
                string count = i.ToString();
               
                for (int j = 0; j < count.Length; j++)
                {

                    int actual = int.Parse(count[j].ToString());
                    
                    if (actual == 0 || i % actual != 0)
                    {
                       
                        
                        flag = false;
                    }
                    
                }
                if(flag==true)
                {
                    list.Add(i);
                }
                flag = true;
            }

            
            return list;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int right, left;
            right = 1;
            left = 22;

            Solution solution = new Solution();
            solution.SelfDividingNumbers(right,left);
           // Console.WriteLine();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}

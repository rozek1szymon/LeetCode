using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HammingDistance
{

    public class Solution
    {
        public int HammingDistance(int x, int y)
        {
           if(x<y)
           {
                var pomocniczy = y;
               y = x;
                x = pomocniczy;

            }
            string binary1 = Convert.ToString(x, 2);
            var length1 = binary1.Length;
            string binary2 = Convert.ToString(y, 2).PadLeft(length1, '0');
           
            
            
            var maxv=0;
            // i am using zip linq method to compare 2 lists and its corresponding elements then if one element on a position equals to 1 i ll write 1 to my list ?- means if true :-in other way
            var summed = binary1.Zip(binary2, (b1, b2) => ((b1=='1' && b2=='1') || (b1=='0' && b2=='0')) ? '1' : '0').ToList();

            foreach (var item in summed)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(summed.Count(c=>c=='1'));



            return maxv;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            solution.HammingDistance(4, 10);
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}

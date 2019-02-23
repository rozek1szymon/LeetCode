using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
    class Program
    {
        public class Solution
        {
            public int Fib(int N)
            {
                if(N==0)
                {
                    return 0;
                }
                else if(N==1)
                {
                    return 1;
                }
                else if(N==2)
                {
                    return 1;
                }
                else
                {
                  return Fib(N-1) + Fib(N - 2);
                }

                
            }
        }


        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.Fib(3));
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}

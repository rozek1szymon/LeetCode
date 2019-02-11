using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPathsFromSourceToTarget
{


    public class Solution
    {
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            IList<IList<int>> lista = new List<IList<int>>();



            return lista;

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");

            Solution solution = new Solution();
            int[][] array = new int[][]
 {
    new int[] { 1,2},
    new int[] { 3 },
    new int[] { 3 }
};
            solution.AllPathsSourceTarget(array);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}

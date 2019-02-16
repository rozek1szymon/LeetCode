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
            //initial data
            IList<IList<int>> rtnList = new List<IList<int>>();
            int length = graph.GetLength(0);
            IList<int> tStack = new List<int>();
            IList<IList<int>> road = new List<IList<int>>();
            //deep search use while
            foreach (var item in graph[0])
            {
                tStack.Add(item);
                road.Add(new List<int>() { 0, item });
            }



            return rtnList;

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
    new int[] { 3},
    new int[] { 3},
    new int[] {  },

};
            solution.AllPathsSourceTarget(array);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}

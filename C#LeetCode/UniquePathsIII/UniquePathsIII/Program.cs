using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniquePathsIII
{


    public class Solution
    {
        public int UniquePathsIII(int[][] grid)
        {
            List<int> road = new List<int>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if(grid[i][j]==1)
                    {
                        road.Add(grid[i][j]);
                        
                    }
                    if (grid[i][j + 1] == 0 )
                    {
                        road.Add(grid[i][j + 1]);
                        grid[i][j + 1] = -2;

                    }
                    else if (grid[i][j - 1] == 0)
                    {
                        road.Add(grid[i][j - 1]);
                        grid[i][j - 1] = -2;
                    }
                    else if (grid[i + 1][j] == 0)
                    {
                        road.Add(grid[i + 1][j]);
                        grid[i + 1][j] = -2;
                    }
                    else if (grid[i-1][j] == 0)
                    {
                        road.Add(grid[i - 1][j]);
                        grid[i - 1][j] = -2;
                    }
                }
            }

            return 5;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[][] A = new int[][]
            {
               new int[]{1,0,0,0},
               new int[]{0,0,0,0},
               new int[]{0,0,2,-1}
            };

            solution.UniquePathsIII(A);

            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}

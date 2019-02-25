using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KClosestPointsToOrigin
{

    public class Solution
    {
        struct point
        {
           public int x;
           public int y;
        }
        public int[][] KClosest(int[][] points, int K)
        {
            point punkt = new point();
            int[][] array = new int[][]
            {


            };
            Dictionary<point, double> dictionary = new Dictionary<point, double>();
            double []distance= new double[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                punkt.x = points[i][0];
                punkt.y = points[i][1];
                distance[i] = Math.Sqrt(points[i][0] * points[i][0] + points[i][1] * points[i][1]);
                //Console.WriteLine(Math.Sqrt(points[i][0] * points[i][0] + points[i][1] * points[i][1]));
                dictionary[punkt]= Math.Sqrt(points[i][0] * points[i][0] + points[i][1] * points[i][1]);




            }
            var distance2 = dictionary.OrderBy(x => x.Value).Select(e=>e.Key).Take(K).ToArray();

            for (int i = 0; i <= K-1; i++)
            {
                
                points[i][0] = distance2[i].x;
                points[i][1] = distance2[i].y;
                
            }

           


            return points.Take(K).ToArray();
            

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int K = 2;
            int[][] array = new int[][]
            {
                new int[]{3,3},
                new int[]{5,-1},
                new int[]{-2,4},
                new int[]{-8,0}
                
            };
            Solution solution = new Solution();
            solution.KClosest(array, K);
            Console.ReadKey();
        }
    }
}

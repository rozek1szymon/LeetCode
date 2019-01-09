using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteColumnsToMakeSorted
{

    public class Solution
    {
        public int MinDeletionSize(string[] A)
        {
            Console.WriteLine(A.Length);
            List<char>[] list = new List<char>[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                list[i] = new List<char>();
                for (int j = 0; j < A[i].Length; j++)
                {
                    
                    list[i].Add(A[j][i]);

                }
            }
            int returner=0;
            int [] yesOrNo = new int [A.Length];
            for (int j = 0; j < A.Length; j++)
            {
                for (int i = 0; i < list[j].Count - 1; i++)
                {
                    if (list[j][i] > list[j][i + 1])
                    {

                    }
                    else
                        yesOrNo[j]++;
                }
                if (yesOrNo[j] == 0) { returner++; }

            }


            Console.WriteLine(list[0][1]);

            return returner;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] table = { "xtr", "tfr"};
            Solution solution = new Solution();
            solution.MinDeletionSize(table);
            if('w'>'t')
                Console.WriteLine("chuj");
            Console.ReadLine();

        }

    }
}

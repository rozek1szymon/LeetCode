using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotReturnToOrigin
{
    public class Solution
    {
        public bool JudgeCircle(string moves)
        {
            int down=0, up=0, left=0, right=0;
            for (int i = 0; i < moves.Length; i++)
            {
                if(moves[i]=='U')
                {
                    up ++;
                }
                if (moves[i] == 'D')
                {
                    down++;
                }
                if (moves[i] == 'L')
                {
                    left++;
                }
                if (moves[i] == 'R')
                {
                    right++;
                }
            }
            if (up == down && right == left)
                return true;
            else
                return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.JudgeCircle("DDUULR");
            Console.ReadLine();

        }
    }
}

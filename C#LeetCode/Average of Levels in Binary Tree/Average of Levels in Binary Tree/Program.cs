using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_of_Levels_in_Binary_Tree
{



    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

  
    public class Solution
    {
        private List<double> averageOfValuesInLine = new List<double>();
        public IList<double> AverageOfLevels(TreeNode root)
        {
                                         
             if(root!=null)
             {
                Console.WriteLine(root.val);
                AverageOfLevels(root.left);              
                AverageOfLevels(root.right);               
             }
            Console.WriteLine("null");
            return averageOfValuesInLine;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3);
            TreeNode node1 = new TreeNode(9);
            TreeNode node2 = new TreeNode(20);
            TreeNode node3 = new TreeNode(15);
            TreeNode node4 = new TreeNode(7);
            root.left = node1;
            root.right = node2;
            node2.left = node3;
            node2.right = node4;
            Solution solution = new Solution();
            solution.AverageOfLevels(root);
            Console.ReadKey();

        }
    }
}

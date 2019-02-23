using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoBinaryTrees
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
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null) return t2;
            if (t2 == null) return t1;

            var root = new TreeNode(t1.val + t2.val);
           

            root.left = MergeTrees(t1.left, t2.left);
            root.right = MergeTrees(t1.right, t2.right);

            return root;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var tree = new TreeNode(1);
            var tree2 = new TreeNode(2);
            //////////////////////////////////////
            tree.right = new TreeNode(2);
            tree.left = new TreeNode(3);
            tree.left.left = new TreeNode(5);
            //////////////////////////////////////
            tree2.right = new TreeNode(3);
            tree2.left = new TreeNode(1);
            tree2.right.right = new TreeNode(7);
            tree2.left.right = new TreeNode(4);
            Solution solution = new Solution();
            solution.MergeTrees(tree, tree2);

            Console.ReadKey();

            
        }
    }
}

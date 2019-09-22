using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invert_Binary_Tree
{

 
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
 
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null || (root.left == null && root.right == null))
                return root;

            var changer = root.left;

            root.left = root.right;

            root.right = changer;

            InvertTree(root.left);

            InvertTree(root.right);


            return root;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(4);
            TreeNode node1 = new TreeNode(2);
            TreeNode node2 = new TreeNode(7);
            TreeNode node3 = new TreeNode(1);
            TreeNode node4 = new TreeNode(3);
            TreeNode node5 = new TreeNode(6);
            TreeNode node6 = new TreeNode(9);
            root.left = node1;
            root.right = node2;
            node1.left = node3;
            node1.right = node4;
            node2.left = node5;
            node2.right = node6;

            Solution solution = new Solution();

            solution.InvertTree(root);
            Console.ReadKey();
        }
    }
}

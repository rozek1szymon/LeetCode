using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree_to_Greater_Sum_Tree
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
        private int count = 0;
        private TreeNode mainRoot = new TreeNode(0);
        private int finalResult;
        public TreeNode BstToGst(TreeNode root)
        {          
            if (count==0)
            {               
                mainRoot = root;
                count++;
            }
                            
            if (root == null)
               return null;

            Console.WriteLine(root.val);
            finalResult = 0;
            count2 = 0;
            Console.WriteLine(valueOfGreater(mainRoot, root.val)); 


            if (root.left!=null)
            {
                BstToGst(root.left);
            }
            if(root.right!=null)
            {
                BstToGst(root.right);
            }

            return root;
        }
        
        private int count2 = 0;
        private int valueOfGreater(TreeNode root, int value)
        {
            if (count2 == 0)
            {
                finalResult = value;
                count2++;
            }
            if (root.val > value)
                finalResult += root.val;
            if (root.left == null && root.right==null)
                return finalResult;
            

            if (root.left != null && root.left.val>=value)
            {
              valueOfGreater(root.left, value);
                return finalResult;
            }
            if (root.right != null && root.right.val>=value)
            {
               valueOfGreater(root.right, value);
                return finalResult;
            }
            return value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(4);
            TreeNode node1 = new TreeNode(2);
            TreeNode node2 = new TreeNode(3);
            TreeNode node3 = new TreeNode(6);
            TreeNode node4 = new TreeNode(5);
            
            root.left = node1;
            root.right = node3;
            node1.right = node2;
            node3.left = node4;
            Solution solution = new Solution();
            solution.BstToGst(root);
            Console.ReadKey();

        }
    }
}

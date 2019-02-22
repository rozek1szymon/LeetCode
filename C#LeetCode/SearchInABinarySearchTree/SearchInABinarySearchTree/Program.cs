using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInABinarySearchTree
{



      
  //Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
 
    public class Solution
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root.val == val)
                return root;
            else
            {
                if (val > root.val)
                {
                    if (root.right != null )
                      return  SearchBST(root.right, val);

                }

                else if(val < root.val)
                {
                    if (root.left != null )
                       return SearchBST(root.left, val);
                }



               
            }


            return null;

        }
    }









    class Program
    {
        static void Main(string[] args)
        {

            TreeNode tree = new TreeNode(4);      //        4
            tree.right = new TreeNode(7);         //       / \
            tree.left = new TreeNode(2);         //       2   7  
            tree.left.left = new TreeNode(1);    //      / \  
            tree.left.right = new TreeNode(3);    //    1   3


            Solution solution = new Solution();
            Console.WriteLine(solution.SearchBST(tree, 3).val);

            
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}

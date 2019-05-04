using System;

namespace Univalued_Binary_Tree
{

    
   
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
       public TreeNode(int x) { val = x; }
    }
   
    public class Solution
    {
        public bool IsUnivalTree(TreeNode root)
        {
            
            if(root.left != null )
            {
              if(!IsUnivalTree(root.left))
                return  false;
                if (root.left.val != root.val)
                return false;
            }
             if(root.right != null )
            {
                if (!IsUnivalTree(root.right))
                    return false;
                if (root.right.val != root.val)
                    return false;
            }
              
                   
            return true;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            TreeNode treeNode = new TreeNode(1);
            TreeNode treeNode1 = new TreeNode(1);
            TreeNode treeNode2 = new TreeNode(1);
            TreeNode treeNode3 = new TreeNode(1);
            TreeNode treeNode4 = new TreeNode(1);
            TreeNode treeNode5 = new TreeNode(1);
            treeNode.left = treeNode1;
            treeNode.right = treeNode2;
            treeNode1.left = treeNode3;
            treeNode1.right = treeNode4;
            treeNode2.right = treeNode5;

            Solution solution = new Solution();
            Console.WriteLine(solution.IsUnivalTree(treeNode));
            Console.ReadKey();


            
        }
    }
}

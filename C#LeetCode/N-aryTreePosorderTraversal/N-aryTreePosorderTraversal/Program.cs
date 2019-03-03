using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_aryTreePosorderTraversal
{




    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }
        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }

    public class Solution
    {
        public IList<int> Postorder(Node root)
        {

        }
    }




    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

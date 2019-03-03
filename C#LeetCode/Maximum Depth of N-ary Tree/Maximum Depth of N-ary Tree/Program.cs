using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Depth_of_N_ary_Tree
{

    
     
    public class Node {
        public int val;
        public IList<Node> children;

        public Node(){}
        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
    
    public class Solution
    {
        public int MaxDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }
                

            if (root.children == null || root.children.Count == 0)
            {
                return 1;
            }


            var list = new List<int>();

            foreach (var child in root.children)
                {
                    list.Add(MaxDepth(child));
                }
            
            return list.Max() + 1;
        }
        
    }



    class Program
    {
        static void Main(string[] args)
        {
            Node node2 = new Node();
            node2.val = 3;
            Node node1 = new Node();
            node1.val = 2;
            Node node3 = new Node();
            node3.val = 4;
            IList<Node> lista = new List<Node>();
            lista.Add(node1);
            lista.Add(node2);
            lista.Add(node3);
            Node root = new Node(1,lista);
            Node node4 = new Node();
            node4.val = 5;
            Node node5 = new Node();
            node5.val = 6;
            IList<Node> lista1 = new List<Node>();
            lista1.Add(node4);
            lista1.Add(node5);
            node3.children = lista1;
            Solution solution = new Solution();
            Console.WriteLine(solution.MaxDepth(root)); 

            Console.ReadKey();




        }
    }
}

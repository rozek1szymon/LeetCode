using System;

namespace To_Lower_Case
{

    
   
    public class ListNode {
      public int val;
        public ListNode next;
        public ListNode() { val = 0; }
        public ListNode(int x) { val = x; }
    }
   
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode returner = new ListNode(1);
             int indexer = 1;
            ListNode first = head;
            while (head.next!=null)
            {
                indexer++;
                head = head.next;
                               
            }
            
            if(indexer!=1)
           {
            
                for (int i = 0; i < indexer/2; i++)
                {
                    first = first.next;
                    returner = first;
                }
            }
          
            Console.WriteLine(returner.val);
            return returner;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode list = new ListNode(1);
            ListNode list1 = new ListNode(2);
            ListNode list2 = new ListNode(3);
            ListNode list3 = new ListNode(4);
            ListNode list4 = new ListNode(5);
            ListNode list5 = new ListNode(6);
            list.next = list1;
            list1.next = list2;
            list2.next = list3;
            list3.next = list4;
            list4.next = list5;
            Console.WriteLine(list4.next);
            Solution solution = new Solution();
            solution.MiddleNode(list);


            Console.ReadKey();
        }
    }
}

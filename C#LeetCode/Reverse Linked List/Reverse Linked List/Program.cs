﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Linked_List
{

 
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }
 
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {

            ListNode reversed = null;
            while (head != null)
            {
                ListNode pTmp = reversed;
                reversed = head;
                head = head.next;
                reversed.next = pTmp;
            }

            return reversed;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            ListNode node1 = new ListNode(2);
            ListNode node2 = new ListNode(3);
            ListNode node3 = new ListNode(4);
            ListNode node4 = new ListNode(5);
            head.next = node1;
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            Solution solution = new Solution();
            solution.ReverseList(head);


            Console.ReadLine();
        }
    }
}

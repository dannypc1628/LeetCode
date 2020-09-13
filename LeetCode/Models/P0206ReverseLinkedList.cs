using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Models
{
    public class P0206ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            var stack = new Stack<ListNode>();

            var node = head;
            while (node!=null)
            {
                stack.Push(node);
                node = node.next;
            }

            var ans = stack.Pop();
            var point = ans;
            while (stack.Count>0)
            {
                point.next = stack.Pop();
                point = point.next;
            }

            point.next = null;
            return ans;
        }
    }
    
}

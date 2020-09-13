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

            var ans = new ListNode(stack.Pop().val);
            var point = ans;
            while (stack.Count>0)
            {
                point.next = new ListNode(stack.Pop().val);
                point = point.next;
            }

            return ans;
        }
    }
    
}

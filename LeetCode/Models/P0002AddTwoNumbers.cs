using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Models
{
    public class P0002AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var sum = new ListNode
            {
                val = l1.val + l2.val
            };
            var q = sum.val / 10;
            sum.val %= 10;
            if (l1.next != null && l2.next != null)
            {
                l1.next.val += q;
                sum.next = AddTwoNumbers(l1.next, l2.next);
            }
            else if (l1.next == null && l2.next == null)
            {
                if (q > 0)
                    sum.next = new ListNode(1);
            }
            else
            {
                if (l1.next != null && l2.next == null)
                {
                    l2.next = new ListNode(q);
                    sum.next = AddTwoNumbers(l1.next, l2.next);
                }
                else
                {
                    l1.next = new ListNode(q);
                    sum.next = AddTwoNumbers(l1.next, l2.next);
                }

            }
            return sum;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}

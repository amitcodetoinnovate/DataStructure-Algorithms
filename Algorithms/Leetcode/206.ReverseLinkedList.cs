//https://leetcode.com/problems/reverse-linked-list/
using DataStructures;


namespace Algorithms.Leetcode
{
    public class ReverseLinkedList
    {
        public static ListNode SolveRecursive(ListNode head)
        {

            if (head == null || head.next == null)
                return head;
            ListNode x = SolveRecursive(head.next);
            ListNode next = head.next;
            next.next = head;
            return x;
        }

        public static ListNode SolveIterative(ListNode head)
        {
            ListNode curr = head, prev = null;
            for(; curr != null;)
            {
                ListNode temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }
            return prev;
        }
    }
}

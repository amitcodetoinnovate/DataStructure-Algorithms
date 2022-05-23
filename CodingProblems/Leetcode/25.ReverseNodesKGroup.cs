//https://leetcode.com/problems/reverse-nodes-in-k-group/
using DataStructures;

namespace CodingProblems.Leetcode
{
    public class ReverseNodesKGroup
    {
        public static ListNode SolveIterative(ListNode head, int k)
        {
            int c = 0;
            for (ListNode t = head; t != null; t = t.next, c++) { }
            
            int batchNum = c / k;
            
            ListNode newHead = head, curr = head, prevNodeNewTail = head;
            
            for (int i = 0; i < batchNum; i++)
            {
                ListNode prev = null,lastNodeNewTail = curr;
                for (int j = 0; j < k; j++)
                {
                    ListNode tempNext = curr.next;
                    curr.next = prev;
                    prev = curr;
                    curr = tempNext;
                }
                prevNodeNewTail.next = prev;
                prevNodeNewTail = lastNodeNewTail;
                if (i == 0)
                    newHead = prev;
                if (i == batchNum - 1)
                    prevNodeNewTail.next = curr;
            }

            return newHead;
        }

        public static ListNode SolveRecursive(ListNode head,int k)
        {
            int c = 0;
            for(ListNode t = head;t != null && c<k;t = t.next, c++) { }
            if (c < k)
                return head;
            ListNode curr = head, headCopy = head, prev = null;
            for(int i = 0; i < k; i++)
            {
                ListNode temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }
            headCopy.next = SolveRecursive(curr, k);
            return prev;

        }
    }
}
    
//https://leetcode.com/problems/merge-two-sorted-lists/

using DataStructures;

namespace CodingProblems.Leetcode
{
    public class MergeTwoSortedLists
    {
        public ListNode MergeLoop(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            for (ListNode temp = dummy; l1 != null || l2 != null; temp = temp.next)
            {
                if (l1 != null && l2 != null)
                {
                    int c = l1.val.CompareTo(l2.val);
                    if (c < 0)
                    {
                        temp.next = new ListNode(l1.val);
                        l1 = l1.next;
                    }
                    else
                    {
                        temp.next = new ListNode(l2.val);
                        l2 = l2.next;
                    }
                    continue;
                }
                else if (l1 != null)
                {
                    temp.next = new ListNode(l1.val);
                    l1 = l1.next;
                    continue;
                }
                temp.next = new ListNode(l2.val);
                l2 = l2.next;
            }
            return dummy.next;
        }
        public ListNode MergeRecurse(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;
            if (l1.val < l2.val)
            {
                l1.next = MergeRecurse(l1.next, l2);
                return l1;
            }
            l2.next = MergeRecurse(l1, l2.next);
            return l2;
        }

    }
}

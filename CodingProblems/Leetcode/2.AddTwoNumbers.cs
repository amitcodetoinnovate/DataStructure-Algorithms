//https://leetcode.com/problems/add-two-numbers/
using DataStructures;

namespace CodingProblems.Leetcode
{
    public class AddTwoNumbers
    {
        public ListNode Solve(ListNode l1, ListNode l2)
        {
            int c = 0;
            ListNode dummy = new ListNode(), temp;

            for (temp = dummy; l1 != null || l2 != null; temp = temp.next)
            {
                int tempSum = c;
                if (l1 != null)
                {
                    tempSum += l1.val;
                    l1 = l1.next;

                }

                if (l2 != null)
                {
                    tempSum += l2.val;
                    l2 = l2.next;
                }
                c = tempSum / 10;
                temp.next = new ListNode(tempSum % 10, null);
            }

            while (c != 0)
            {

                temp.next = new ListNode(c % 10, null);
                temp = temp.next;
                c /= 10;
            }

            return dummy.next;
        }
    }
}

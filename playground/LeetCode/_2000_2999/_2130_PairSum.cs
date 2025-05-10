using playground.DataStructures;

namespace playground.LeetCode._2000_2999;

public class _2130_PairSum
{
    public static int PairSum(ListNode head)
    {
        ListNode s = head, f = head;
        while (f.next.next != null)
        {
            s = s.next;
            f = f.next.next;
        }

        ListNode first = head, second = ListNode.Reverse(s.next);
        int max = 0;
        while (second != null)
        {
            max = Math.Max(max, first.val + second.val);
            first = first.next;
            second = second.next;
        }
        return max;
    }
}

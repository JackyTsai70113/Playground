namespace playground.LinkedLists;

public class PairSumClass
{
    /// <remarks>https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list</remarks>
    public static int PairSum(ListNode head)
    {
        ListNode s = head, f = head;
        while (f.next.next != null)
        {
            s = s.next;
            f = f.next.next;
        }

        static ListNode Reverse(ListNode head)
        {
            ListNode pre = new(0), p = head;
            while (p != null)
            {
                var temp = p.next;
                p.next = pre.next;
                pre.next = p;
                p = temp;
            }
            return pre.next;
        }

        ListNode first = head, second = Reverse(s.next);
        var res = 0;
        while (second != null)
        {
            res = Math.Max(res, first.val + second.val);
            first = first.next;
            second = second.next;
        }
        return res;
    }
}

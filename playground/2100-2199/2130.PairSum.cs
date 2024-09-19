namespace playground;

public class PairSum2130
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

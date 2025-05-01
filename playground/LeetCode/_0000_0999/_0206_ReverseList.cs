using playground.LeetCode.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0206_ReverseList
{
    public static ListNode ReverseList(ListNode head)
    {
        if (head == null)
            return null;
        return ListNode.Reverse(head);
    }
}

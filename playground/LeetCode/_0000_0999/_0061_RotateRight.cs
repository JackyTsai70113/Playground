using playground.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0061_RotateRight
{
    /// <summary>
    /// https://leetcode.com/problems/rotate-list
    /// </summary>
    public static ListNode RotateRight(ListNode head, int k)
    {
        if (head == null || k == 0) return head;
        ListNode pre = new(0, head), slow = pre, fast = pre;
        int count = 0;

        while (fast.next != null)
        {
            count++;
            fast = fast.next;
        }

        if (k % count == 0) return head;

        for (int i = 0; i < count - k % count; ++i)
        {
            slow = slow.next;
        }
        fast.next = head;
        pre.next = slow.next;
        slow.next = null;
        return pre.next;
    }
}

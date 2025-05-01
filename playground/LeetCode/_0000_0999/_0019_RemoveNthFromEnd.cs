using playground.LeetCode.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0019_RemoveNthFromEnd
{
    /// <summary>
    /// https://leetcode.com/problems/remove-nth-node-from-end-of-list
    /// </summary>
    public static ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode pre = new ListNode(0, head), slow = pre, fast = pre;
        for (int i = 0; i < n + 1; i++)
        {
            fast = fast.next;
        }
        while (fast != null)
        {
            slow = slow.next;
            fast = fast.next;
        }
        slow.next = slow.next.next;
        return pre.next;
    }
}

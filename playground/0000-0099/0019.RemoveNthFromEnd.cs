namespace playground;

public class RemoveNthFromEnd0019
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

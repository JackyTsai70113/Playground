using playground.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0141_HasCycle
{
    /// <summary>
    /// https://leetcode.com/problems/linked-list-cycle
    /// </summary>
    public static bool HasCycle(ListNode head)
    {
        ListNode slow = head, fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast) return true;
        }
        return false;
    }
}

using playground.Notes.DataStructure;

namespace playground;

public class HasCycle0141
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

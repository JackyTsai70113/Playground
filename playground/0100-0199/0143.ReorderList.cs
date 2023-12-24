namespace playground;

public class ReorderList_0143
{
    /// <summary>
    /// https://leetcode.com/problems/reorder-list
    /// </summary>
    public static void ReorderList(ListNode head)
    {
        ListNode slow = head, fast = head;
        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        Stack<ListNode> s = new();
        var cur = slow.next;
        slow.next = null;
        while (cur != null)
        {
            s.Push(cur);
            cur = cur.next;
        }
        cur = head;
        while (cur != null && s.Count > 0)
        {
            var node = s.Pop();
            node.next = cur.next;
            cur.next = node;
            cur = cur.next.next;
        }
    }
}

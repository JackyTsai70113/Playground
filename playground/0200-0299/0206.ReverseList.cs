namespace playground;

public class ReverseList_206
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-linked-list
    /// </summary>
    public static ListNode ReverseList(ListNode head)
    {
        if (head == null) return null;
        ListNode cur = new(0, head), tail = cur.next;
        while (tail.next != null)
        {
            var next = cur.next;
            cur.next = tail.next;
            tail.next = tail.next.next;
            cur.next.next = next;
        }
        return cur.next;
    }
}

namespace playground;

public class ReverseList206
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-linked-list
    /// </summary>
    public static ListNode ReverseList(ListNode head)
    {
        ListNode newHead = null, cur = head;
        while (cur != null)
        {
            var next = cur.next;
            cur.next = newHead;
            newHead = cur;
            cur = next;
        }
        return newHead;
    }
}

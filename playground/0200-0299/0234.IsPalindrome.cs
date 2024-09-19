namespace playground;

public class IsPalindrome0234
{
    public static bool IsPalindrome(ListNode head)
    {
        ListNode s = head, f = head;
        while (f.next != null && f.next.next != null)
        {
            s = s.next;
            f = f.next.next;
        }
        ListNode sNext = s.next;
        s.next = null;
        ListNode first = head, second = ListNode.Reverse(sNext);
        while (second != null)
        {
            if (first.val != second.val)
                return false;
            first = first.next;
            second = second.next;
        }
        return true;
    }
}

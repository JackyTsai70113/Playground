namespace playground;

public class IsPalindrome0234
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-linked-list
    /// </summary>
    public static bool IsPalindrome(ListNode head)
    {
        ListNode reversedNode = null, cur = head;
        int count = 0;
        while (cur != null)
        {
            cur = cur.next;
            count++;
        }
        cur = head;
        for (int i = 0; i < count / 2; i++)
        {
            var next = cur.next;
            cur.next = reversedNode;
            reversedNode = cur;
            cur = next;
        }
        if (count % 2 == 1)
            cur = cur.next;
        while (reversedNode != null && cur != null)
        {
            if (reversedNode.val != cur.val)
                return false;
            reversedNode = reversedNode.next;
            cur = cur.next;
        }
        return true;
    }
}

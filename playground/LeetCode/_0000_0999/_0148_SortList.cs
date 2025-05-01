using playground.LeetCode.DataStructures;

namespace playground.LeetCode._0000_0999;

public class _0148_SortList
{
    /// <summary>
    /// https://leetcode.com/problems/sort-list
    /// </summary>
    public static ListNode SortList(ListNode head)
    {
        if (head == null || head.next == null) return head;
        ListNode slow = head, fast = head, temp = slow;
        while (fast != null && fast.next != null)
        {
            temp = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        temp.next = null;
        head = SortList(head);
        slow = SortList(slow);
        return Merge(head, slow);
    }

    private static ListNode Merge(ListNode n1, ListNode n2)
    {
        ListNode pre = new(0), cur = pre;
        while (n1 != null && n2 != null)
        {
            if (n1.val <= n2.val)
            {
                cur.next = n1;
                n1 = n1.next;
            }
            else
            {
                cur.next = n2;
                n2 = n2.next;
            }
            cur = cur.next;
        }
        cur.next = n1 ?? n2;
        return pre.next;
    }
}

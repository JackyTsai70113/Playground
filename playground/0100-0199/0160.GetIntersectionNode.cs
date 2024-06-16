namespace playground;

public class GetIntersectionNode0160
{
    /// <summary>
    /// https://leetcode.com/problems/intersection-of-two-linked-lists
    /// </summary>
    public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        ListNode cur1 = headA, cur2 = headB;
        var s = new HashSet<ListNode>();
        while (cur1 != null)
        {
            s.Add(cur1);
            cur1 = cur1.next;
        }
        while (cur2 != null)
        {
            if (s.Contains(cur2))
                return cur2;
            cur2 = cur2.next;
        }
        return null;
    }
}

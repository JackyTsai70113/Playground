using playground.LeetCode.DataStructures;

namespace playground.LeetCode._2000_2999;

public class _2181_MergeNodes
{
    /// <summary>
    /// https://leetcode.com/problems/merge-nodes-in-between-zeros
    /// </summary>
    public static ListNode MergeNodes(ListNode head)
    {
        ListNode res = head, cur = res.next;
        while (cur != null)
        {
            while (cur.next.val != 0)
            {
                cur.val += cur.next.val;
                cur.next = cur.next.next;
            }
            cur.next = cur.next.next;
            cur = cur.next;
        }
        return res.next;
    }
}
